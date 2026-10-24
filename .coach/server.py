"""Local server for the coach page (replaces Lavish).

state.json    - written only by the coach (phase, problem, path, question, feedback, solved)
thread.jsonl  - written only by this server, append-only: the user's POST /api/msg and the coach's POST /api/say
ready/PNNN.json - problems understood and recognized elsewhere (e.g. from the phone), ready to code; served as state.ready
GET  /               the built page with state + thread injected into #state
GET  /api/state      {rev, state, thread}; the page polls it and redraws only the regions that changed
POST /api/msg        the user's message from the page   {text, tag, data}
POST /api/say        a coach message                     {text}
GET  /api/health     liveness check
Binds to 127.0.0.1 only. Run: python .coach/server.py   (reuses a server that is already up)
"""
import json
import os
import re
import sys
import threading
import time
import urllib.request
from http.server import BaseHTTPRequestHandler, ThreadingHTTPServer

HERE = os.path.dirname(os.path.abspath(__file__))
STATE = os.path.join(HERE, "state.json")
THREAD = os.path.join(HERE, "thread.jsonl")
READY = os.path.join(HERE, "ready")
PAGE = os.path.join(HERE, "dist", "coach.html")
PORT = int(os.environ.get("COACH_PORT", "4400"))
URL = f"http://127.0.0.1:{PORT}"
MAX_BODY = 1 << 20

lock = threading.Lock()
last_good = {}


def read_state():
    global last_good
    try:
        with open(STATE, encoding="utf-8") as f:
            last_good = json.load(f)
    except (OSError, ValueError):
        pass  # missing or half-written: serve the last good copy
    return last_good


def read_thread():
    out = []
    try:
        with open(THREAD, encoding="utf-8") as f:
            for line in f:
                try:
                    out.append(json.loads(line))
                except ValueError:
                    pass
    except OSError:
        pass
    return out


def read_ready():
    out = []
    try:
        names = sorted(n for n in os.listdir(READY) if re.fullmatch(r"P\d{3}\.json", n))
    except OSError:
        return out
    for name in names:
        try:
            with open(os.path.join(READY, name), encoding="utf-8") as f:
                item = json.load(f)
            if isinstance(item, dict) and isinstance(item.get("n"), int):
                out.append(item)
        except (OSError, ValueError):
            pass  # a half-written or broken file is skipped, not fatal
    return out


def full_state():
    return dict(read_state(), ready=read_ready())


def rev():
    def sig(p):
        try:
            st = os.stat(p)
            return f"{st.st_mtime_ns}.{st.st_size}"
        except OSError:
            return "0"
    try:
        ready = "-".join(sig(os.path.join(READY, n)) for n in sorted(os.listdir(READY)))
    except OSError:
        ready = "0"
    return sig(STATE) + "-" + sig(THREAD) + "-" + ready


def append(msg):
    msg["time"] = time.strftime("%H:%M")
    with lock, open(THREAD, "a", encoding="utf-8", newline="\n") as f:
        f.write(json.dumps(msg, ensure_ascii=False, separators=(",", ":")) + "\n")


def page():
    with open(PAGE, encoding="utf-8") as f:
        html = f.read()
    state = dict(full_state(), thread=read_thread())
    blob = json.dumps(state, ensure_ascii=False).replace("</", "<\\/")
    return re.sub(r'(<script type="application/json" id="state">).*?(</script>)',
                  lambda m: m.group(1) + "\n" + blob + "\n" + m.group(2), html, count=1, flags=re.S)


class Handler(BaseHTTPRequestHandler):
    server_version = "coach"

    def log_message(self, *a):
        pass

    def _host_ok(self):
        return self.headers.get("Host", "") in (f"127.0.0.1:{PORT}", f"localhost:{PORT}")

    def _send(self, code, body, ctype="application/json; charset=utf-8"):
        data = body if isinstance(body, bytes) else body.encode("utf-8")
        self.send_response(code)
        self.send_header("Content-Type", ctype)
        self.send_header("Content-Length", str(len(data)))
        self.send_header("Cache-Control", "no-store")
        self.end_headers()
        self.wfile.write(data)

    def do_GET(self):
        if not self._host_ok():
            return self._send(403, '{"error":"bad host"}')
        path = self.path.split("?")[0]
        if path == "/api/health":
            return self._send(200, '{"ok":true}')
        if path == "/api/state":
            return self._send(200, json.dumps({"rev": rev(), "state": full_state(), "thread": read_thread()}, ensure_ascii=False))
        if path in ("/", "/index.html"):
            try:
                return self._send(200, page(), "text/html; charset=utf-8")
            except OSError:
                return self._send(500, "dist/coach.html is missing: run python .coach/build_coach.py", "text/plain; charset=utf-8")
        self._send(404, '{"error":"not found"}')

    def do_POST(self):
        # a web page elsewhere must not be able to inject "user" messages: same origin and JSON only
        origin = self.headers.get("Origin")
        if not self._host_ok() or (origin and origin not in (URL, f"http://localhost:{PORT}")):
            return self._send(403, '{"error":"forbidden"}')
        if not self.headers.get("Content-Type", "").startswith("application/json"):
            return self._send(415, '{"error":"json only"}')
        n = int(self.headers.get("Content-Length") or 0)
        if n <= 0 or n > MAX_BODY:
            return self._send(400, '{"error":"bad length"}')
        try:
            body = json.loads(self.rfile.read(n).decode("utf-8"))
            text = str(body["text"]).strip()
        except (ValueError, KeyError):
            return self._send(400, '{"error":"bad body"}')
        if not text:
            return self._send(400, '{"error":"empty"}')
        path = self.path.split("?")[0]
        if path == "/api/msg":
            append({"from": "you", "text": text, "tag": str(body.get("tag") or "answer"), "data": body.get("data")})
        elif path == "/api/say":
            append({"from": "coach", "text": text})
        else:
            return self._send(404, '{"error":"not found"}')
        self._send(200, '{"ok":true}')


def main():
    open(THREAD, "a").close()
    try:
        srv = ThreadingHTTPServer(("127.0.0.1", PORT), Handler)
    except OSError:
        try:
            with urllib.request.urlopen(URL + "/api/health", timeout=2) as r:
                if r.status == 200:
                    print("already running at", URL)
                    return 0
        except Exception:
            pass
        print(f"port {PORT} is taken by something else; set COACH_PORT", file=sys.stderr)
        return 1
    print("coach page at", URL, flush=True)
    try:
        srv.serve_forever()
    except KeyboardInterrupt:
        pass
    return 0


if __name__ == "__main__":
    sys.exit(main())
