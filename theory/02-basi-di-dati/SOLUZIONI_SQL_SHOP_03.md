# Soluzioni commentate — SQL Shop 03

## 1. Tutti i brani

```sql
SELECT *
FROM brani;
```

Risultato atteso: 107 righe.

---

## 2. Solo titolo e anno

```sql
SELECT titolo, anno
FROM brani;
```

Risultato atteso: 107 righe.

---

## 3. Elenco dei generi

```sql
SELECT *
FROM generi;
```

Risultato atteso: 13 righe.

---

## 4. Brani del 1991

```sql
SELECT *
FROM brani
WHERE anno = 1991;
```

Risultato atteso: 5 righe.

---

## 5. Brani dopo il 2000

```sql
SELECT titolo, anno
FROM brani
WHERE anno > 2000;
```

Risultato atteso: 19 righe.

---

## 6. Brani più corti di 3 minuti

```sql
SELECT titolo, durata_minuti
FROM brani
WHERE durata_minuti < 3;
```

Risultato atteso: 10 righe.

---

## 7. Brani non del 1991

```sql
SELECT titolo, anno
FROM brani
WHERE anno <> 1991;
```

Equivalente:

```sql
SELECT titolo, anno
FROM brani
WHERE anno != 1991;
```

Risultato atteso: 100 righe.

Nota importante: 5 + 100 non fa 107 perché i record con `anno NULL` non sono né uguali né diversi da 1991.

Per includerli:

```sql
SELECT titolo, anno
FROM brani
WHERE anno <> 1991 OR anno IS NULL;
```

---

## 8. Brani del 1991, 1994 o 1999

```sql
SELECT titolo, anno
FROM brani
WHERE anno IN (1991, 1994, 1999);
```

Risultato atteso: 13 righe.

---

## 9. Titoli che iniziano per S

```sql
SELECT titolo
FROM brani
WHERE titolo LIKE 'S%';
```

Risultato atteso: 16 righe.

---

## 10. Titoli che contengono love

```sql
SELECT titolo
FROM brani
WHERE titolo LIKE '%love%';
```

Risultato atteso: 2 righe.

Il `%` va su entrambi i lati perché `love` può trovarsi in qualunque posizione.

---

## 11. Brani senza anno

```sql
SELECT titolo
FROM brani
WHERE anno IS NULL;
```

Risultato atteso: 2 righe.

Si usa `IS NULL`, non `= NULL`.

---

## 12. Brani degli anni Settanta

```sql
SELECT titolo, anno
FROM brani
WHERE anno >= 1970 AND anno <= 1979;
```

Risultato atteso: 21 righe.

---

## 13. Brani prima del 1960 o dopo il 2015

```sql
SELECT titolo, anno
FROM brani
WHERE anno < 1960 OR anno > 2015;
```

Risultato atteso: 10 righe.

---

## 14. Brani dopo il 1990 con love o you nel titolo

```sql
SELECT titolo, anno
FROM brani
WHERE anno > 1990
  AND (titolo LIKE '%love%' OR titolo LIKE '%you%');
```

Risultato atteso: 5 righe.

Le parentesi sono indispensabili: senza parentesi `AND` viene valutato prima di `OR`.

---

## 15. Inserimento di Purple Rain

Prima ricavo l'autore:

```sql
SELECT autore_id
FROM autori
WHERE nome = 'Prince';
```

Risultato atteso: `57`.

Poi inserisco il brano:

```sql
INSERT INTO brani (titolo, autore_id, genere_id, durata_minuti, anno)
VALUES ('Purple Rain', 57, NULL, 8.41, NULL);
```

Alternativa con `INSERT ... SELECT`:

```sql
INSERT INTO brani (titolo, autore_id, genere_id, durata_minuti, anno)
SELECT 'Purple Rain', autore_id, NULL, 8.41, NULL
FROM autori
WHERE nome = 'Prince';
```

---

## 16. Completamento di anno e genere

Prima ricavo il genere:

```sql
SELECT genere_id
FROM generi
WHERE nome = 'Funk';
```

Risultato atteso: `10`.

Poi aggiorno:

```sql
UPDATE brani
SET anno = 1984, genere_id = 10
WHERE titolo = 'Purple Rain';
```

---

## 17. Cancellazione di Purple Rain

```sql
DELETE FROM brani
WHERE titolo = 'Purple Rain';
```

La tabella torna allo stato iniziale.

---

## 18. Titolo e autore

```sql
SELECT b.titolo, a.nome
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id;
```

Risultato atteso: 107 righe.

Gli alias `b` e `a` abbreviano i nomi delle tabelle.

---

## 19. Titolo, autore, genere e anno

```sql
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
INNER JOIN generi g ON b.genere_id = g.genere_id;
```

Risultato atteso: 104 righe.

Motivo: `INNER JOIN` restituisce solo record con corrispondenza. I brani senza `genere_id` vengono esclusi.

---

## 20. LEFT JOIN dopo il 1990

```sql
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
LEFT JOIN generi g ON b.genere_id = g.genere_id
WHERE b.anno > 1990;
```

Risultato atteso: 46 righe.

`LEFT JOIN` conserva i brani anche quando il genere manca.
