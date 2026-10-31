"""Builds .coach/dist/lessons.html: the animated lesson player plus the lessons in this folder.

Each lesson (window.py, prefix.py, ...) defines LESSON. Node questions, options, criteria (D), card fields (P)
and Fronteiras (F) are read from .coach/tree-source.html at build time, so the lessons follow the tree.

Checks (the build fails on any):
  - every node, option and pattern a lesson cites exists in the tree;
  - no lesson mentions one of the user's 47 problems, by LeetCode number or by title.
Run: python .coach/lessons/build_lessons.py
"""
import json
import os
import re
import shutil
import subprocess
import sys
import unicodedata

HERE = os.path.dirname(os.path.abspath(__file__))
COACH = os.path.dirname(HERE)
ROOT = os.path.dirname(COACH)
TREE = os.path.join(COACH, "tree-source.html")
CTPL = os.path.join(COACH, "coach.template.html")
PLAYER = os.path.join(HERE, "player.template.html")
OUT = os.path.join(COACH, "dist", "lessons.html")
ORDER = ["window", "prefix"]          # lesson modules, in menu order
AUDIO = os.path.join(HERE, "audio")    # recorded narration (build_audio.py)
OUT_AUDIO = os.path.join(COACH, "dist", "audio")

sys.path.insert(0, HERE)
errors = []


def tree_data():
    js = r"""
const src = require("fs").readFileSync(process.argv[1], "utf8");
const s = src.indexOf("const N = {"), e = src.indexOf("/* Painel de estudo");
const { N, P, D, F } = new Function(src.slice(s, e) + "\nreturn { N, P, D, F };")();
process.stdout.write(JSON.stringify({ N, P, D, F }));
"""
    out = subprocess.run(["node", "-e", js, TREE], capture_output=True, text=True, encoding="utf-8")
    if out.returncode:
        sys.exit("could not read the tree: " + out.stderr)
    return json.loads(out.stdout)


def the47():
    """LeetCode numbers (window.COACH_LC) and titles (statement headers) of the 47 problems."""
    m = re.search(r"window\.COACH_LC\s*=\s*\{([^}]*)\}", open(CTPL, encoding="utf-8").read())
    nums = {int(k) for k in re.findall(r"(\d+):\d+", m.group(1))}
    titles = []
    pdir = os.path.join(ROOT, "TopCoding.Array", "Problems")
    for d in sorted(os.listdir(pdir)):
        md = os.path.join(pdir, d, d + ".md")
        if os.path.exists(md):
            head = open(md, encoding="utf-8").readline()
            titles.append(re.sub(r"^#\s*\d+\.\s*", "", head).strip())
    return nums, titles


def norm(s):
    s = unicodedata.normalize("NFKD", s.lower())
    return re.sub(r"[^a-z0-9]", "", s)


def strings(x):
    if isinstance(x, str):
        yield x
    elif isinstance(x, dict):
        for v in x.values():
            yield from strings(v)
    elif isinstance(x, list):
        for v in x:
            yield from strings(v)


def check_spoilers(lesson, nums, titles):
    text = "\n".join(strings(lesson))
    for n in re.findall(r"(?:LeetCode|LC)\s*#?\s*(\d+)", text):
        if int(n) in nums:
            errors.append(f"{lesson['id']}: mentions LeetCode {n}, one of the 47")
    flat = norm(text)
    for t in titles:
        if len(norm(t)) >= 8 and norm(t) in flat:
            errors.append(f"{lesson['id']}: mentions the title \"{t}\", one of the 47")


