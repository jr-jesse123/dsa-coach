"""Records the lessons' narration as mp3 files, so the player works where the device has no voice
(the Claude app on Android, for one).

  .coach/lessons/audio/<hash>.mp3     one file per spoken text (each `say` and each quiz `explain`)
  .coach/lessons/audio/manifest.json  {"voice": ..., "files": {text: file}}

A file's name is a hash of the voice and the text: editing a line re-records only that line, and
files no lesson uses any more are deleted. Then rebuild the page: python .coach/lessons/build_lessons.py

Engines:
  edge (default)  Edge's neural voices via the `edge-tts` package (pip install edge-tts). Needs internet.
                  Voices: pt-BR-FranciscaNeural (default), pt-BR-AntonioNeural, pt-BR-ThalitaMultilingualNeural.
  espeak          espeak-ng from the system + ffmpeg. Offline, robotic.
  test            ffmpeg tones as long as the speech would be. Only for testing the player.

Run: python .coach/lessons/build_audio.py [--engine edge] [--voice pt-BR-FranciscaNeural] [--rate +0%]
"""
import argparse
import asyncio
import hashlib
import json
import os
import shutil
import subprocess
import sys

HERE = os.path.dirname(os.path.abspath(__file__))
OUT = os.path.join(HERE, "audio")
MANIFEST = os.path.join(OUT, "manifest.json")
sys.path.insert(0, HERE)
from build_lessons import ORDER  # noqa: E402


def texts():
    seen = []
    for name in ORDER:
        for sc in __import__(name).LESSON["scenes"]:
            for st in sc["steps"]:
                for t in (st.get("say"), st.get("quiz", {}).get("explain")):
                    if t and t not in seen:
                        seen.append(t)
    return seen


def fname(voice, text):
    return hashlib.sha1(f"{voice}|{text}".encode("utf-8")).hexdigest()[:12] + ".mp3"


async def edge_one(text, path, voice, rate):
    import edge_tts
    proxy = os.environ.get("EDGE_TTS_PROXY") or None
    for attempt in range(4):
        try:
            await edge_tts.Communicate(text, voice, rate=rate, proxy=proxy).save(path + ".part")
            os.replace(path + ".part", path)
            return
        except Exception as e:  # network hiccups: retry with backoff
            if attempt == 3:
                raise SystemExit(f"edge-tts failed on: {text[:60]}...\n  {e}")
            await asyncio.sleep(2 ** attempt)


def espeak_one(text, path, voice):
    exe = shutil.which("espeak-ng") or shutil.which("espeak")
    if not exe:
        sys.exit("espeak-ng not found on PATH")
    wav = path + ".wav"
    subprocess.run([exe, "-v", voice, "-s", "165", "-w", wav, text], check=True)
    subprocess.run(["ffmpeg", "-loglevel", "error", "-y", "-i", wav, "-ac", "1", "-b:a", "48k", path], check=True)
    os.remove(wav)


def test_one(text, path):
    secs = max(0.6, len(text.split()) / 165 * 60)
    subprocess.run(["ffmpeg", "-loglevel", "error", "-y", "-f", "lavfi", "-i", f"sine=frequency=440:duration={secs:.2f}",
                    "-ac", "1", "-b:a", "32k", path], check=True)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--engine", choices=["edge", "espeak", "test"], default="edge")
    ap.add_argument("--voice", default=None)
    ap.add_argument("--rate", default="+0%", help="edge only, e.g. -10%% or +5%%")
    a = ap.parse_args()
    voice = a.voice or {"edge": "pt-BR-FranciscaNeural", "espeak": "pt-br", "test": "teste"}[a.engine]
    label = f"{a.engine}:{voice}" + (f":{a.rate}" if a.engine == "edge" and a.rate != "+0%" else "")

    os.makedirs(OUT, exist_ok=True)
    all_texts = texts()
    files, todo = {}, []
    for t in all_texts:
        f = fname(label, t)
        files[t] = f
        if not os.path.exists(os.path.join(OUT, f)):
            todo.append((t, os.path.join(OUT, f)))
    print(f"{len(all_texts)} texts, {len(todo)} to record with {label}")

    if a.engine == "edge":
        async def run():
            for i, (t, p) in enumerate(todo, 1):
                await edge_one(t, p, voice, a.rate)
                print(f"  {i}/{len(todo)}", end="\r")
        asyncio.run(run())
    else:
        for t, p in todo:
            espeak_one(t, p, voice) if a.engine == "espeak" else test_one(t, p)

    keep = set(files.values())
    stale = [f for f in os.listdir(OUT) if f.endswith(".mp3") and f not in keep]
    for f in stale:
        os.remove(os.path.join(OUT, f))
    names = {"edge": voice.replace("pt-BR-", "").replace("Neural", "") + ", voz neural", "espeak": "espeak", "test": "tons de teste"}
    json.dump({"voice": names[a.engine], "engine": label, "files": files},
              open(MANIFEST, "w", encoding="utf-8"), ensure_ascii=False, indent=0)
    size = sum(os.path.getsize(os.path.join(OUT, f)) for f in keep)
    print(f"ok  {len(keep)} files ({size // 1024} KB), {len(stale)} stale removed. Now: python .coach/lessons/build_lessons.py")


if __name__ == "__main__":
    main()
