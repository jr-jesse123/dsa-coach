"""Aula: Prefix sum + hashmap. Exemplo: LeetCode 974 (fora dos 47), nums = [2, -3, 1, 3], k = 3.

O trace sai de uma simulação do código adaptado (ALT abaixo), com o % de C# (resto com o sinal do dividendo).
O contraexemplo da janela é o mesmo de F.prefix, recalculado aqui como em .coach/verify_bounds.py.
"""

NUMS, K = [2, -3, 1, 3], 3

ALT = """var freq = new Dictionary<int, int> { [0] = 1 };  // prefixo vazio
int prefix = 0, ans = 0;
foreach (var x in nums) {
    prefix += x;
    int key = ((prefix % k) + k) % k;           // resto sempre >= 0
    ans += freq.GetValueOrDefault(key);         // prefixos com o mesmo resto
    freq[key] = freq.GetValueOrDefault(key) + 1;
}
return ans;"""
ALT_DIFF = [4, 5, 6]   # linhas que mudam em relação ao template do card


def cs_mod(a, b):
    """% de C#: o resto tem o sinal do dividendo."""
    r = abs(a) % abs(b)
    return -r if a < 0 else r


def brute(nums, k):
    return sum(1 for i in range(len(nums)) for j in range(i, len(nums)) if sum(nums[i:j + 1]) % k == 0)


def frames(nums, k):
    out, freq, prefix, ans = {}, {0: 1}, 0, 0
    seen = [(0, -1)]          # (resto, índice do prefixo); -1 = prefixo vazio
    pre, rem = [], []

    def snap(fid, line, i, hi=None, spans=None, raw=None):
        out[fid] = {
            "strip": {"range": None, "ptr": {"i": i} if i >= 0 else {}, "spans": spans or [], "good": [], "bad": []},
            "rows": [{"label": "prefix", "vals": pre[:]}, {"label": "resto", "vals": rem[:], "raw": raw}],
            "map": {"title": "freq (Dictionary<int, int>)", "entries": [[kk, v] for kk, v in freq.items()], "hi": hi},
            "vars": [["ans", ans]],
            "code": {"hl": line},
        }

    snap("seed", [0, 1], -1, hi=0)
    for i, x in enumerate(nums):
        prefix += x
        pre.append(prefix)
        raw = cs_mod(prefix, k)
        key = ((raw + k) % k)
        rem.append(key)
        snap(f"add{i}", [2, 3], i)
        snap(f"key{i}", [4], i, raw=[i, raw] if raw != key else None)
        spans = [[j + 1, i] for (r, j) in seen if r == key]
        ans += freq.get(key, 0)
        snap(f"ans{i}", [5], i, hi=key if key in freq else None, spans=spans)
        freq[key] = freq.get(key, 0) + 1
        seen.append((key, i))
        snap(f"reg{i}", [6], i, hi=key)
    snap("done", [8], -1)
    assert ans == brute(nums, k) == 4
    return out


F = frames(NUMS, K)


def fr(fid, **extra):
    d = dict(F[fid])
    d.update(extra)
    return d


# contraexemplo de F.prefix: [1, -1, 1], k = 1 (contar soma exata)
def window_count(nums, k):
    l = s = 0
    got = []
    for r, x in enumerate(nums):
        s += x
        while s > k and l <= r:
            s -= nums[l]
            l += 1
        if s == k:
            got.append([l, r])
    return got


CX = [1, -1, 1]
CX_OK = [[i, j] for i in range(3) for j in range(i, 3) if sum(CX[i:j + 1]) == 1]
CX_WIN = window_count(CX, 1)
assert len(CX_OK) == 3 and len(CX_WIN) == 2


