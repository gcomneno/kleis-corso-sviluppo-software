# Lesson Learned — Basi di dati 03

## Argomento

Esercitazione SQL sul database `shop`.

La lezione consolida l'uso pratico di SQL su tre tabelle relazionate:

- `brani`
- `autori`
- `generi`

## Obiettivo della lezione

Allenarsi a scrivere query SQL reali, partendo da estrazioni semplici fino ad arrivare a condizioni composte, valori `NULL`, modifiche ai dati e `JOIN` tra più tabelle.

La progressione della lezione è questa:

1. leggere dati con `SELECT`;
2. filtrare con `WHERE`;
3. usare operatori di confronto;
4. cercare testo con `LIKE`;
5. usare liste di valori con `IN`;
6. gestire valori mancanti con `NULL`;
7. combinare condizioni con `AND`, `OR`, `NOT`;
8. inserire dati con `INSERT`;
9. modificare dati con `UPDATE`;
10. cancellare dati con `DELETE`;
11. collegare tabelle con `INNER JOIN` e `LEFT JOIN`.

## Struttura del database

Il database dell'esercitazione si chiama `shop`.

Le tabelle principali sono:

| Tabella | Scopo |
|---|---|
| `brani` | contiene i brani musicali |
| `autori` | contiene gli autori/artisti |
| `generi` | contiene i generi musicali |

La tabella `brani` contiene riferimenti alle altre due tabelle:

| Campo | Significato |
|---|---|
| `autore_id` | collega il brano alla tabella `autori` |
| `genere_id` | collega il brano alla tabella `generi` |

Quindi:

- `autori.autore_id` è chiave primaria;
- `generi.genere_id` è chiave primaria;
- `brani.autore_id` è chiave esterna verso `autori`;
- `brani.genere_id` è chiave esterna verso `generi`.

## SELECT

`SELECT` serve a leggere dati.

```sql
SELECT *
FROM brani;
```

L'asterisco indica tutti i campi.

Quando servono solo alcune colonne, è meglio indicarle esplicitamente:

```sql
SELECT titolo, anno
FROM brani;
```

Questo rende il risultato più leggibile e riduce dati inutili.

## WHERE

`WHERE` serve a filtrare i record.

```sql
SELECT *
FROM brani
WHERE anno = 1991;
```

La query restituisce solo i brani pubblicati nel 1991.

Operatori utili:

| Operatore | Significato |
|---|---|
| `=` | uguale |
| `<>` oppure `!=` | diverso |
| `>` | maggiore |
| `<` | minore |
| `>=` | maggiore o uguale |
| `<=` | minore o uguale |

## IN

`IN` serve quando voglio confrontare un campo con più valori possibili.

Invece di scrivere:

```sql
WHERE anno = 1991 OR anno = 1994 OR anno = 1999
```

posso scrivere:

```sql
WHERE anno IN (1991, 1994, 1999)
```

È più compatto e leggibile.

## LIKE

`LIKE` serve per ricerche testuali parziali.

Il carattere `%` è un jolly: significa "qualunque sequenza di caratteri".

Esempi:

```sql
SELECT titolo
FROM brani
WHERE titolo LIKE 'S%';
```

Trova i titoli che iniziano con `S`.

```sql
SELECT titolo
FROM brani
WHERE titolo LIKE '%love%';
```

Trova i titoli che contengono `love` in qualunque posizione.

## NULL

`NULL` significa valore mancante o sconosciuto.

Non si confronta con `=`.

Sbagliato:

```sql
WHERE anno = NULL
```

Corretto:

```sql
WHERE anno IS NULL
```

Per trovare i record in cui l'anno è presente:

```sql
WHERE anno IS NOT NULL
```

## Il tranello del diverso con NULL

Questa query:

```sql
SELECT titolo, anno
FROM brani
WHERE anno <> 1991;
```

non restituisce i brani con `anno NULL`.

Per SQL, `NULL` non è né uguale né diverso da 1991.

È sconosciuto.

Se voglio includere anche i brani senza anno:

```sql
SELECT titolo, anno
FROM brani
WHERE anno <> 1991 OR anno IS NULL;
```

Questo è uno dei punti più importanti della lezione.

## AND, OR e parentesi

Le condizioni si possono combinare.

```sql
SELECT titolo, anno
FROM brani
WHERE anno >= 1970 AND anno <= 1979;
```

Questa query trova i brani degli anni Settanta.

Quando si combinano `AND` e `OR`, le parentesi sono fondamentali.

Esempio corretto:

```sql
SELECT titolo, anno
FROM brani
WHERE anno > 1990
  AND (titolo LIKE '%love%' OR titolo LIKE '%you%');
```

