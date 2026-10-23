#!/usr/bin/env bash
# Emits one line per Problems/** source file (excluding tests) whose content changed since the last 30s poll.
ROOT="$(cd "$(dirname "$0")/../TopCoding.Array/Problems" && pwd)"

snapshot() {
  find "$ROOT" -type f \( -name '*.cs' -o -name '*.md' \) ! -name '*Tests.cs' -print0 2>/dev/null \
    | xargs -0 md5sum 2>/dev/null | LC_ALL=C sort
}

prev=$(snapshot)
while true; do
  sleep 30
  cur=$(snapshot) || continue
  [ -z "$cur" ] && continue
  if [ "$cur" != "$prev" ]; then
    # strip "<hash> " plus md5sum's mode char (' ' or '*' on Windows); keeps paths with spaces whole
    LC_ALL=C comm -13 <(echo "$prev") <(echo "$cur") | sed -E 's/^[0-9a-f]+ [ *]//' | while IFS= read -r f; do
      rel=${f#"$ROOT"/}
      echo "changed: $rel ($(wc -l < "$f") lines) @ $(date +%H:%M:%S)"
    done
    prev=$cur
  fi
done
