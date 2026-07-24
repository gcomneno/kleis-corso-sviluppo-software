# Basi di dati

Questa sezione raccoglie gli appunti e gli esercizi del modulo Kleis dedicato alle basi di dati.

Il focus iniziale è sui database relazionali, con particolare riferimento a MySQL e MariaDB.

## Lezioni

### Lezione 1 — Concetti generali

- [Lesson Learned](./LESSON_LEARNED_BASI_DI_DATI_01.md)
- [Quiz](./QUIZ_BASI_DI_DATI_01.md)
- [Soluzioni quiz](./QUIZ_BASI_DI_DATI_01_SOLUTIONS.md)

### Lezione 2 — Relazioni e CRUD SQL

- [Lesson Learned](./LESSON_LEARNED_BASI_DI_DATI_02.md)
- [Quiz](./QUIZ_BASI_DI_DATI_02.md)
- [Soluzioni quiz](./QUIZ_BASI_DI_DATI_02_SOLUTIONS.md)
- [Esercitazione SQL — Database MUSICA](./examples/musica.sql)

### Lezione 3 — Esercitazione SQL shop

- [Lesson Learned](./LESSON_LEARNED_BASI_DI_DATI_03.md)
- [Laboratorio SQL](./LAB_SQL_SHOP_03.md)
- [Soluzioni commentate](./SOLUZIONI_SQL_SHOP_03.md)
- [Query SQL pronte](./examples/shop_queries.sql)

### Lezione 4 — Ordinamento, aggregazioni e GROUP BY

- [Lesson Learned](./LESSON_LEARNED_BASI_DI_DATI_04.md)
- [Laboratorio SQL](./LAB_SQL_AGGREGAZIONE_04.md)
- [Soluzioni commentate](./SOLUZIONI_SQL_AGGREGAZIONE_04.md)
- [Query SQL pronte](./examples/shop_aggregation_queries.sql)

## Obiettivo del modulo

Capire come sono organizzati i dati in un database relazionale e imparare il lessico fondamentale:

- database
- DBMS
- tabella
- record
- campo
- query
- tipo di dato
- indice
- chiave primaria
- chiave esterna
- contatore

## Nota pratica

Un database non è semplicemente una tabella più elegante.

La differenza importante è che un DBMS permette di gestire grandi quantità di dati, integrità, ricerche, relazioni tra tabelle e accessi concorrenti.

## Progressione del modulo

La prima lezione introduce il lessico fondamentale dei database.

La seconda lezione passa alla pratica: progettazione di più tabelle, relazioni, chiavi primarie, chiavi esterne e prime operazioni SQL CRUD.

La terza lezione consolida SELECT, WHERE, NULL, operatori logici e JOIN attraverso un'esercitazione completa sul database `shop`.

La quarta lezione introduce ordinamento, limitazione dei risultati, valori distinti, funzioni di aggregazione, `GROUP BY` e `HAVING`.
