# Soluzioni commentate — SQL Aggregazione 04

## R.1 — SELECT con WHERE

```sql
SELECT titolo, anno
FROM brani
WHERE anno > 2010;
```

## R.2 — JOIN già noto

```sql
SELECT b.titolo, a.nome AS autore
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id;
```

## 1. Brani dal più vecchio al più recente

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno;
```

In MySQL i valori `NULL`, in ordinamento crescente, compaiono per primi.

## 2. Brani dal più recente al più vecchio

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno DESC, titolo ASC;
```

Prime righe attese: `Bad Guy`, `Blinding Lights`, `Shape of You`, `Alright`, `Hotline Bling`.

## 3. I 3 brani più lunghi

```sql
SELECT titolo, durata_minuti
FROM brani
ORDER BY durata_minuti DESC
LIMIT 3;
```

Risultato atteso:

| titolo | durata_minuti |
|---|---:|
| Rapper's Delight | 14.35 |
| My Favorite Things | 13.41 |
| Born Slippy | 9.44 |

## 4. I 5 brani più recenti

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno DESC
LIMIT 5;
```

## 5. Anni diversi

```sql
SELECT DISTINCT anno
FROM brani
ORDER BY anno DESC;
```

Risultato atteso: 46 righe, considerando anche `NULL`.

## 6. Numero totale di brani

```sql
SELECT COUNT(*) AS numero_brani
FROM brani;
```

Risultato atteso: 107.

## 7. Brani degli anni Novanta

```sql
SELECT COUNT(*) AS brani_anni90
FROM brani
WHERE anno BETWEEN 1990 AND 1999;
```

Risultato atteso: 26.

## 8. COUNT(*) e COUNT(anno)

```sql
SELECT COUNT(*) AS totale, COUNT(anno) AS con_anno
FROM brani;
```

Risultato atteso:

| totale | con_anno |
|---:|---:|
| 107 | 105 |

`COUNT(*)` conta tutte le righe. `COUNT(anno)` conta solo quelle con anno non `NULL`.

## 9. Anno più vecchio e più recente

```sql
SELECT MIN(anno) AS piu_vecchio, MAX(anno) AS piu_recente
FROM brani;
```

Risultato atteso: 1936 e 2019.

## 10. Anno medio arrotondato

```sql
SELECT ROUND(AVG(anno)) AS anno_medio
FROM brani;
```

Risultato atteso: 1986.

## 11. Brani più lunghi di 5 minuti

```sql
SELECT COUNT(*) AS quanti
FROM brani
WHERE durata_minuti > 5;
```

Risultato atteso: 39.

Il confronto con 5 funziona; somma e media diretta delle durate no, perché il campo usa formato `minuti.secondi`.

## 12. Brani per genere

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY quanti DESC;
```

Prime righe attese:

| genere | quanti |
|---|---:|
| Rock | 29 |
| Pop | 26 |
| Elettronica | 10 |
| Hip Hop | 10 |
| Jazz | 7 |

## 13. I 5 anni con più brani

```sql
SELECT anno, COUNT(*) AS quanti
FROM brani
WHERE anno IS NOT NULL
GROUP BY anno
ORDER BY quanti DESC
LIMIT 5;
```

Risultato atteso:

| anno | quanti |
|---:|---:|
| 1983 | 5 |
| 1991 | 5 |
| 1994 | 5 |
| 1971 | 5 |
| 1975 | 4 |

## 14. Anno più recente per genere

```sql
SELECT g.nome AS genere, MAX(b.anno) AS anno_piu_recente
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY anno_piu_recente DESC;
```

## 15. Generi con almeno 5 brani

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
HAVING COUNT(*) >= 5
ORDER BY quanti DESC;
```

Risultato atteso:

| genere | quanti |
|---|---:|
| Rock | 29 |
| Pop | 26 |
| Elettronica | 10 |
| Hip Hop | 10 |
| Jazz | 7 |
| Soul | 5 |

## 16. Autori con più di un brano

```sql
SELECT a.nome AS autore, COUNT(*) AS quanti
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
GROUP BY a.nome
HAVING COUNT(*) > 1
ORDER BY quanti DESC, autore;
```

Risultato atteso: 8 autori con 2 brani ciascuno.

## 17. Conteggio e anno medio per genere

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti, ROUND(AVG(b.anno)) AS anno_medio
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY anno_medio;
```

Prime righe attese:

| genere | quanti | anno_medio |
|---|---:|---:|
| Blues | 4 | 1961 |
| Jazz | 7 | 1961 |
| Soul | 5 | 1970 |
| Funk | 3 | 1977 |
| Rock | 29 | 1983 |
