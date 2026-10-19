#!/usr/bin/env bash
# Long-polls the Lavish coach page; each delivered feedback becomes Monitor events.
# Usage: lavish-poll.sh ["agent reply to post first"]
F="$(cd "$(dirname "$0")/../.lavish" && pwd -W)/tree.html"
first=1
while true; do
  if [ $first = 1 ]; then
    # --takeover displaces a poll orphaned by a previous session/monitor
    if [ -n "$1" ]; then out=$(lavish-axi poll "$F" --takeover --agent-reply "$1" 2>&1)
    else out=$(lavish-axi poll "$F" --takeover 2>&1); fi
    first=0
  else
    out=$(lavish-axi poll "$F" 2>&1)
  fi
  printf '%s\n' "$out" | grep -v '^\[lavish-axi\] Long-polling'
  if printf '%s' "$out" | grep -qE '^[[:space:]]*(status: (ended|browser_disconnected)|code: LISTENER_ACTIVE)'; then break; fi
  sleep 1
done
