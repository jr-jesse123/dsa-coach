# dsa-coach

Estudo de DSA em C# (47 problemas em `TopCoding.Array`) com um coach socrático no Claude Code (`/dsa-coach`).

> Repositório só local: `TopCoding.Array/TestData/` contém os dados dos testes (spoilers). Não faça push.

## Instalação (Windows)

Rode no PowerShell, como seu usuário.

1. **.NET SDK** (para `dotnet test`), em geral já vem com o Visual Studio.

2. **Git for Windows** (traz o `git` e o Git Bash, usado pelos scripts `.sh`):

   ```powershell
   winget install --id Git.Git -e
   ```

3. **Node.js LTS** (para `check_tree.mjs` e o `lavish-axi`):

   ```powershell
   winget install --id OpenJS.NodeJS.LTS -e
   ```

4. **Python 3.12** (servidor do coach e scripts de build). Se já estiver em `%LOCALAPPDATA%\Programs\Python\Python312`, só ponha no PATH:

   ```powershell
   $py = "$env:LOCALAPPDATA\Programs\Python\Python312"
   [Environment]::SetEnvironmentVariable('Path', "$py;$py\Scripts;" + [Environment]::GetEnvironmentVariable('Path','User'), 'User')
   ```

   Depois desligue o atalho da Microsoft Store: **Configurações > Aplicativos > Configurações avançadas de aplicativos > Aliases de execução de aplicativo**, e desmarque `python.exe` e `python3.exe`. Sem isso, `python` abre a Store.

5. **Lavish** (abre a árvore de decisão com anotações), um plugin do Claude Code:

   ```powershell
   npm install -g lavish-axi
   lavish-axi setup plugin
   ```

6. Feche e reabra o terminal e o Claude Code, para eles lerem o novo PATH.

Para conferir:

```powershell
git --version; node --version; python --version; dotnet --version; lavish-axi --help
```

### Se o Claude Code não acha `python`, `node` ou `lavish-axi`

Os três podem estar instalados e mesmo assim não aparecer no shell do Claude Code (o Bash dá `command not found`). Isso acontece quando o PATH do usuário não tem as pastas deles, ou quando o Claude Code foi aberto antes da instalação. Ponha as três pastas no PATH do usuário:

```powershell
$add = "$env:LOCALAPPDATA\Programs\Python\Python312;$env:ProgramFiles\nodejs;$env:APPDATA\npm"
[Environment]::SetEnvironmentVariable('Path', "$add;" + [Environment]::GetEnvironmentVariable('Path','User'), 'User')
```

Depois reinicie o Claude Code. Para a sessão atual, sem reiniciar, dá para prefixar cada comando no Bash:

```bash
export PATH="/c/Users/$USERNAME/AppData/Local/Programs/Python/Python312:/c/Program Files/nodejs:/c/Users/$USERNAME/AppData/Roaming/npm:$PATH"
```

## Uso

No Claude Code, a partir da raiz do repo (a pasta com `TopCoding.sln`):

```
/dsa-coach
```

Ele sobe a página do coach em http://127.0.0.1:4400, abre a árvore no Lavish e começa a observar os saves de `Solution.cs`.

Comandos úteis à mão:

```powershell
python .coach/server.py           # página do coach (chat)
python .coach/build_coach.py      # rebuild das páginas (coach + árvore)
node .coach/check_tree.mjs        # checagem estrutural da árvore
python .coach/verify_bounds.py    # verifica os contraexemplos da árvore
python .coach/lessons/build_audio.py     # grava a narração das aulas (pip install edge-tts; precisa de internet)
python .coach/lessons/build_lessons.py   # aulas animadas (gera .coach/dist/lessons.html)
dotnet test TopCoding.Array --filter "FullyQualifiedName~P003_"   # testes de um problema
```

## Estrutura

- `TopCoding.Array/Problems/PNNN_Nome/`: `Solution.cs` (seu código), testes e enunciado (`.md`).
- `.coach/`: servidor, template, fonte da árvore, scripts de build e de verificação, `state.json` e `thread.jsonl` (histórico do chat).
- `.coach/lessons/`: aulas animadas e narradas sobre a árvore (player + uma aula por padrão). Publicadas em https://claude.ai/artifact/H1etDc2Mr3MLp6RZkHGk36.
- `.claude/skills/dsa-coach/SKILL.md`: as regras da sessão de coaching.
