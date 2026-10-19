"""Checks every counterexample quoted in the tree's Fronteiras section (F in tree-source.html).

Each check runs the naive *neighbour* approach and the correct one on the quoted input
and asserts the numbers the text claims. Run: python .coach/verify_bounds.py
"""
from collections import deque
from itertools import combinations, product


def check(name, got, want):
    assert got == want, f"{name}: got {got}, text claims {want}"
    print("ok ", name, got)


# window vs prefix: count subarrays with sum == k on [1,-1,1], k=1
def window_count(nums, k):
    l = s = cnt = 0
    for r, x in enumerate(nums):
        s += x
        while s > k and l <= r:
            s -= nums[l]
            l += 1
        if s == k:
            cnt += 1
    return cnt


def brute_count(nums, k):
    return sum(1 for i in range(len(nums)) for j in range(i, len(nums)) if sum(nums[i:j + 1]) == k)


check("prefix/window naive", window_count([1, -1, 1], 1), 2)
check("prefix/window correct", brute_count([1, -1, 1], 1), 3)


# deque vs running max on [3,1,1], k=2
def running_max_windows(nums, k):
    out, m = [], float("-inf")
    for i, x in enumerate(nums):
        m = max(m, x)
        if i >= k - 1:
            out.append(m)
    return out


check("deque/running max naive", running_max_windows([3, 1, 1], 2), [3, 3])
check("deque/running max correct", [max([3, 1, 1][i:i + 2]) for i in range(2)], [3, 1])


# two pointers after sorting loses original indices: [3,2,4], target 6
def twoptr_indices(nums, t):
    a = sorted(nums)
    l, r = 0, len(a) - 1
    while l < r:
        s = a[l] + a[r]
        if s == t:
            return [l, r]
        l, r = (l + 1, r) if s < t else (l, r - 1)


check("twoptr/complement naive", twoptr_indices([3, 2, 4], 6), [0, 2])
check("twoptr/complement correct",
      [[i, j] for i, j in combinations(range(3), 2) if [3, 2, 4][i] + [3, 2, 4][j] == 6][0], [1, 2])

# monostack vs heap: [1,2,3], element 1 -> max to the right 3, next greater 2
check("monostack/heap naive", max([1, 2, 3][1:]), 3)
check("monostack/heap correct", next(x for x in [1, 2, 3][1:] if x > 1), 2)


# stack vs counters on "([)]"
def counters_ok(s):
    c = {"(": 0, "[": 0}
    for ch in s:
        if ch in "([":
            c[ch] += 1
        else:
            c["(" if ch == ")" else "["] -= 1
            if min(c.values()) < 0:
                return False
    return all(v == 0 for v in c.values())


def stack_ok(s):
    st, pair = [], {")": "(", "]": "["}
    for ch in s:
        if ch in "([":
            st.append(ch)
        elif not st or st.pop() != pair[ch]:
            return False
    return not st


check("stack/counters naive", counters_ok("([)]"), True)
check("stack/counters correct", stack_ok("([)]"), False)


# dp1 vs greedy: word break "catsand" with {cat, cats, sand}
def greedy_break(s, words):
    i = 0
    while i < len(s):
        m = max((w for w in words if s.startswith(w, i)), key=len, default=None)
        if m is None:
            return False
        i += len(m)
    return True


def dp_break(s, words):
    ok = [True] + [False] * len(s)
    for i in range(1, len(s) + 1):
        ok[i] = any(ok[i - len(w)] and s[i - len(w):i] == w for w in words if len(w) <= i)
    return ok[-1]


check("dp1/greedy naive", greedy_break("catsand", ["cat", "cats", "sand"]), False)
check("dp1/greedy correct", dp_break("catsand", ["cat", "cats", "sand"]), True)

# knapsack vs greedy: capacity 10, items (w, v) = (6,6), (5,5), (5,5)
items, cap = [(6, 6), (5, 5), (5, 5)], 10


def greedy_value(items, cap):
    tot = 0
    for w, v in sorted(items, key=lambda x: -x[1]):
        if w <= cap:
            cap -= w
            tot += v
    return tot


best = max(sum(v for (w, v), b in zip(items, bits) if b) for bits in product([0, 1], repeat=3)
           if sum(w for (w, v), b in zip(items, bits) if b) <= cap)
check("knap/greedy naive", greedy_value(items, cap), 6)
check("knap/greedy correct", best, 10)

# dpgrid vs greedy (always step to the cheaper of right/down)
G = [[1, 1, 5], [3, 9, 9], [1, 1, 1]]


def greedy_path(g):
    i = j = 0
    s = g[0][0]
    m, n = len(g), len(g[0])
    while (i, j) != (m - 1, n - 1):
        if i == m - 1:
            j += 1
        elif j == n - 1:
            i += 1
        elif g[i][j + 1] <= g[i + 1][j]:
            j += 1
        else:
            i += 1
        s += g[i][j]
    return s


def dp_path(g):
    m, n = len(g), len(g[0])
    d = [[0] * n for _ in range(m)]
    for i in range(m):
        for j in range(n):
            up = d[i - 1][j] if i else float("inf")
            left = d[i][j - 1] if j else float("inf")
            d[i][j] = g[i][j] + (0 if i == j == 0 else min(up, left))
    return d[-1][-1]


