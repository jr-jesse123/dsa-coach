"""Aula: Sliding window. Exemplo: LeetCode 3 (fora dos 47), s = "abcbd".

Os frames do trace saem de uma simulação real do template do card (P.window.tpl),
então cada passo mostrado na tela é o que o código faz.
"""

S = "abcbd"


def brute(s):
    return max(j - i + 1 for i in range(len(s)) for j in range(i, len(s)) if len(set(s[i:j + 1])) == j - i + 1)


def frames(s):
    """Eventos do template, linha a linha. Linhas (0-based) do tpl:
    0 var count  1 int l  2 for r  3 count[s[r]]++  4 while (Invalida)  5 if (--count..) Remove  6 l++  8 best = Max"""
    out, count, l, best = {}, {}, 0, 0

    def snap(fid, line, **kw):
        bad = [i for i in range(l, r + 1) if count.get(s[i], 0) > 1] if r >= 0 else []
        out[fid] = {
            "strip": {"range": [l, r], "ptr": {"l": l, "r": r}, "bad": bad},
            "map": {"title": "count (Dictionary<char, int>)", "entries": [[k, v] for k, v in count.items()], "hi": kw.get("hi")},
            "vars": [["best", best], ["r − l + 1", r - l + 1]],
            "code": {"hl": line},
        }

    r = -1
    snap("start", [0, 1])
    for r, ch in enumerate(s):
        count[ch] = count.get(ch, 0) + 1
        snap(f"exp{r}", [2, 3], hi=ch)
        if count[ch] > 1:
            snap(f"inv{r}", [4], hi=ch)
            while count[ch] > 1:
                left = s[l]
                count[left] -= 1
                if count[left] == 0:
                    del count[left]
                l += 1
                snap(f"shr{l}", [5, 6], hi=left)
            snap(f"ok{r}", [4])
        best = max(best, r - l + 1)
        snap(f"best{r}", [8])
    snap("done", [9])
    assert best == brute(s) == 3
    return out


F = frames(S)


def fr(fid, **extra):
    d = {k: v for k, v in F[fid].items()}
    d.update(extra)
    return d


