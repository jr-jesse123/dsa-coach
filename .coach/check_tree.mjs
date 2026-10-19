// Structural checks for the decision tree in tree-source.html. Run: node .coach/check_tree.mjs
// - every option points at an existing node or pattern
// - every pattern is reachable from BOTH readings (root = input shape, nroot = what the solution must do)
// - every node is reachable from some root, and every question has a decision criterion in D
// - every Fronteiras neighbour (F[*].k) is an existing pattern
import { readFileSync } from "node:fs";
import { fileURLToPath } from "node:url";

const src = readFileSync(fileURLToPath(new URL("./tree-source.html", import.meta.url)), "utf8");
const start = src.indexOf("const N = {");
const end = src.indexOf("/* Painel de estudo");
const { N, P, D, F } = new Function(src.slice(start, end) + "\nreturn { N, P, D, F };")();

const ROOTS = ["root", "nroot"];
const errors = [];
const isLeaf = go => go.startsWith("p:");

for (const [id, node] of Object.entries(N))
  node.opts.forEach((o, i) => {
    if (isLeaf(o.go) ? !P[o.go.slice(2)] : !N[o.go]) errors.push(`${id}[${i}] points at missing ${o.go}`);
  });

const seenNodes = new Set();
for (const rt of ROOTS) {
  const leaves = new Set();
  (function walk(id) {
    seenNodes.add(id);
    for (const o of N[id].opts) isLeaf(o.go) ? leaves.add(o.go.slice(2)) : walk(o.go);
  })(rt);
  const missing = Object.keys(P).filter(k => !leaves.has(k));
  if (missing.length) errors.push(`${rt}: patterns not reachable: ${missing.join(", ")}`);
  else console.log(`ok  ${rt}: all ${Object.keys(P).length} patterns reachable`);
}

for (const id of Object.keys(N)) {
  if (!seenNodes.has(id)) errors.push(`node ${id} is not reachable from any root`);
  if (!D[id]) errors.push(`node ${id} has no decision criterion in D`);
}
for (const [k, list] of Object.entries(F))
  for (const b of list) if (b.k && !P[b.k]) errors.push(`F.${k} cites missing pattern ${b.k}`);

if (errors.length) { console.error(errors.map(e => "ERR " + e).join("\n")); process.exit(1); }
console.log(`ok  ${Object.keys(N).length} nodes, all reachable, all with a criterion`);
