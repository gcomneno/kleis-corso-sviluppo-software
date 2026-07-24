# Lesson Learned — Basi di dati 04

## Argomento

Ordinamento, limitazione dei risultati, valori distinti, funzioni di aggregazione e raggruppamento sul database `shop`.

## Obiettivo

La lezione porta SQL dal livello "estraggo righe" al livello "produco informazioni sintetiche".

Con questa lezione impariamo a rispondere a domande come:

- quali sono i brani più recenti?
- quali sono i brani più lunghi?
- quanti brani ci sono?
- quanti brani hanno l'anno compilato?
- qual è l'anno più vecchio e quello più recente?
- quanti brani ci sono per ogni genere?
- quali generi hanno almeno 5 brani?
- quali autori compaiono con più di un brano?

## ORDER BY

`ORDER BY` ordina i risultati.

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno;
```

`ASC` ordina in modo crescente ed è il comportamento predefinito.

`DESC` ordina in modo decrescente.

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno DESC, titolo ASC;
```

Con più criteri, SQL usa il secondo quando il primo produce valori uguali.

In MySQL, con ordinamento crescente, i valori `NULL` compaiono prima degli altri. `NULL` non è zero: significa dato assente.

## LIMIT

`LIMIT` prende solo le prime righe del risultato.

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno DESC
LIMIT 5;
```

`ORDER BY` crea la classifica, `LIMIT` la taglia.

## DISTINCT

`DISTINCT` elimina i duplicati.

```sql
SELECT DISTINCT anno
FROM brani
ORDER BY anno DESC;
```

Serve quando vogliamo l'elenco dei valori diversi, non una riga per ogni brano.

## Funzioni di aggregazione

Le funzioni di aggregazione riducono molte righe a un valore.

| Funzione | Cosa calcola |
|---|---|
| `COUNT(...)` | conteggio |
| `MIN(...)` | valore minimo |
| `MAX(...)` | valore massimo |
| `SUM(...)` | somma |
| `AVG(...)` | media |

## COUNT e valori NULL

`COUNT(*)` conta tutte le righe.

```sql
SELECT COUNT(*) AS numero_brani
FROM brani;
```

`COUNT(campo)` conta solo le righe in cui quel campo non è `NULL`.

```sql
SELECT COUNT(*) AS totale, COUNT(anno) AS con_anno
FROM brani;
```

Sul database `shop` il risultato atteso è:

| totale | con_anno |
|---:|---:|
| 107 | 105 |

La differenza nasce dai due brani senza anno.

Regola importante: le funzioni di aggregazione ignorano i valori `NULL`.

## BETWEEN

`BETWEEN` controlla un intervallo con estremi inclusi.

```sql
SELECT COUNT(*) AS brani_anni90
FROM brani
WHERE anno BETWEEN 1990 AND 1999;
```

Equivale a:

```sql
WHERE anno >= 1990 AND anno <= 1999
```

## MIN, MAX, AVG e ROUND

```sql
SELECT MIN(anno) AS piu_vecchio, MAX(anno) AS piu_recente
FROM brani;
```

Risultato atteso:

| piu_vecchio | piu_recente |
|---:|---:|
| 1936 | 2019 |

Per la media:

```sql
SELECT ROUND(AVG(anno)) AS anno_medio
FROM brani;
```

`AVG(anno)` calcola la media ignorando i `NULL`.

`ROUND(...)` arrotonda il risultato.

## Attenzione a durata_minuti

Nel database `shop`, `durata_minuti` è scritto come `minuti.secondi`.

Esempio:

```text
4.30 = 4 minuti e 30 secondi
```

Non significa 4,30 minuti matematici.

Quindi questa query è concettualmente sbagliata:

```sql
SELECT SUM(durata_minuti)
FROM brani;
```

I secondi arrivano a 60, non a 100.

Per sommare correttamente, la durata andrebbe salvata in secondi come intero:

```text
4 minuti e 30 secondi = 270 secondi
```

Prima di calcolare, bisogna capire cosa rappresenta davvero il dato.

## GROUP BY

`GROUP BY` divide le righe in gruppi e applica una funzione a ogni gruppo.

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY quanti DESC;
```

Questa query conta i brani per genere.

## WHERE prima di GROUP BY

`WHERE` filtra le righe prima del raggruppamento.

```sql
SELECT anno, COUNT(*) AS quanti
FROM brani
WHERE anno IS NOT NULL
GROUP BY anno
ORDER BY quanti DESC
LIMIT 5;
```

Ordine logico:

1. elimina i brani senza anno;
2. raggruppa per anno;
3. conta;
4. ordina;
5. limita ai primi 5.

## HAVING

`HAVING` filtra i gruppi dopo il raggruppamento.

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
HAVING COUNT(*) >= 5
ORDER BY quanti DESC;
```

Differenza fondamentale:

| Clausola | Cosa filtra |
|---|---|
| `WHERE` | righe prima del raggruppamento |
| `HAVING` | gruppi dopo il raggruppamento |

Non si scrive `WHERE COUNT(*) >= 5`, perché il conteggio ancora non esiste quando `WHERE` viene valutato.

## Aggregazioni con JOIN

Le aggregazioni diventano molto utili quando colleghiamo più tabelle.

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti, ROUND(AVG(b.anno)) AS anno_medio
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY anno_medio;
```

Questa query racconta qualcosa sul catalogo: per ogni genere mostra quanti brani contiene e qual è il suo anno medio.

## Ordine pratico delle clausole

Quando una query contiene tutto, l'ordine abituale è:

```sql
SELECT ...
FROM ...
JOIN ...
WHERE ...
GROUP BY ...
HAVING ...
ORDER BY ...
LIMIT ...
```

Significato:

1. parto dalle tabelle;
2. collego le tabelle;
3. filtro le righe;
4. creo i gruppi;
5. filtro i gruppi;
6. ordino;
7. limito.

## Errori da evitare

1. Usare `WHERE` al posto di `HAVING`.
2. Confondere `COUNT(*)` con `COUNT(campo)`.
3. Dimenticare che le aggregazioni ignorano i `NULL`.
4. Sommare o mediare `durata_minuti` come numero decimale normale.
5. Usare `LIMIT` senza `ORDER BY` per fare classifiche.
6. Dimenticare che `INNER JOIN` esclude righe senza corrispondenza.
7. Mettere nella `SELECT` campi non aggregati che non sono nel `GROUP BY`.

## Sintesi finale

Prima sapevamo leggere, filtrare e collegare righe.

Ora sappiamo anche produrre sintesi:

```text
SELECT / WHERE = interrogare righe
GROUP BY / HAVING = produrre informazioni aggregate
```

È il passaggio da elenco a informazione.