check("dpgrid/greedy naive", greedy_path(G), 17)
check("dpgrid/greedy correct", dp_path(G), 7)


# min depth: root with only a left child
def naive_min_depth(t):  # t = (left, right) or None
    if t is None:
        return 0
    return 1 + min(naive_min_depth(t[0]), naive_min_depth(t[1]))


def bfs_min_depth(t):
    q = deque([(t, 1)])
    while q:
        node, d = q.popleft()
        if node[0] is None and node[1] is None:
            return d
        q.extend((c, d + 1) for c in node if c is not None)


tree = ((None, None), None)  # root -> left leaf
check("bfstree/postorder naive", naive_min_depth(tree), 1)
check("bfstree/postorder correct", bfs_min_depth(tree), 2)

# BST validation by children only: [5,1,6,null,null,3,7]
BST = (5, (1, None, None), (6, (3, None, None), (7, None, None)))


def children_only(t):
    if t is None:
        return True
    v, l, r = t
    if l and l[0] >= v or r and r[0] <= v:
        return False
    return children_only(l) and children_only(r)


def inorder_ok(t):
    out = []

    def go(n):
        if n:
            go(n[1]); out.append(n[0]); go(n[2])
    go(t)
    return all(a < b for a, b in zip(out, out[1:]))


check("inorder/children naive", children_only(BST), True)
check("inorder/children correct", inorder_ok(BST), False)

# BFS vs DFS shortest path: edges a-b, b-c, c-d, a-d; DFS in listed order
adj = {"a": ["b", "d"], "b": ["a", "c"], "c": ["b", "d"], "d": ["c", "a"]}


def dfs_steps(src, dst):
    seen = set()

    def go(u, d):
        if u == dst:
            return d
        seen.add(u)
        for v in adj[u]:
            if v not in seen:
                r = go(v, d + 1)
                if r is not None:
                    return r
    return go(src, 0)


def bfs_steps(src, dst):
    dist = {src: 0}
    q = deque([src])
    while q:
        u = q.popleft()
        for v in adj[u]:
            if v not in dist:
                dist[v] = dist[u] + 1
                q.append(v)
    return dist[dst]


check("bfs/dfs naive", dfs_steps("a", "d"), 3)
check("bfs/dfs correct", bfs_steps("a", "d"), 1)

# Dijkstra vs BFS: a->b 5, a->c 1, c->b 1
W = {"a": [("b", 5), ("c", 1)], "c": [("b", 1)], "b": []}
fewest_edges_cost = 5  # BFS reaches b first through the direct edge
check("dijkstra/bfs naive", fewest_edges_cost, min(w for v, w in W["a"] if v == "b"))
check("dijkstra/bfs correct", min(5, 1 + 1), 2)


# topo vs union-find on a directed DAG: a->b, a->c, b->c
def uf_flags_cycle(edges):
    parent = {}

    def find(x):
        parent.setdefault(x, x)
        while parent[x] != x:
            x = parent[x]
        return x
    for a, b in edges:
        ra, rb = find(a), find(b)
        if ra == rb:
            return True
        parent[ra] = rb
    return False


def has_directed_cycle(edges):
    nodes = {x for e in edges for x in e}
    indeg = {v: 0 for v in nodes}
    out = {v: [] for v in nodes}
    for a, b in edges:
        out[a].append(b)
        indeg[b] += 1
    q = deque(v for v in nodes if indeg[v] == 0)
    seen = 0
    while q:
        u = q.popleft()
        seen += 1
        for v in out[u]:
            indeg[v] -= 1
            if indeg[v] == 0:
                q.append(v)
    return seen < len(nodes)


E = [("a", "b"), ("a", "c"), ("b", "c")]
check("topo/uf naive", uf_flags_cycle(E), True)
check("topo/uf correct", has_directed_cycle(E), False)

# merge counts blocks, not simultaneous overlap: [[1,5],[2,3],[4,6]]
IV = [[1, 5], [2, 3], [4, 6]]


def merged_blocks(iv):
    out = []
    for s, e in sorted(iv):
        if out and s <= out[-1][1]:
            out[-1][1] = max(out[-1][1], e)
        else:
            out.append([s, e])
    return len(out)


def max_simultaneous(iv):
    ev = sorted([(s, 1) for s, e in iv] + [(e, -1) for s, e in iv], key=lambda x: (x[0], x[1]))
    cur = best = 0
    for _, d in ev:
        cur += d
        best = max(best, cur)
    return best


check("rooms/merge naive", merged_blocks(IV), 1)
check("rooms/merge correct", max_simultaneous(IV), 2)


# by end vs by start: [[1,10],[2,3],[4,5]] max non-overlapping
def keep_by(iv, key):
    kept, last = 0, float("-inf")
    for s, e in sorted(iv, key=key):
        if s >= last:
            kept += 1
            last = e
    return kept


IV2 = [[1, 10], [2, 3], [4, 5]]
check("byend/bystart naive", keep_by(IV2, lambda x: x[0]), 1)
check("byend/bystart correct", keep_by(IV2, lambda x: x[1]), 2)

# min stack vs a single min variable: push 2, push 1, pop
st, m = [], float("inf")
for x in (2, 1):
    st.append(x)
    m = min(m, x)
st.pop()
check("minstack/variable naive", m, 1)
check("minstack/variable correct", min(st), 2)

print("all counterexamples verified")
