# Problems ready to code

One file per problem, `PNNN.json` (e.g. `P012.json`), written by a session that ran only the Understand and Recognize phases, usually from the phone (branch `mobile`). The PC session lists them on the coach page under "Prontos para codar" and resumes one in the Code phase.

Each file is written only by the mobile session, and removed by the PC session once that problem is solved.

```json
{
  "n": 12,
  "title": "Problem title",
  "updated": "2026-10-24",
  "understood": [
    "What comes in, what goes out, what is guaranteed.",
    "An edge case and its answer."
  ],
  "path": [
    { "q": "Qual é a forma principal do input?", "a": "Array ou string" },
    { "q": "…", "a": "…", "leaf": "<pattern key>" }
  ],
  "strategy": "One line, in the user's words: the approach agreed before coding.",
  "open": ["Questions still open when the session ended."]
}
```

- `n`, `title`: the problem number (1-47) and its title.
- `understood`: the facts settled in the Understand phase, in short sentences.
- `path`: both routes through the tree, in the same `{q, a, leaf?}` format as `path` in `state.json`. `leaf` is a pattern key of the tree.
- `strategy`: the approach agreed when both readings reached the same pattern. Never code.
- `open`: what is still unresolved, so the PC session can start there.
