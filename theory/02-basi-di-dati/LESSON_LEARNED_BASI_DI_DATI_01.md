# Lesson Learned — Basi di dati 01

## Argomento

Concetti generali sui database, con particolare riferimento ai database relazionali e a MySQL/MariaDB.

## Obiettivo della lezione

Capire che cos'è una base di dati, perché non va confusa con un semplice foglio elettronico e quali sono gli elementi fondamentali di un database relazionale.

## Database

Una base di dati raccoglie grandi quantità di dati e rende più semplice accedervi, consultarli e gestirli.

Molti programmi aziendali hanno un database al centro del proprio funzionamento.

Esempi pratici:

- gestione clienti
- gestione ordini
- gestione prodotti
- gestione studenti
- gestione appuntamenti
- gestione magazzino

Il database è il posto dove l'applicazione conserva le informazioni importanti.

## DBMS

Per gestire un database serve un DBMS, cioè un Database Management System.

Un DBMS è il programma che permette di creare, modificare, interrogare e amministrare una base di dati.

Esempi:

- MySQL
- MariaDB
- SQL Server
- Microsoft Access
- PostgreSQL
- Oracle Database

Nel corso il riferimento principale è MySQL/MariaDB.

## Perché non usare Excel come database

Un foglio elettronico può sembrare simile a un database, ma non è progettato per gestire bene archivi complessi.

Problemi tipici dei fogli elettronici usati come database:

- difficoltà con grandi quantità di dati
- difficoltà nelle interrogazioni
- problemi di ordinamento
- problemi di normalizzazione
- rischio di dati incoerenti
- difficoltà con accessi concorrenti
- scarsa integrità dei dati

Excel è utile per tabelle, calcoli e analisi leggere.

Un database serve quando i dati devono essere strutturati, interrogabili, coerenti e condivisi.

## Tipi di database

Esistono diversi tipi di database.

I principali citati nella lezione sono:

- database relazionali
- database gerarchici
- database a oggetti

Il corso si concentra sui database relazionali.

MySQL e MariaDB sono database relazionali.

## Oggetti di un database

Gli oggetti principali citati sono:

- tabelle
- viste o query
- maschere
- report

Tabelle e viste sono presenti nei database in generale.

Maschere e report sono più tipici di alcuni ambienti, come Microsoft Access.

## Tabelle

Le tabelle sono il luogo in cui il database memorizza i dati.

Una tabella contiene dati omogenei, cioè dati che hanno la stessa struttura.

Esempio:

Una tabella `clienti` dovrebbe contenere record relativi ai clienti.

Una tabella `prodotti` dovrebbe contenere record relativi ai prodotti.

Una tabella `ordini` dovrebbe contenere record relativi agli ordini.

Non bisogna mescolare entità diverse nella stessa tabella senza criterio.

## Record

Una riga di una tabella si chiama record.

Un record raccoglie tutte le informazioni relative a una singola entità.

Esempio tabella clienti:

| id_cliente | nome | cognome | email |
|---:|---|---|---|
| 1 | Mario | Rossi | mario.rossi@example.test |
| 2 | Anna | Bianchi | anna.bianchi@example.test |

Ogni riga è un record.

Ogni record rappresenta un cliente.

## Campi

Una colonna di una tabella si chiama campo.

Un campo rappresenta una specifica informazione presente in tutti i record della tabella.

Nel caso della tabella clienti:

- `id_cliente` è un campo
- `nome` è un campo
- `cognome` è un campo
- `email` è un campo

Ogni campo ha un nome e un tipo di dato.

## Tipi di dato

I campi possono contenere tipi di dato diversi.

Tipi principali:

- stringhe
- numeri
- date e orari
- booleani
- testi lunghi
- immagini o altri contenuti binari

Scegliere il tipo corretto è importante perché il database deve sapere che tipo di informazione deve conservare.

## Sottotipi di dato

Alcuni dati richiedono specifiche più precise.

Esempi:

- una stringa può avere lunghezza massima diversa
- un numero può essere intero o decimale
- una data può includere solo il giorno oppure anche l'orario
- un decimale può avere un certo numero di cifre prima e dopo la virgola