LESSON = {
    "id": "window",
    "leaf": "window",
    "title": "Sliding window",
    "kicker": "Aula 1 · trecho contíguo que quebra ao crescer",
    "contrast": "prefix",
    "scenes": [
        {
            "kind": "card", "title": "Gancho",
            "blocks": [
                {"id": "tag", "type": "eyebrow", "text": "LeetCode 3 · Longest Substring Without Repeating Characters"},
                {"id": "st", "type": "h", "text": "Qual o tamanho da maior substring sem caractere repetido?"},
                {"id": "ex", "type": "ex", "text": "s = \"abcbd\"  →  3   (\"abc\" ou \"cbd\")"},
                {"id": "bf", "type": "callout", "label": "Força bruta", "text": "Testar todo par (início, fim): n² trechos, e checar cada um custa mais n. Total O(n³), ou O(n²) com um set."},
            ],
            "steps": [
                {"say": "Problema: dada uma string, qual o tamanho da maior substring sem caractere repetido?", "show": {"on": ["tag", "st"]}},
                {"say": "Em a b c b d, a resposta é 3: a b c, ou c b d.", "show": {"on": ["tag", "st", "ex"], "hi": ["ex"]}},
                {"say": "A força bruta testa todo par de início e fim: n ao quadrado trechos, cada um checado.", "show": {"on": ["tag", "st", "ex", "bf"], "hi": ["bf"]}},
                {"say": "Pause e pense: onde a força bruta desperdiça?",
                 "quiz": {"opts": ["Testa trechos que já sabemos que são inválidos", "Lê a string mais de uma vez", "Usa memória demais"], "correct": 0,
                          "explain": "Se b c b já repete, todo trecho que o contém também repete, e a força bruta testa todos. É esse desperdício que a sliding window corta."}},
            ],
        },
        {
            "kind": "card", "title": "Estrutura do problema",
            "blocks": [
                {"id": "k1", "type": "kv", "k": "Forma do input", "v": "uma string"},
                {"id": "k2", "type": "kv", "k": "O que é pedido", "v": "o maior trecho contíguo"},
                {"id": "k3", "type": "kv", "k": "Restrição", "v": "sem repetir: quebra ao crescer, volta a valer ao encolher"},
                {"id": "sig", "type": "chips", "label": "Sinais no enunciado (card do padrão)", "from": ["P", "window", "sig"], "hi": [0, 2]},
            ],
            "steps": [
                {"say": "Antes da árvore, separe três coisas. A forma do input: uma string.", "show": {"on": ["k1"], "hi": ["k1"]}},
                {"say": "O que é pedido: o maior trecho contíguo.", "show": {"on": ["k1", "k2"], "hi": ["k2"]}},
                {"say": "A restrição: sem repetir. Ela quebra quando o trecho cresce, e volta a valer quando encolhe. Guarde isso: vai decidir mais à frente.", "show": {"on": ["k1", "k2", "k3"], "hi": ["k3"]}},
                {"say": "No card do padrão, esses são os sinais no enunciado: substring mais longa, e sem caracteres repetidos.", "show": {"on": ["k1", "k2", "k3", "sig"], "hi": ["sig"]}},
            ],
        },
        {
            "kind": "tree", "title": "Leitura 1 · pela forma do input", "reading": "root",
            "steps": [
                {"say": "Primeira leitura: pela forma do input.", "show": {"node": "root", "trail": [], "hi": None, "showD": False}},
                {"say": "É uma string: array ou string.", "show": {"hi": 0}},
                {"say": "Agora: o que o enunciado pede sobre a string?", "show": {"node": "arr", "trail": [["root", 0]], "hi": None, "showD": False}},
                {"say": "Cuidado: o maior é um ótimo, e lembra programação dinâmica. Mas as escolhas não interagem: cada trecho vale ou não por si.", "show": {"showD": True}},
                {"say": "Então é algo sobre um trecho contíguo.", "show": {"hi": 2}},
                {"say": "Qual é a condição sobre o trecho contíguo? Escolha antes de eu dizer.", "show": {"node": "contig", "trail": [["root", 0], ["arr", 2]], "hi": None, "showD": False},
                 "quiz": {"node": True, "correct": 0,
                          "explain": "Uma restrição que quebra ao crescer e volta ao encolher. É exatamente o comportamento do sem repetir."}},
                {"say": "O critério: a validade é monotônica, crescer só piora? Janela. Soma exata ou negativos? Prefix sum. Só a maior soma? Kadane. Um extremo por janela fixa? Deque.", "show": {"hi": 0, "showD": True}},
                {"say": "Folha: sliding window.", "show": {"node": None, "leaf": "window", "trail": [["root", 0], ["arr", 2], ["contig", 0]], "showD": False}},
            ],
        },
        {
            "kind": "tree", "title": "Leitura 2 · pelo que a solução precisa fazer", "reading": "nroot",
            "steps": [
                {"say": "Segunda leitura: que trabalho a força bruta repete, ou faz às cegas?", "show": {"node": "nroot", "trail": [], "hi": None, "showD": False}},
                {"say": "Ela testa trechos que já sabemos inválidos. O trabalho é descartar sem testar. Não é lembrar o que passou, como um hash: é jogar fora, com garantia.", "show": {"hi": 1, "showD": True}},
                {"say": "E todo descarte precisa de uma garantia. Qual é a daqui?", "show": {"node": "ndisc", "trail": [["nroot", 1]], "hi": None, "showD": True}},
                {"say": "A string não está ordenada, então não é dois ponteiros nem binary search. A garantia é a monotonicidade: se l até r é inválido, todo trecho que o contém também é.", "show": {"hi": 1}},
                {"say": "As duas leituras chegam na mesma folha. Quando elas concordam, você pode codar com confiança.",
                 "show": {"node": None, "leaf": "window", "trail": [["nroot", 1], ["ndisc", 1]], "both": [[["root", 0], ["arr", 2], ["contig", 0]], [["nroot", 1], ["ndisc", 1]]], "showD": False}},
            ],
        },
        {
            "kind": "trace", "title": "Por que funciona", "cells": list(S), "code": None,
            "steps": [
                {"say": "A mecânica: r expande a janela, l contrai. O invariant, a regra que vale em todo passo: entre l e r, nada repete.", "show": fr("start")},
                {"say": "r entra no a. A janela a é válida. best vale 1.", "show": fr("best0")},
                {"say": "Entra o b. a b, best 2.", "show": fr("best1")},
                {"say": "Entra o c. a b c, best 3.", "show": fr("best2")},
                {"say": "Entra o segundo b. a b c b repete: inválida. E toda janela maior que comece no zero também. Ninguém precisa testá-las.", "show": fr("inv3")},
                {"say": "Preveja: para a janela voltar a valer, até onde l precisa andar?", "show": fr("inv3"),
                 "quiz": {"opts": ["l = 1: tirar só o a", "l = 2: tirar o a e o primeiro b", "l = 3: começar de novo no b"], "correct": 1,
                          "explain": "l vai até 2. Sair o a não basta: o b continua duas vezes. Por isso o código usa while, e não if."}},
                {"say": "Sai o a. Ainda inválida.", "show": fr("shr1")},
                {"say": "Sai o primeiro b. c b é válida de novo. A contração para aqui.", "show": fr("shr2")},
                {"say": "Entra o d. c b d, tamanho 3. best continua 3.", "show": fr("best4")},
                {"say": "Cada índice entra uma vez e sai no máximo uma vez: O de n, e não n ao quadrado.", "show": fr("done")},
            ],
        },
        {
            "kind": "bounds", "title": "Fronteiras", "leaf": "window",
            "steps": [
                {"say": "Fronteiras: vizinhos que parecem servir.", "show": {"on": [], "hi": None}},
                {"say": "Prefix sum é o vizinho mais perigoso. Com todos positivos ele também resolve trechos com soma, em n log n. Troque para prefix quando houver negativos, ou para contar trechos com soma exata. É a próxima aula.", "show": {"on": ["prefix"], "hi": "prefix"}},
                {"say": "O deque monotônico é parente: a janela não sabe o máximo do trecho depois que alguém sai. Se a restrição usa máximo menos mínimo, ponha um deque ao lado.", "show": {"on": ["prefix", "deque"], "hi": "deque"}},
                {"say": "Dois ponteiros descartam pares graças à ordenação, não trechos. Pares num array ordenado? Troque.", "show": {"on": ["prefix", "deque", "twoptr"], "hi": "twoptr"}},
                {"say": "A armadilha do card: com negativos, a monotonicidade quebra.", "show": {"on": ["prefix", "deque", "twoptr"], "hi": None, "trap": True}},
            ],
        },
        {
            "kind": "trace", "title": "C# em foco", "cells": list(S), "code": "tpl",
            "steps": [
                {"say": "O template em C#. Um Dictionary de char para int conta os caracteres da janela.", "show": fr("start")},
                {"say": "O for move r. GetValueOrDefault devolve zero se a chave não existe: soma um sem checar.", "show": fr("exp3")},
                {"say": "while, e não if: pode precisar encolher várias vezes. Aqui, Invalida é: algum caractere com contagem maior que um.", "show": fr("inv3")},
                {"say": "O decremento vem antes da comparação. Zerou? Remove, para o dicionário guardar só a janela. Depois, l mais mais.", "show": fr("shr1")},
                {"say": "Mais uma volta do while. Agora o b tem contagem um, e o while para.", "show": fr("shr2")},
                {"say": "Só depois do while a janela vale. best recebe r menos l mais um: mais um porque l e r são inclusivos. Confira esse frame de índice com a mão.", "show": fr("best3")},
                {"say": "Custo: O de n no tempo, e espaço do tamanho do alfabeto da janela.", "show": fr("done")},
            ],
        },
        {
            "kind": "recap", "title": "Para levar",
            "take": "Sliding window: a validade do trecho é monotônica. Crescer só piora, encolher conserta. Cada índice entra e sai uma vez.",
            "cards": [
                {"q": "Maior trecho com no máximo k caracteres distintos", "a": "Sliding window", "why": "Mais distintos só aparecem quando o trecho cresce: validade monotônica."},
                {"q": "Contar trechos com soma exatamente k, e há negativos", "a": "Prefix sum + hashmap", "why": "Com negativos, encolher pode aumentar a soma. A janela não sabe quando encolher."},
                {"q": "O máximo de cada janela de tamanho k", "a": "Deque monotônico", "why": "A janela anda sozinha; o difícil é saber o máximo depois que alguém sai."},
            ],
            "steps": [
                {"say": "Três cartões. Diga o padrão em voz alta antes de virar cada um: errar aqui é o que faz lembrar depois.", "show": {"on": 3}},
                {"say": "A frase para levar: sliding window é validade monotônica. Crescer só piora, encolher conserta. Revise estes cartões amanhã, daqui a três dias e daqui a uma semana.", "show": {"take": True}},
            ],
        },
    ],
}