def check_refs(lesson, T):
    N, P, F = T["N"], T["P"], T["F"]
    used_nodes, used_pats = set(), {lesson["leaf"], lesson.get("contrast")}
    for sc in lesson["scenes"]:
        for st in sc["steps"]:
            sh = st.get("show", {})
            trails = [sh.get("trail") or []] + list(sh.get("both") or [])
            for trail in trails:
                for node, i in trail:
                    if node not in N or i >= len(N[node]["opts"]):
                        errors.append(f"{lesson['id']}/{sc['title']}: bad trail step {node}[{i}]")
                    else:
                        used_nodes.add(node)
            node = sh.get("node")
            if node:
                if node not in N:
                    errors.append(f"{lesson['id']}: missing node {node}")
                    continue
                used_nodes.add(node)
                if sh.get("hi") is not None and sh["hi"] >= len(N[node]["opts"]):
                    errors.append(f"{lesson['id']}: {node} has no option {sh['hi']}")
            if sh.get("leaf"):
                used_pats.add(sh["leaf"])
        if sc["kind"] == "tree":
            # a full trail must really end in the leaf it names
            for st in sc["steps"]:
                sh = st.get("show", {})
                if sh.get("leaf") and sh.get("trail"):
                    node, i = sh["trail"][-1]
                    if N[node]["opts"][i]["go"] != "p:" + sh["leaf"]:
                        errors.append(f"{lesson['id']}: trail ends at {N[node]['opts'][i]['go']}, not {sh['leaf']}")
        if sc["kind"] == "bounds":
            for b in F.get(sc["leaf"], []):
                if b.get("k"):
                    used_pats.add(b["k"])
    return used_nodes, {p for p in used_pats if p}


def recorded(lessons):
    """Recorded narration from audio/manifest.json, copied next to the page as dist/audio/.
    Texts without a file fall back to the device voice; the build says how many."""
    man = os.path.join(AUDIO, "manifest.json")
    shutil.rmtree(OUT_AUDIO, ignore_errors=True)
    if not os.path.exists(man):
        print("--  no recorded narration (run build_audio.py): the page uses the device voice")
        return None
    m = json.load(open(man, encoding="utf-8"))
    spoken = {t for L in lessons for sc in L["scenes"] for st in sc["steps"]
              for t in (st.get("say"), st.get("quiz", {}).get("explain")) if t}
    files = {t: f for t, f in m["files"].items() if t in spoken and os.path.exists(os.path.join(AUDIO, f))}
    os.makedirs(OUT_AUDIO)
    for f in set(files.values()):
        shutil.copy2(os.path.join(AUDIO, f), OUT_AUDIO)
    missing = len(spoken) - len(files)
    print(f"{'ok ' if not missing else '!! '} recorded narration ({m['voice']}): {len(files)}/{len(spoken)} texts"
          + (f", {missing} not recorded: run build_audio.py" if missing else ""))
    return {"voice": m["voice"], "base": "audio/", "files": files}


def main():
    T = tree_data()
    nums, titles = the47()
    lessons, nodes, pats = [], set(), set()
    for name in ORDER:
        mod = __import__(name)
        L = mod.LESSON
        check_spoilers(L, nums, titles)
        n, p = check_refs(L, T)
        nodes |= n
        pats |= p
        lessons.append(L)
    if errors:
        sys.exit("lesson build failed:\n  " + "\n  ".join(errors))

    # Only what the lessons use: no classics lists (cl), which would name the 47.
    keep = ("name", "ds", "op", "cx", "idea", "sig", "tpl", "trap")
    data = {
        "N": {k: T["N"][k] for k in sorted(nodes)},
        "D": {k: T["D"][k] for k in sorted(nodes) if k in T["D"]},
        "P": {k: {f: T["P"][k].get(f) for f in keep} for k in sorted(pats)},
        "F": {L["leaf"]: T["F"].get(L["leaf"], []) for L in lessons},
    }
    audio = recorded(lessons)
    payload = json.dumps({"tree": data, "lessons": lessons, "audio": audio}, ensure_ascii=False).replace("</", "<\\/")
    html = open(PLAYER, encoding="utf-8").read()
    if "/*__DATA__*/null" not in html:
        sys.exit("player template has no /*__DATA__*/null slot")
    html = html.replace("/*__DATA__*/null", payload, 1)
    os.makedirs(os.path.dirname(OUT), exist_ok=True)
    open(OUT, "w", encoding="utf-8", newline="\n").write(html)

    words = {L["id"]: sum(len(s.get("say", "").split()) + len(s.get("quiz", {}).get("explain", "").split())
                          for sc in L["scenes"] for s in sc["steps"]) for L in lessons}
    for L in lessons:
        w = words[L["id"]]
        print(f"ok  {L['id']}: {len(L['scenes'])} scenes, {w} words of narration ≈ {w / 150:.1f} min at 150 wpm")
    print(f"ok  wrote {os.path.relpath(OUT, ROOT)} ({len(html) // 1024} KB)")


if __name__ == "__main__":
    main()
