#!/usr/bin/env bash
# Emits one line per Problems/** source file (excluding tests) whose content changed since the last 30s poll.
ROOT="$(cd "$(dirname "$0")/../TopCoding.Array/Problems" && pwd)"

snapshot() {
  find "$ROOT" -type f \( -name '*.cs' -o -name '*.md' \) ! -name '*Tests.cs' -print0 2>/dev/null \
    | xargs -0 md5sum 2>/dev/null | sort -k2
}

prev=$(snapshot)
while true; do
  sleep 30
  cur=$(snapshot) || continue
  [ -z "$cur" ] && continue
  if [ "$cur" != "$prev" ]; then
    # md5sum on Windows prefixes binary-mode paths with '*'
    comm -13 <(echo "$prev") <(echo "$cur") | awk '{print $2}' | sed 's/^\*//' | while read -r f; do
      rel=${f#"$ROOT"/}
      echo "changed: $rel ($(wc -l < "$f") lines) @ $(date +%H:%M:%S)"
    done
    prev=$cur
  fi
done