Senza parentesi, SQL valuta prima `AND` e poi `OR`.

Risultato: query apparentemente giusta, ma logicamente sbagliata.

La parentesi in SQL non è decorazione: è cintura di sicurezza.

## INSERT

`INSERT` aggiunge nuovi record.

Prima di inserire un brano collegato a un autore, bisogna conoscere l'id dell'autore.

```sql
SELECT autore_id
FROM autori
WHERE nome = 'Prince';
```

Poi si può inserire il brano:

```sql
INSERT INTO brani (titolo, autore_id, genere_id, durata_minuti, anno)
VALUES ('Purple Rain', 57, NULL, 8.41, NULL);
```

Nota didattica: `autore_id` e `genere_id` sono numeri, non nomi.

## UPDATE

`UPDATE` modifica record esistenti.

```sql
UPDATE brani
SET anno = 1984, genere_id = 10
WHERE titolo = 'Purple Rain';
```

La clausola `WHERE` è obbligatoria dal punto di vista pratico.

Senza `WHERE`, si modificano tutti i record della tabella.

## DELETE

`DELETE` cancella record.

```sql
DELETE FROM brani
WHERE titolo = 'Purple Rain';
```

Anche qui `WHERE` è fondamentale.

Una `DELETE` senza `WHERE` svuota la tabella.

Questa è una di quelle cose che trasformano una mattina tranquilla in un incidente aziendale con caffè freddo e sudore caldo.

## INNER JOIN

`INNER JOIN` restituisce solo i record che hanno corrispondenze in entrambe le tabelle collegate.

Esempio:

```sql
SELECT b.titolo, a.nome
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id;
```

Qui:

- `b` è alias di `brani`;
- `a` è alias di `autori`.

Gli alias rendono la query più breve e leggibile.

## JOIN su tre tabelle

Per visualizzare titolo, autore, genere e anno:

```sql
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
INNER JOIN generi g ON b.genere_id = g.genere_id;
```

Questa query esclude i brani senza genere, perché `INNER JOIN` richiede una corrispondenza presente.

## LEFT JOIN

`LEFT JOIN` mantiene tutti i record della tabella di sinistra, anche quando manca una corrispondenza nella tabella di destra.

```sql
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
LEFT JOIN generi g ON b.genere_id = g.genere_id
WHERE b.anno > 1990;
```

Qui i brani senza genere non spariscono.

La colonna `genere` risulterà vuota.

## Differenza tra INNER JOIN e LEFT JOIN

| JOIN | Cosa restituisce |
|---|---|
| `INNER JOIN` | solo record con corrispondenza in entrambe le tabelle |
| `LEFT JOIN` | tutti i record della tabella sinistra, anche senza corrispondenza a destra |

Nel database `shop`, alcuni brani possono non avere `genere_id`.

Con `INNER JOIN generi`, quei brani spariscono.

Con `LEFT JOIN generi`, restano visibili.

## Mappa mentale della lezione

`SELECT`:

- legge dati

`WHERE`:

- filtra i record

`LIKE`:

- cerca testo parziale

`%`:

- rappresenta qualunque sequenza di caratteri

`IN`:

- confronta un campo con una lista di valori

`NULL`:

- valore mancante o sconosciuto

`IS NULL`:

- cerca valori nulli

`AND`, `OR`, `NOT`:

- combinano condizioni logiche

`INSERT`:

- aggiunge record

`UPDATE`:

- modifica record

`DELETE`:

- cancella record

`INNER JOIN`:

- mostra solo corrispondenze presenti

`LEFT JOIN`:

- conserva tutte le righe della tabella sinistra

## Errori da evitare

1. Usare `= NULL` invece di `IS NULL`.
2. Dimenticare che `NULL` non è né uguale né diverso.
3. Scrivere `UPDATE` senza `WHERE`.
4. Scrivere `DELETE` senza `WHERE`.
5. Dimenticare le parentesi quando si mescolano `AND` e `OR`.
6. Usare `INNER JOIN` quando si vogliono conservare anche righe senza corrispondenza.
7. Confondere gli id numerici con i nomi testuali.
8. Usare `SELECT *` anche quando servono solo alcuni campi.

## Sintesi finale

Questa lezione trasforma i concetti delle lezioni precedenti in pratica SQL.

Il database `shop` permette di allenarsi su query realistiche: filtri, ricerche testuali, valori nulli, modifiche controllate e collegamenti tra tabelle.

La regola operativa più importante resta questa:

Prima capisci quali righe vuoi colpire, poi scrivi `UPDATE` o `DELETE`.

Il database perdona poco. `WHERE` è il tuo casco.
