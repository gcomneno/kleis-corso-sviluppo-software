# Laboratorio SQL — Aggregazione 04

## Obiettivo

Allenarsi con `ORDER BY`, `LIMIT`, `DISTINCT`, funzioni di aggregazione, `GROUP BY` e `HAVING`.

Database: `shop`.

## Ripasso

### R.1 — SELECT con WHERE

Mostra titolo e anno dei brani pubblicati dopo il 2010.

### R.2 — JOIN già noto

Mostra titolo del brano e nome dell'autore.

## Livello 1 — Ordinare, limitare, deduplicare

### 1. Brani dal più vecchio al più recente

Mostra titolo e anno dei brani ordinandoli per anno crescente.

Domanda: cosa succede ai brani con anno `NULL`?

### 2. Brani dal più recente al più vecchio

Mostra titolo e anno dei brani ordinandoli per anno decrescente e, a parità di anno, per titolo crescente.

### 3. I 3 brani più lunghi

Mostra titolo e durata dei 3 brani più lunghi.

### 4. I 5 brani più recenti

Mostra titolo e anno dei 5 brani più recenti.

### 5. Anni diversi

Mostra gli anni distinti presenti nella tabella `brani`, ordinati dal più recente al più vecchio.

## Livello 2 — Aggregazioni

### 6. Numero totale di brani

Conta quanti brani ci sono.

### 7. Brani degli anni Novanta

Conta quanti brani sono stati pubblicati dal 1990 al 1999 compresi.

### 8. COUNT(*) e COUNT(anno)

Mostra in una sola query:

- totale dei brani;
- brani con anno compilato.

Domanda: perché i due numeri sono diversi?

### 9. Anno più vecchio e più recente

Mostra anno minimo e anno massimo.

### 10. Anno medio arrotondato

Calcola l'anno medio e arrotondalo all'intero.

### 11. Brani più lunghi di 5 minuti

Conta quanti brani hanno `durata_minuti > 5`.

## Livello 3 — GROUP BY

### 12. Brani per genere

Mostra quanti brani contiene ogni genere, dal più numeroso al meno numeroso.

### 13. I 5 anni con più brani

Mostra i 5 anni con più brani, escludendo gli anni `NULL`.

### 14. Anno più recente per genere

Per ogni genere, mostra l'anno del brano più recente.

## Livello 4 — HAVING

### 15. Generi con almeno 5 brani

Mostra solo i generi che hanno almeno 5 brani.

### 16. Autori con più di un brano

Mostra solo gli autori presenti con più di un brano.

### 17. Conteggio e anno medio per genere

Per ogni genere mostra:

- nome del genere;
- numero di brani;
- anno medio arrotondato.

Ordina dal genere mediamente più vecchio al più recente.

## Domande di verifica

1. A cosa serve `ORDER BY`?
2. Perché `LIMIT` è più utile insieme a `ORDER BY`?
3. Che differenza c'è tra `COUNT(*)` e `COUNT(anno)`?
4. Perché `durata_minuti` non va sommato direttamente?
5. A cosa serve `GROUP BY`?
6. Che differenza c'è tra `WHERE` e `HAVING`?
7. Quando useresti `DISTINCT`?