LESSON = {
    "id": "prefix",
    "leaf": "prefix",
    "title": "Prefix sum",
    "kicker": "Aula 2 · contar trechos com uma soma exata",
    "contrast": "window",
    "alt": {"code": ALT, "diff": ALT_DIFF},
    "scenes": [
        {
            "kind": "card", "title": "Gancho",
            "blocks": [
                {"id": "tag", "type": "eyebrow", "text": "LeetCode 974 · Subarray Sums Divisible by K"},
                {"id": "st", "type": "h", "text": "Quantos subarrays têm soma divisível por k?"},
                {"id": "ex", "type": "ex", "text": "nums = [2, −3, 1, 3], k = 3\nresposta: 4\n[2, −3, 1]  [2, −3, 1, 3]  [−3]  [3]"},
                {"id": "bf", "type": "callout", "label": "Força bruta", "text": "Para cada início, somar até cada fim: n² trechos. Cada soma nova repete quase toda a anterior."},
            ],
            "steps": [
                {"say": "Problema: dado um array e um k, quantos subarrays têm soma divisível por k?", "show": {"on": ["tag", "st"]}},
                {"say": "Em 2, menos 3, 1, 3, com k igual a 3, são 4 trechos. Um soma zero, e zero também é divisível.", "show": {"on": ["tag", "st", "ex"], "hi": ["ex"]}},
                {"say": "A força bruta soma todo trecho: n ao quadrado.", "show": {"on": ["tag", "st", "ex", "bf"], "hi": ["bf"]}},
                {"say": "Pause e pense: onde ela desperdiça?",
                 "quiz": {"opts": ["Testa trechos que já sabemos que são inválidos", "Recalcula somas de trechos que dividem quase tudo", "Ordena o array sem precisar"], "correct": 1,
                          "explain": "A soma de 0 a 2 e a de 0 a 3 dividem quase tudo. Lembrando os acumulados, todo trecho vira uma subtração. Na aula da janela a saída era descartar; aqui é lembrar."}},
            ],
        },
        {
            "kind": "card", "title": "Estrutura do problema",
            "blocks": [
                {"id": "k1", "type": "kv", "k": "Forma do input", "v": "um array de inteiros, com negativos, e um k"},
                {"id": "k2", "type": "kv", "k": "O que é pedido", "v": "contar trechos contíguos"},
                {"id": "k3", "type": "kv", "k": "Restrição", "v": "soma divisível por k: uma condição exata, não monotônica"},
                {"id": "sig", "type": "chips", "label": "Sinais no enunciado (card do padrão)", "from": ["P", "prefix", "sig"], "hi": [1, 2]},
            ],
            "steps": [
                {"say": "A forma do input: um array de inteiros, com negativos.", "show": {"on": ["k1"], "hi": ["k1"]}},
                {"say": "O que é pedido: contar trechos contíguos. Contar, e não achar o maior.", "show": {"on": ["k1", "k2"], "hi": ["k2"]}},
                {"say": "A restrição: soma divisível por k, uma condição exata. E o menos 3 faz a soma cair quando o trecho cresce: não há monotonicidade.", "show": {"on": ["k1", "k2", "k3"], "hi": ["k3"]}},
                {"say": "No card, os sinais: pode ter negativos, e soma divisível por k.", "show": {"on": ["k1", "k2", "k3", "sig"], "hi": ["sig"]}},
            ],
        },
        {
            "kind": "tree", "title": "Leitura 1 · pela forma do input", "reading": "root",
            "steps": [
                {"say": "Primeira leitura, pela forma do input. É um array.", "show": {"node": "root", "trail": [], "hi": 0, "showD": False}},
                {"say": "O que se pede sobre o array? Nem um ótimo, nem um par: algo sobre trechos contíguos.", "show": {"node": "arr", "trail": [["root", 0]], "hi": 2, "showD": False}},
                {"say": "Qual é a condição sobre o trecho? Escolha antes de eu dizer.", "show": {"node": "contig", "trail": [["root", 0], ["arr", 2]], "hi": None, "showD": False},
                 "quiz": {"node": True, "correct": 1,
                          "explain": "Soma exata, contar, com negativos. Divisível por k é uma soma exata no resto: resto zero."}},
                {"say": "Compare com a vizinha de cima: a janela pede uma restrição que quebra ao crescer, e os negativos impedem isso. E não é a maior soma, então não é Kadane.", "show": {"hi": 1, "showD": True}},
                {"say": "Folha: prefix sum com hashmap.", "show": {"node": None, "leaf": "prefix", "trail": [["root", 0], ["arr", 2], ["contig", 1]], "showD": False}},
            ],
        },
        {
            "kind": "tree", "title": "Leitura 2 · pelo que a solução precisa fazer", "reading": "nroot",
            "steps": [
                {"say": "Segunda leitura: que trabalho a força bruta repete? Ela recalcula somas. O trabalho é lembrar o que passou e consultar rápido.", "show": {"node": "nroot", "trail": [], "hi": 0, "showD": True}},
                {"say": "Não é descartar: sem monotonicidade, não há garantia.", "show": {"hi": 0, "showD": True}},
                {"say": "O que você precisa lembrar sobre o que já passou?", "show": {"node": "nmem", "trail": [["nroot", 0]], "hi": None, "showD": True}},
                {"say": "Não é só presença, nem o valor que completa um par. É um acumulado até cada posição: trecho é prefixo atual menos prefixo anterior.", "show": {"hi": 2}},
                {"say": "As duas leituras chegam em prefix sum. Na outra aula, chegavam em sliding window. Mesmo input, trechos contíguos, separado por uma pergunta: a validade é monotônica?",
                 "show": {"node": None, "leaf": "prefix", "trail": [["nroot", 0], ["nmem", 2]], "both": [[["root", 0], ["arr", 2], ["contig", 1]], [["nroot", 0], ["nmem", 2]]], "showD": False}},
            ],
        },
        {
            "kind": "trace", "title": "Por que funciona", "cells": NUMS, "code": None, "rowsLabel": True,
            "steps": [
                {"say": "A ideia: trecho de i a j é prefixo em j menos prefixo antes de i. Dois prefixos com o mesmo resto fecham um trecho divisível. Contar trechos vira contar restos repetidos.", "show": fr("seed")},
                {"say": "Antes de tudo, o prefixo vazio: resto zero. Semeamos freq de zero com um.", "show": fr("seed")},
                {"say": "Entra o 2. Resto 2, nunca visto. ans continua zero.", "show": fr("reg0")},
                {"say": "Entra o menos 3. Prefixo menos 1. Cuidado: em C#, menos 1 módulo 3 dá menos 1, e não 2.", "show": fr("key1")},
                {"say": "Corrigido, resto 2, que já vimos: o trecho entre eles, só o menos 3, é divisível. ans vale 1.", "show": fr("ans1")},
                {"say": "Preveja: entra o 1. Prefixo zero, resto zero. Quanto ans soma agora?", "show": fr("key2"),
                 "quiz": {"opts": ["Soma 0", "Soma 1", "Soma 2"], "correct": 1,
                          "explain": "Soma 1: o prefixo vazio da semente. O trecho é 2, menos 3, 1, soma zero. Sem a semente, ele se perde."}},
                {"say": "ans vale 2.", "show": fr("ans2")},
                {"say": "Entra o 3. Resto zero, e já vimos dois: dois trechos de uma vez, o array inteiro e só o 3. ans vale 4.", "show": fr("ans3")},
                {"say": "Uma passada: O de n. O dicionário guarda no máximo k restos.", "show": fr("done")},
            ],
        },
        {
            "kind": "bounds", "title": "Fronteiras", "leaf": "prefix",
            "cx": {"for": "window", "cells": CX, "ok": CX_OK, "win": CX_WIN},
            "steps": [
                {"say": "Fronteiras: vizinhos que parecem servir.", "show": {"on": [], "hi": None}},
                {"say": "A sliding window falha aqui. Ela supõe que a soma só cresce quando a janela cresce. Com negativos, ela descarta trechos válidos.", "show": {"on": ["window"], "hi": "window"}},
                {"say": "No contraexemplo da árvore, 1, menos 1, 1, com soma 1, há 3 trechos.", "show": {"on": ["window"], "hi": "window", "cx": 1}},
                {"say": "A janela conta 2: a soma nunca passa de 1, ela nunca encolhe, e perde o último 1 sozinho.", "show": {"on": ["window"], "hi": "window", "cx": 2}},
                {"say": "Complement é o truque do Two Sum: já vi quem completa este? Aplicado aos prefixos, vira esta aula.", "show": {"on": ["window", "complement"], "hi": "complement", "cx": 2}},
                {"say": "Se a pergunta fosse a maior soma, e não contar, seria Kadane.", "show": {"on": ["window", "complement", "kadane"], "hi": "kadane", "cx": 2}},
                {"say": "A armadilha do card: sem a semente, perdem-se os trechos que começam no índice zero. E corrija o resto negativo.", "show": {"on": ["window", "complement", "kadane"], "hi": None, "trap": True, "cx": 2}},
            ],
        },
        {
            "kind": "trace", "title": "C# em foco", "cells": NUMS, "code": "tpl", "rowsLabel": True,
            "steps": [
                {"say": "O template em C#, para soma exatamente k. Dictionary de prefixo para contagem. Colchete zero igual a um é um inicializador de coleção: já nasce com a semente.", "show": fr("seed", code={"which": "tpl", "hl": [0]})},
                {"say": "A cada número, o prefixo cresce, e contamos os anteriores que valem prefixo menos k. GetValueOrDefault devolve zero se a chave não existe.", "show": fr("add0", code={"which": "tpl", "hl": [3, 4]})},
                {"say": "Primeiro consulta, depois registra. Invertido, o prefixo casaria com ele mesmo: um trecho vazio.", "show": fr("reg0", code={"which": "tpl", "hl": [4, 5]})},
                {"say": "Para divisibilidade, mudam três linhas: a chave vira o resto. Como o módulo de C# fica negativo com dividendo negativo, somamos k e tiramos o resto de novo.", "show": fr("key1", code={"which": "alt", "hl": [4]})},
                {"say": "Com a chave certa, menos 1 vira 2 e acha o par.", "show": fr("ans1", code={"which": "alt", "hl": [5]})},
                {"say": "E registramos o resto, não o prefixo.", "show": fr("reg1", code={"which": "alt", "hl": [6]})},
                {"say": "Custo: O de n no tempo. Espaço: no máximo k restos.", "show": fr("done", code={"which": "alt", "hl": [8]})},
            ],
        },
        {
            "kind": "recap", "title": "Para levar",
            "take": "Prefix sum: lembrar acumulados. Todo trecho é a subtração de dois prefixos, e contar trechos vira contar prefixos num Dictionary.",
            "cards": [
                {"q": "Contar trechos com soma exatamente k, com negativos", "a": "Prefix sum + hashmap", "why": "Trecho = prefixo atual − prefixo anterior. Conte quantos prefixos valem prefixo − k."},
                {"q": "Maior trecho sem caractere repetido", "a": "Sliding window", "why": "Repetição só aparece quando o trecho cresce: validade monotônica."},
                {"q": "Maior soma de um subarray", "a": "Kadane", "why": "É um máximo, não uma contagem: estender ou recomeçar em cada posição."},
            ],
            "steps": [
                {"say": "Três cartões. Diga o padrão em voz alta antes de virar cada um.", "show": {"on": 3}},
                {"say": "A frase para levar: prefix sum é lembrar acumulados. Todo trecho é a subtração de dois prefixos. Revise amanhã, daqui a três dias e daqui a uma semana, alternando com os cartões da janela.", "show": {"take": True}},
            ],
        },
    ],
}
