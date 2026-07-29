# Soluzioni — Quiz SQL finale

## 1. Database e DBMS

Il database è l'insieme organizzato dei dati.

Il DBMS è il software che permette di creare, leggere, modificare, proteggere e interrogare quei dati.

Esempi di DBMS: MySQL, MariaDB.

## 2. Tabella, record e campo

| Termine | Significato |
|---|---|
| tabella | insieme di dati dello stesso tipo, organizzati in righe e colonne |
| record | una riga della tabella |
| campo | una colonna della tabella |

## 3. Chiave primaria

È il campo che identifica in modo univoco ogni record della tabella.

Non deve essere duplicato.

Non deve essere ambiguo.

## 4. Chiave esterna

È un campo che punta alla chiave primaria di un'altra tabella.

Serve a creare relazioni e mantenere integrità referenziale.

## 5. Relazione uno-a-molti

La chiave esterna sta in `ordini`.

Motivo: un cliente può avere molti ordini, ma ogni ordine appartiene a un solo cliente.

Quindi `ordini.cliente_id` punta a `clienti.cliente_id`.

## 6. Tutti i brani

```sql
SELECT *
FROM brani;
```

## 7. Solo alcune colonne

```sql
SELECT titolo, anno
FROM brani;
```

## 8. Filtro per anno

```sql
SELECT *
FROM brani
WHERE anno = 1991;
```

## 9. Brani dopo il 2000

```sql
SELECT titolo, anno
FROM brani
WHERE anno > 2000;
```

## 10. Brani più corti di 3 minuti

```sql
SELECT titolo, durata_minuti
FROM brani
WHERE durata_minuti < 3;
```

## 11. Diverso da 1991

```sql
SELECT titolo, anno
FROM brani
WHERE anno <> 1991;
```

Oppure:

```sql
SELECT titolo, anno
FROM brani
WHERE anno != 1991;
```

I brani con `anno NULL` non compaiono perché `NULL` significa valore sconosciuto.

Un valore sconosciuto non è né uguale né diverso da 1991.

Per includerli:

```sql
SELECT titolo, anno
FROM brani
WHERE anno <> 1991 OR anno IS NULL;
```

## 12. IN

```sql
SELECT titolo, anno
FROM brani
WHERE anno IN (1991, 1994, 1999);
```

## 13. LIKE iniziale

```sql
SELECT titolo
FROM brani
WHERE titolo LIKE 'S%';
```

## 14. LIKE interno

```sql
SELECT titolo
FROM brani
WHERE titolo LIKE '%love%';
```

## 15. NULL

```sql
SELECT titolo
FROM brani
WHERE anno IS NULL;
```

Non si usa `= NULL`.

## 16. Anni Settanta

```sql
SELECT titolo, anno
FROM brani
WHERE anno >= 1970 AND anno <= 1979;
```

Oppure:

```sql
SELECT titolo, anno
FROM brani
WHERE anno BETWEEN 1970 AND 1979;
```

## 17. AND e OR

```sql
SELECT titolo, anno
FROM brani
WHERE anno > 1990
  AND (titolo LIKE '%love%' OR titolo LIKE '%you%');
```

Le parentesi sono necessarie perché `AND` viene valutato prima di `OR`.

## 18. INSERT semplice

Prima ricavo l'autore:

```sql
SELECT autore_id
FROM autori
WHERE nome = 'Prince';
```

Poi inserisco:

```sql
INSERT INTO brani (titolo, autore_id, genere_id, durata_minuti, anno)
VALUES ('Purple Rain', 57, NULL, 8.41, NULL);
```

Versione alternativa:

```sql
INSERT INTO brani (titolo, autore_id, genere_id, durata_minuti, anno)
SELECT 'Purple Rain', autore_id, NULL, 8.41, NULL
FROM autori
WHERE nome = 'Prince';
```

## 19. UPDATE

```sql
UPDATE brani
SET anno = 1984, genere_id = 10
WHERE titolo = 'Purple Rain';
```

## 20. DELETE

