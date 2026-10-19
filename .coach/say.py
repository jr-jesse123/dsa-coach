"""Post a coach message to the chat thread. Reads the text from stdin (so Markdown and quotes need no shell escaping).

    python .coach/say.py <<'EOF'
    text...
    EOF
"""
import json
import os
import sys
import urllib.request

PORT = int(os.environ.get("COACH_PORT", "4400"))
sys.stdin.reconfigure(encoding="utf-8")
text = sys.stdin.read().strip()
if not text:
    sys.exit("nothing to say")
req = urllib.request.Request(f"http://127.0.0.1:{PORT}/api/say", data=json.dumps({"text": text}).encode("utf-8"),
                             headers={"Content-Type": "application/json"})
with urllib.request.urlopen(req, timeout=5) as r:
    print("sent" if r.status == 200 else r.status)
