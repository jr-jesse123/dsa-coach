#!/usr/bin/env bash
# Emits one JSON line per message the user sends from the coach page (thread.jsonl entries with "from":"you").
F="$(cd "$(dirname "$0")" && pwd)/thread.jsonl"
touch "$F"
tail -n0 -F "$F" 2>/dev/null | grep --line-buffered '"from":"you"'