```sql
DELETE FROM brani
WHERE titolo = 'Purple Rain';
```

## 21. Rischio UPDATE

Una `UPDATE` senza `WHERE` modifica tutte le righe della tabella.

## 22. Rischio DELETE

Una `DELETE` senza `WHERE` cancella tutte le righe della tabella.

## 23. Titolo e autore

```sql
SELECT b.titolo, a.nome AS autore
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id;
```

## 24. Titolo, autore, genere, anno

```sql
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
INNER JOIN generi g ON b.genere_id = g.genere_id;
```

## 25. INNER JOIN e righe mancanti

`INNER JOIN` restituisce solo righe con corrispondenza in entrambe le tabelle.

Se un brano ha `genere_id NULL`, non trova corrispondenza in `generi` e sparisce dal risultato.

## 26. LEFT JOIN

```sql
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
LEFT JOIN generi g ON b.genere_id = g.genere_id;
```

## 27. Ordinamento crescente

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno;
```

In MySQL, in ordinamento crescente, i valori `NULL` compaiono prima.

## 28. Ordinamento con doppio criterio

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno DESC, titolo ASC;
```

## 29. LIMIT

```sql
SELECT titolo, anno
FROM brani
ORDER BY anno DESC
LIMIT 5;
```

## 30. I 3 brani più lunghi

```sql
SELECT titolo, durata_minuti
FROM brani
ORDER BY durata_minuti DESC
LIMIT 3;
```

## 31. DISTINCT

```sql
SELECT DISTINCT anno
FROM brani
ORDER BY anno DESC;
```

## 32. COUNT totale

```sql
SELECT COUNT(*) AS numero_brani
FROM brani;
```

## 33. COUNT campo

```sql
SELECT COUNT(*) AS totale, COUNT(anno) AS con_anno
FROM brani;
```

## 34. COUNT(*) vs COUNT(anno)

`COUNT(*)` conta tutte le righe.

`COUNT(anno)` conta solo le righe in cui `anno` non è `NULL`.

## 35. MIN e MAX

```sql
SELECT MIN(anno) AS piu_vecchio, MAX(anno) AS piu_recente
FROM brani;
```

## 36. AVG e ROUND

```sql
SELECT ROUND(AVG(anno)) AS anno_medio
FROM brani;
```

## 37. BETWEEN

```sql
SELECT COUNT(*) AS brani_anni90
FROM brani
WHERE anno BETWEEN 1990 AND 1999;
```

`BETWEEN` include entrambi gli estremi.

## 38. Durata minuti

`durata_minuti` usa il formato `minuti.secondi`.

`4.30` significa 4 minuti e 30 secondi, non 4,30 minuti matematici.

Sommare questi valori è sbagliato perché i secondi arrivano a 60, non a 100.

Per calcoli corretti la durata dovrebbe essere salvata in secondi interi.

## 39. Brani per genere

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY quanti DESC;
```

## 40. Anni con più brani

```sql
SELECT anno, COUNT(*) AS quanti
FROM brani
WHERE anno IS NOT NULL
GROUP BY anno
ORDER BY quanti DESC
LIMIT 5;
```

## 41. Generi con almeno 5 brani

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
HAVING COUNT(*) >= 5
ORDER BY quanti DESC;
```

## 42. Autori con più di un brano

```sql
SELECT a.nome AS autore, COUNT(*) AS quanti
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
GROUP BY a.nome
HAVING COUNT(*) > 1
ORDER BY quanti DESC, autore;
```

## 43. WHERE vs HAVING

`WHERE` filtra righe prima del raggruppamento.

`HAVING` filtra gruppi dopo il raggruppamento.

Non posso scrivere `WHERE COUNT(*) >= 5`, perché il conteggio non esiste ancora quando `WHERE` viene valutato.

## 44. Aggregazione con JOIN

```sql
SELECT g.nome AS genere, COUNT(*) AS quanti, ROUND(AVG(b.anno)) AS anno_medio
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY anno_medio;
```

## 45. Tipi di dato

