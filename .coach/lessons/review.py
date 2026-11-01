"""Question bank for the Review tab, generated from the pattern tree (N, P, D, F), the lessons' quizzes
and the problems the user has solved (state.json `solved`).

Every item: {id, type, pats, node?, prompt, code?, opts?, correct?, answer?, explain, lesson?}
  - id is semantic (type + keys), so progress survives rebuilds;
  - opts + correct: multiple choice; answer: self-graded card (Errei / Quase / Acertei);
  - pats: the patterns the item drills (the review's node selector filters on them).
Classics lists (P[k].cl) are never read: they name the 47 problems.
"""
import hashlib
import random

VERD = {"fail": "não serve aqui", "alt": "também funciona", "see": "parente próximo"}
TYPES = {
    "sig": "Sinal → padrão", "node": "Critério do nó", "verd": "Fronteira", "flip": "Quando trocar",
    "cx": "Contraexemplo", "tpl": "Qual template", "cplx": "Complexidade", "trap": "Armadilha",
    "quiz": "Das aulas", "mine": "Seus problemas",
}


def rng(key):
    return random.Random(int(hashlib.sha1(key.encode("utf-8")).hexdigest()[:12], 16))


def build_bank(T, lessons, solved):
    N, P, D, F = T["N"], T["P"], T["D"], T["F"]
    errors = []

    # patterns below each node, per option
    def below(go, seen=None):
        if go.startswith("p:"):
            return {go[2:]}
        seen = seen or set()
        if go in seen:
            return set()
        seen.add(go)
        out = set()
        for o in N[go]["opts"]:
            out |= below(o["go"], seen)
        return out

    # neighbours: Fronteiras both ways + leaf siblings under the same node
    nb = {k: [] for k in P}

    def link(a, b):
        if a != b and a in nb and b in nb:
            if b not in nb[a]:
                nb[a].append(b)
            if a not in nb[b]:
                nb[b].append(a)
    for k, lst in F.items():
        for b in lst:
            if b.get("k"):
                link(k, b["k"])
    for node in N.values():
        leaves = [o["go"][2:] for o in node["opts"] if o["go"].startswith("p:")]
        for a in leaves:
            for b in leaves:
                link(a, b)

    def pick_pats(key, correct, exclude=(), n=3):
        r = rng(key)
        pool = [p for p in nb[correct] if p not in exclude and p != correct]
        r.shuffle(pool)
        out = pool[:n]
        rest = [p for p in P if p not in out and p != correct and p not in exclude]
        r.shuffle(rest)
        out += rest[:n - len(out)]
        opts = [correct] + out
        r.shuffle(opts)
        return opts, opts.index(correct)

    # lesson links: leaf -> {id, scene index by kind}
    lesson_at = {}
    for L in lessons:
        idx = {}
        for i, sc in enumerate(L["scenes"]):
            idx.setdefault(sc["kind"], i)
            if sc["kind"] == "trace" and sc.get("code"):
                idx["code"] = i
        lesson_at[L["leaf"]] = {"id": L["id"], "idx": idx}

    def lesson(k, kind):
        L = lesson_at.get(k)
        if not L:
            return None
        i = L["idx"].get(kind, L["idx"].get("tree", 0))
        return {"id": L["id"], "scene": i}

    name = lambda k: P[k]["name"]
    items = []

    # 1. sinal -> padrão
    owners = {}
    for k in P:
        for s in P[k].get("sig") or []:
            owners.setdefault(s, set()).add(k)
    for k in P:
        for s in P[k].get("sig") or []:
            iid = f"sig|{k}|{s}"
            opts, c = pick_pats(iid, k, exclude=owners[s] - {k})
            items.append({"id": iid, "type": "sig", "pats": [k], "prompt": f"Sinal no enunciado: “{s}”. Qual padrão?",
                          "opts": [name(p) for p in opts], "okeys": opts, "correct": c,
                          "explain": P[k]["idea"], "lesson": lesson(k, "card")})

    # 2. critério do nó: em qual opção cai o exemplo s?
    for nid, node in N.items():
        for i, o in enumerate(node["opts"]):
            if not o.get("s"):
                continue
            iid = f"node|{nid}|{o['t']}"
            r = rng(iid)
            others = [j for j in range(len(node["opts"])) if j != i]
            r.shuffle(others)
            js = [i] + others[:3]
            r.shuffle(js)
            pats = sorted(below(o["go"]))
            items.append({"id": iid, "type": "node", "pats": pats, "node": nid,
                          "prompt": f"{node['q']}\nOnde cai: “{o['s']}”?",
                          "opts": [node["opts"][j]["t"] for j in js], "correct": js.index(i),
                          "explain": D.get(nid, ""), "lesson": lesson(pats[0], "tree") if len(pats) == 1 else None})

    # 3-5. Fronteiras: veredito, quando trocar, contraexemplo
    flips = {k: [b["flip"] for b in F.get(k, []) if b.get("flip")] for k in P}
    all_flips = [f for k in P for f in flips[k]]
    for k, lst in F.items():
        for b in lst:
            other = name(b["k"]) if b.get("k") else b["name"]
            bk = b.get("k") or b["name"]
            pats = [k] + ([b["k"]] if b.get("k") else [])
            items.append({"id": f"verd|{k}|{bk}", "type": "verd", "pats": pats,
                          "prompt": f"Em problemas de {name(k)}, usar {other}:",
                          "opts": list(VERD.values()), "correct": list(VERD).index(b["v"]),
                          "explain": b["why"], "lesson": lesson(k, "bounds")})
            if b.get("flip"):
                iid = f"flip|{k}|{bk}"
                r = rng(iid)
                pool = [f for f in flips[k] if f != b["flip"]]
                r.shuffle(pool)
                extra = [f for f in all_flips if f != b["flip"] and f not in pool]
                r.shuffle(extra)
                opts = [b["flip"]] + (pool + extra)[:3]
                r.shuffle(opts)
                items.append({"id": iid, "type": "flip", "pats": pats,
                              "prompt": f"Você está usando {name(k)}. O que faria {other} ser a escolha certa?",
                              "opts": opts, "correct": opts.index(b["flip"]),
                              "explain": b["why"], "lesson": lesson(k, "bounds")})
            if b.get("cx"):
                items.append({"id": f"cx|{k}|{bk}", "type": "cx", "pats": pats,
                              "prompt": f"Em problemas de {name(k)}, por que {other} {'não serve' if b['v'] == 'fail' else 'erra'}? Pense num contraexemplo pequeno antes de revelar.",
                              "answer": b["cx"], "explain": b["why"], "lesson": lesson(k, "bounds")})

    # 6-8. card: template, complexidade, armadilha
    for k in P:
        if P[k].get("tpl"):
            iid = f"tpl|{k}"
            opts, c = pick_pats(iid, k)
            items.append({"id": iid, "type": "tpl", "pats": [k], "prompt": "De qual padrão é este template?",
                          "code": P[k]["tpl"], "opts": [name(p) for p in opts], "okeys": opts, "correct": c,
                          "explain": f"{name(k)}: {P[k]['op']}.", "lesson": lesson(k, "code")})
        if P[k].get("cx"):
            iid = f"cplx|{k}"
            r = rng(iid)
            mine = P[k]["cx"]
            pool, seen = [], {mine}
            for p in nb[k] + r.sample(list(P), len(P)):
                c = P[p].get("cx")
                if c and c not in seen:
                    seen.add(c)
                    pool.append(c)
            opts = [mine] + pool[:3]
            r.shuffle(opts)
            items.append({"id": iid, "type": "cplx", "pats": [k], "prompt": f"Custo de {name(k)} (tempo · espaço)?",
                          "opts": opts, "correct": opts.index(mine), "explain": P[k]["idea"], "lesson": lesson(k, "trace")})
        if P[k].get("trap"):
            items.append({"id": f"trap|{k}", "type": "trap", "pats": [k],
                          "prompt": f"Qual é a armadilha clássica de {name(k)}?",
                          "answer": P[k]["trap"], "explain": "", "lesson": lesson(k, "bounds")})

    # 9. quizzes das aulas (gancho e nós da árvore; os de trace dependem da animação)
    for L in lessons:
        stmt = next((b["text"] for sc in L["scenes"] if sc["kind"] == "card" for b in sc["blocks"] if b["type"] == "h"), "")
        for si, sc in enumerate(L["scenes"]):
            for st in sc["steps"]:
                q = st.get("quiz")
                if not q or sc["kind"] == "trace":
                    continue
                if q.get("node"):
                    nid = st["show"]["node"]
                    opts = [o["t"] for o in N[nid]["opts"]]
                    prompt = f"Problema: {stmt}\n{N[nid]['q']}"
                else:
                    opts = q["opts"]
                    ask = st["say"].replace("Pause e pense: ", "").replace("Escolha antes de eu dizer.", "").strip()
                    prompt = f"Problema: {stmt}\n{ask[:1].upper() + ask[1:]}"
                items.append({"id": f"quiz|{L['id']}|{si}|{opts[q['correct']]}", "type": "quiz", "pats": [L["leaf"]],
                              "prompt": prompt, "opts": opts, "correct": q["correct"], "explain": q["explain"],
                              "lesson": {"id": L["id"], "scene": si}})

    # 10. seus problemas (só os resolvidos)
    for s in solved:
        k = s["leaf"]
        if k not in P:
            errors.append(f"solved {s['n']}: unknown leaf {k}")
            continue
        iid = f"mine|{s['n']}"
        opts, c = pick_pats(iid, k)
        items.append({"id": iid, "type": "mine", "pats": [k], "prompt": f"Você resolveu “{s['title']}”. Qual padrão, e por que ele funciona?",
                      "opts": [name(p) for p in opts], "okeys": opts, "correct": c, "explain": s["works"], "lesson": lesson(k, "card")})
        for x in s.get("nb", []):
            items.append({"id": f"mine|{s['n']}|{x['name']}", "type": "mine", "pats": [k],
                          "prompt": f"Em “{s['title']}”, por que {x['name']} não serve?", "answer": x["why"], "explain": ""})

    # checks
    ids = set()
    for it in items:
        if it["id"] in ids:
            errors.append(f"duplicate id {it['id']}")
        ids.add(it["id"])
        if "opts" in it:
            if len(set(it["opts"])) != len(it["opts"]) or len(it["opts"]) < 2:
                errors.append(f"{it['id']}: options repeat or too few")
            if not 0 <= it["correct"] < len(it["opts"]):
                errors.append(f"{it['id']}: correct out of range")
        for p in it["pats"]:
            if p not in P:
                errors.append(f"{it['id']}: unknown pattern {p}")
        if it.get("lesson") is None:
            it.pop("lesson", None)
    per = {k: sum(k in it["pats"] for it in items) for k in P}
    for k, n in per.items():
        if n < 5:
            errors.append(f"pattern {k} has only {n} questions")
    return items, per, errors


def selector_tree(T):
    """Both readings, trimmed to what the node selector needs."""
    N, P = T["N"], T["P"]
    return {
        "N": {k: {"q": v["q"], "opts": [{"t": o["t"], "go": o["go"]} for o in v["opts"]]} for k, v in N.items()},
        "names": {k: P[k]["name"] for k in P},
    }
