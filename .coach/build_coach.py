"""Builds the two pages from coach.template.html + the user's pattern-tree artifact (CSS scoped, JS wrapped):

  .lavish/tree.html     the pattern tree, opened in Lavish (anchored questions). Static; carries only `solved` from state.json.
  .coach/dist/coach.html the coach page, served by server.py (injects state.json + thread.jsonl into #state).
"""
import json
import os
import re
import sys

HERE = os.path.dirname(os.path.abspath(__file__))
ART = os.path.join(HERE, "tree-source.html")          # copy of the user's "Árvore de Padrões" artifact
TPL = os.path.join(HERE, "coach.template.html")
STATE = os.path.join(HERE, "state.json")
OUT_TREE = os.path.join(HERE, "..", ".lavish", "tree.html")
OUT_COACH = os.path.join(HERE, "dist", "coach.html")

src = open(ART, encoding="utf-8").read()


def between(start, end, include_start=True):
    i = src.index(start)
    j = src.index(end, i)
    return src[i if include_start else i + len(start):j].rstrip()


css = between("/* passo 0 */", "</style>")                          # tree styles, minus tokens/base
markup = between('  <section class="step0"', "\n</div>\n\n<script>")  # the three <section>s
js = between("const N = {", "/* deep-link")                          # data + render, minus hash deep-link


def scope_css(src, prefix):
    src = re.sub(r"/\*.*?\*/", "", src, flags=re.S)
    out, i = [], 0
    while i < len(src):
        j = src.find("{", i)
        if j < 0:
            break
        head = src[i:j].strip()
        if head.startswith("@media") or head.startswith("@supports"):
            depth, k = 1, j + 1
            while depth:
                depth += {"{": 1, "}": -1}.get(src[k], 0)
                k += 1
            out.append(head + " {\n" + scope_css(src[j + 1:k - 1], prefix) + "\n}")
            i = k
            continue
        k = src.find("}", j)
        sels = ", ".join(prefix + " " + s.strip() for s in head.split(",") if s.strip())
        out.append(sels + " {" + src[j + 1:k] + "}")
        i = k + 1
    return "\n".join(out)


def patch(s, old, new):
    if old not in s:
        sys.exit("patch target not found: " + old[:60])
    return s.replace(old, new, 1)


js = patch(js,
    '<button type="button" class="btn primary" data-reset>Recomeçar</button></div></div>',
    '<button type="button" class="btn" data-reset>Recomeçar</button><button type="button" class="btn primary" data-sendpath>Enviar caminho ao coach</button></div><span class="sent" role="status"></span></div>')
js = patch(js,
    '${path.length ? `<div class="row-btns"><button type="button" class="btn" data-reset>Recomeçar</button></div>` : ""}',
    '<div class="row-btns">${path.length ? `<button type="button" class="btn" data-reset>Recomeçar</button>` : ""}<button type="button" class="btn" data-stuck>Estou em dúvida aqui</button></div><span class="sent" role="status"></span>')
js = patch(js,
    '  else if (b.hasAttribute("data-copy")) {',
    '''  else if (b.hasAttribute("data-sendpath") || b.hasAttribute("data-stuck")) {
    const steps = path.map(st => `${N[st.node].q} → ${N[st.node].opts[st.i].t}`);
    const cur = current();
    const msg = b.hasAttribute("data-sendpath")
      ? `My path in the tree reached "${P[leafId(cur)].name}":\\n` + steps.join("\\n")
      : `I'm stuck at the question "${N[cur].q}". Path so far:\\n` + (steps.join("\\n") || "(start)") + "\\nHelp me with questions, without giving the answer.";
    const ok = window.lavish && window.lavish.queuePrompt
      ? (window.lavish.queuePrompt(msg, { tag: "tree-path", text: msg.split("\\n")[0], element: b, data: { steps } }), true) : false;
    const st = b.closest(".panel").querySelector(".sent");
    if (st) st.textContent = ok ? "Na fila. Clique em Send to Agent." : "Abra pelo Lavish para enviar.";
  }
  else if (b.hasAttribute("data-copy")) {''')
js = patch(js,
    '  if (e.target.matches("input, textarea") || e.metaKey || e.ctrlKey || e.altKey) return;',
    '  if (document.getElementById("tab-tree").hidden) return;\n  if (e.target.matches("input, textarea, select") || e.metaKey || e.ctrlKey || e.altKey) return;')

tpl = open(TPL, encoding="utf-8").read()


def strip(s, name):
    """Drop <!--NAME_START-->...<!--NAME_END--> together with its content."""
    return re.sub(r"<!--%s_START-->.*?<!--%s_END-->" % (name, name), "", s, flags=re.S)


def unwrap(s, name):
    return s.replace(f"<!--{name}_START-->", "").replace(f"<!--{name}_END-->", "")


# --- the tree page: served by Lavish, so questions can point at an exact node or term ---
# Static on purpose: it is rewritten only when tree-source.html or `solved` changes.
solved = json.load(open(STATE, encoding="utf-8")).get("solved", [])
tree = tpl
for name in ("NAV", "COACHSEC", "TABS_JS", "COACH_JS"):
    tree = strip(tree, name)
for name in ("TREESEC", "TREE_JS", "LC"):
    tree = unwrap(tree, name)
tree = (tree.replace('<h1>Coach DSA</h1>', '<h1>Árvore de padrões</h1>')
            .replace('<title>Coach DSA</title>', '<title>Árvore de padrões</title>')
            .replace(' aria-labelledby="t-tree"', "")
            .replace("/*TREE_CSS*/", scope_css(css, "#tab-tree"))
            .replace("<!--TREE_MARKUP-->", markup)
            .replace("/*TREE_JS*/", "(() => {\n" + js + "\nrender();\n})();"))
tree = re.sub(r'(<script type="application/json" id="state">).*?(</script>)',
              lambda m: m.group(1) + "\n" + json.dumps({"solved": solved}, ensure_ascii=False).replace("</", "<\\/") + "\n" + m.group(2),
              tree, count=1, flags=re.S)

# --- the coach page: served by server.py (chat thread, state, save feedback), no tree ---
coach = tpl
for name in ("TREESEC", "TABS_JS", "TREE_JS", "LC"):
    coach = strip(coach, name)
for name in ("COACHSEC", "COACH_JS"):
    coach = unwrap(coach, name)
coach = re.sub(r"<!--NAV_START-->.*?<!--NAV_END-->",
               '<nav class="tabs"><div class="tab" style="cursor:default"><span class="tl">Coach<span class="badge" id="fb-count" hidden></span></span>'
               '<span class="ts" id="coach-sub">Chat, fases e feedback · a árvore está no Lavish</span></div></nav>',
               coach, count=1, flags=re.S)
coach = (coach.replace('<section id="tab-coach" role="tabpanel" aria-labelledby="t-coach" hidden>',
                       '<section id="tab-coach" role="tabpanel">')
              .replace("/*TREE_CSS*/", ""))

for path_, html in ((OUT_TREE, tree), (OUT_COACH, coach)):
    os.makedirs(os.path.dirname(path_), exist_ok=True)
    open(path_, "w", encoding="utf-8", newline="\n").write(html)
    print("wrote", path_, len(html), "bytes")