| Dato | Tipo |
|---|---|
| id cliente | `INT` |
| email | `VARCHAR(150)` |
| prezzo | `DECIMAL(6,2)` |
| data registrazione | `DATE` |
| data e ora ordine | `DATETIME` |
| quantità acquistata | `INT` |

## 46. Tabella clienti

```sql
CREATE TABLE clienti (
  cliente_id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  email VARCHAR(150) NOT NULL UNIQUE,
  citta VARCHAR(80),
  data_registrazione DATE NOT NULL
);
```

## 47. ALTER TABLE prezzo

```sql
ALTER TABLE brani
ADD COLUMN prezzo DECIMAL(6,2) NOT NULL DEFAULT 0.99;
```

## 48. Tabella ordini

```sql
CREATE TABLE ordini (
  ordine_id INT AUTO_INCREMENT PRIMARY KEY,
  cliente_id INT NOT NULL,
  data_ordine DATETIME NOT NULL,
  stato VARCHAR(20) NOT NULL DEFAULT 'in attesa',
  FOREIGN KEY (cliente_id) REFERENCES clienti(cliente_id)
);
```

## 49. Tabella righe_ordine

```sql
CREATE TABLE righe_ordine (
  riga_id INT AUTO_INCREMENT PRIMARY KEY,
  ordine_id INT NOT NULL,
  brano_id INT NOT NULL,
  quantita INT NOT NULL DEFAULT 1,
  prezzo_unitario DECIMAL(6,2) NOT NULL,
  FOREIGN KEY (ordine_id) REFERENCES ordini(ordine_id),
  FOREIGN KEY (brano_id) REFERENCES brani(id)
);
```

## 50. prezzo_unitario

Serve a conservare il prezzo del brano al momento dell'acquisto.

Se il prezzo in `brani` cambia dopo l'ordine, l'ordine storico deve restare corretto.

## 51. LAST_INSERT_ID

Serve a recuperare l'id generato dall'ultima `INSERT` con `AUTO_INCREMENT`.

Nel flusso ordine permette di creare l'ordine e poi collegare le righe allo stesso `ordine_id`.

## 52. Flusso ordine

Ordine corretto:

1. leggere carrello;
2. creare ordine;
3. recuperare id ordine;
4. inserire righe ordine.

## 53. Collegamento con PHP/PDO

Il metodo PDO corrispondente è:

```text
lastInsertId()
```

## 54. Query sbagliata con NULL

Query sbagliata:

```sql
SELECT titolo FROM brani WHERE anno = NULL;
```

Correzione:

```sql
SELECT titolo FROM brani WHERE anno IS NULL;
```

`NULL` non si confronta con `=`.

## 55. Query sbagliata con gruppi

Errore: `WHERE COUNT(*) >= 5`.

`WHERE` filtra righe, non gruppi.

Correzione:

```sql
SELECT g.nome, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
HAVING COUNT(*) >= 5;
```

## 56. Query pericolosa

```sql
DELETE FROM brani;
```

Cancella tutte le righe della tabella `brani`.

## 57. JOIN da scegliere

Serve `LEFT JOIN`.

Voglio tenere tutti i brani anche se non hanno corrispondenza in `generi`.

## 58. Chiave esterna

Il database rifiuta l'inserimento se `cliente_id` non esiste in `clienti`.

## 59. AUTO_INCREMENT

Non bisogna inventare l'id ordine perché lo assegna il database.

Inventarlo a mano può causare duplicati o collegamenti sbagliati.

## 60. Domanda finale

Risposta possibile:

Il modulo parte dai concetti base: database, DBMS, tabelle, record, campi e chiavi. Poi passa alle query di lettura con `SELECT`, filtri con `WHERE`, ricerche testuali, `NULL` e operatori logici. Successivamente introduce modifiche con `INSERT`, `UPDATE`, `DELETE` e collegamenti tra tabelle con `JOIN`. Dopo arrivano ordinamento, aggregazioni, `GROUP BY` e `HAVING`. L'ultima parte mostra come progettare tabelle per un mini e-commerce, collegando SQL al futuro backend PHP.