Il sottotipo rende più precisa la struttura del campo.

## Creare una tabella

Creare una tabella significa definirne la struttura.

In pratica bisogna decidere:

- nome della tabella
- nomi dei campi
- tipi dei campi
- eventuali vincoli
- eventuali chiavi
- eventuali indici

Prima si progetta la struttura.

Poi si inseriscono i dati.

Se si parte buttando dati a caso dentro una tabella, il database diventa una cantina con le luci spente.

## Query

Una query è una domanda fatta al database.

Con una query si possono cercare, ordinare, calcolare, modificare o cancellare dati.

Le query vengono espresse tramite linguaggi di interrogazione.

Il linguaggio più comune nei database relazionali è SQL.

Esempi di domande che una query può rappresentare:

- quali clienti abitano in una certa città?
- quali ordini sono stati fatti questo mese?
- qual è il totale delle vendite?
- quali prodotti hanno quantità sotto scorta?

La risposta di una query può essere vista come una nuova tabella, anche vuota o con una sola riga.

## Indici

Un indice serve ad accelerare le ricerche su un campo.

Senza indice, il database potrebbe dover controllare molti record uno per uno.

Con un indice, la ricerca può diventare molto più veloce.

Controindicazioni:

- l'indice occupa spazio
- l'indice deve essere aggiornato quando cambiano i dati
- troppi indici possono rallentare scritture e aggiornamenti

Gli indici sono utili, ma non vanno messi ovunque come il prezzemolo.

## Chiavi

Una chiave è un campo, o una combinazione di campi, che identifica un record.

Esempi di possibili chiavi:

- matricola studente
- targa auto
- codice fiscale
- id cliente

## Chiave primaria

La chiave primaria identifica in modo univoco un record dentro la propria tabella.

Regola fondamentale:

Due record diversi non possono avere la stessa chiave primaria.

Esempio:

Nella tabella `clienti`, il campo `id_cliente` può essere la chiave primaria.

## Chiave esterna

Una chiave esterna identifica un record contenuto in un'altra tabella.

Serve a collegare tabelle diverse.

Esempio:

Una tabella `ordini` può avere un campo `id_cliente`.

Quel campo collega ogni ordine al cliente corrispondente nella tabella `clienti`.

Quindi:

- `clienti.id_cliente` è chiave primaria
- `ordini.id_cliente` è chiave esterna

## Contatori

Un contatore è un campo numerico assegnato automaticamente dal DBMS in modo progressivo.

Serve spesso per creare chiavi primarie artificiali.

Esempio:

- primo cliente: id 1
- secondo cliente: id 2
- terzo cliente: id 3

Il vantaggio è che il DBMS garantisce l'unicità del valore.

## Mappa mentale della lezione

Database:

- contiene dati organizzati

DBMS:

- gestisce il database

Tabella:

- contiene record omogenei

Record:

- riga della tabella

Campo:

- colonna della tabella

Tipo di dato:

- definisce che cosa può contenere un campo

Query:

- domanda fatta al database

Indice:

- accelera le ricerche

Chiave primaria:

- identifica un record nella stessa tabella

Chiave esterna:

- collega un record a un record di un'altra tabella

Contatore:

- genera automaticamente valori unici progressivi

## Errori da evitare

1. Confondere Excel con un database.
2. Mescolare dati diversi nella stessa tabella.
3. Creare campi senza pensare al tipo di dato.
4. Non distinguere record e campi.
5. Non capire la differenza tra chiave primaria e chiave esterna.
6. Indicizzare tutto senza criterio.
7. Pensare che una query sia solo una ricerca: può anche ordinare, calcolare, modificare o cancellare.

## Sintesi finale

Un database relazionale organizza i dati in tabelle.

Ogni tabella contiene record.

Ogni record è composto da campi.

I campi hanno tipi di dato.

Le query servono a interrogare i dati.

Le chiavi servono a identificare record e collegare tabelle.

Il DBMS è il programma che rende tutto questo gestibile in modo ordinato, sicuro e coerente.
