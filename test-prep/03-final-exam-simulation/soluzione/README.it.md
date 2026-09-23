# Soluzione di riferimento — Parte A

> Aprire questo documento **solo dopo** aver tentato la simulazione.

## 1. Interpretazione progettuale

La traccia richiede una piccola applicazione per una lista di libri da leggere.

La soluzione adotta un modello intenzionalmente semplice:

```text
Libro
├── id
├── isbn
├── titolo
├── autore
└── created_at
```

**ISBN non è assunto come requisito stampato certo.** Nella fotografia compare chiaramente nello schizzo manoscritto come `Codice (ISBN)`, quindi viene adottato come scelta progettuale coerente con l'interfaccia disegnata. Se in sede d'esame la traccia stampata non lo richiedesse, si potrebbe ometterlo senza cambiare il cuore della soluzione.

Sono sufficienti tre casi d'uso:

```text
aggiungi libro
visualizza libri
elimina libro
```

Non viene implementata la modifica perché non è richiesta.

## 2. Database

Si usa MySQL/MariaDB con tabella `libri`.

Il vincolo più importante è:

```sql
UNIQUE KEY uq_libri_titolo (titolo)
```

La verifica applicativa del duplicato migliora il messaggio all'utente, ma **non sostituisce** il vincolo database.

### Perché il vincolo deve stare anche nel DB

Due richieste concorrenti potrebbero entrambe controllare che il titolo non esista e poi tentare l'inserimento. Il database è l'ultimo arbitro dell'invariante.

## 3. Architettura

```text
index.php
├── include/db.php
├── SELECT lista libri
└── HTML + form

salva.php
├── valida POST
├── controlla duplicato
├── INSERT preparato
└── redirect

elimina.php
├── accetta solo POST
├── valida id
├── DELETE preparato
└── redirect

assets/style.css
└── presentazione
```

È una struttura volutamente piccola: abbastanza separata da essere leggibile, ma senza introdurre livelli architetturali inutili in una prova da 50 punti.

## 4. Tecnologie utilizzate

### HTML

Per:

- struttura;
- tabella;
- form;
- label;
- pulsanti;
- messaggi.

### CSS

È richiesto esplicitamente dalla traccia. Viene usato un file separato per dimostrare personalizzazione reale e separazione fra contenuto e presentazione.

### PHP

È richiesto esplicitamente. Gestisce:

- richieste HTTP;
- validazione;
- accesso PDO;
- rendering;
- redirect.

### PDO

Perché:

- è già coerente con il percorso del corso;
- supporta prepared statement;
- mantiene il codice database leggibile;
- permette gestione delle eccezioni.

### MySQL/MariaDB

Perché la lista deve sopravvivere alle richieste e il corso ha già lavorato con database relazionali.

## 5. Tecnologie intenzionalmente NON utilizzate

### JavaScript

Non serve per soddisfare la traccia. Aggiungerlo aumenterebbe superficie di errore senza fornire una capacità richiesta.

### Bootstrap

Non necessario. La traccia chiede di personalizzare lo stile con CSS: CSS proprietario rende evidente il lavoro svolto e non introduce dipendenza da CDN.

### Framework PHP

Laravel/Symfony sarebbero sproporzionati per una prova così piccola. Nasconderebbero inoltre parte dei meccanismi che l'esame probabilmente vuole verificare direttamente.

### ORM

Non necessario per una singola tabella con tre operazioni. PDO rende trasparente il rapporto fra codice e SQL.

### Sessioni

Non servono: non c'è autenticazione, carrello o stato utente temporaneo.

### API REST

Non richiesta. L'applicazione server-rendered è sufficiente.

### AJAX/fetch

Non richiesto. Il pattern POST → redirect → GET è più semplice e robusto.

## 6. Sicurezza minima ragionevole

La soluzione usa:

- prepared statement;
- escaping HTML;
- validazione server-side;
- POST per le mutazioni;
- credenziali database da variabili d'ambiente;
- vincolo UNIQUE nel database.

Non implementa autenticazione, autorizzazione o CSRF token perché la traccia non li richiede e introdurli in una simulazione base rischierebbe di oscurare gli obiettivi didattici.

In un'applicazione reale multiutente sarebbero aspetti da aggiungere.

## 7. Flusso di inserimento

```text
utente compila form
→ POST salva.php
→ validazione
→ controllo titolo
→ INSERT
→ redirect index.php
→ lista aggiornata
```

## 8. Flusso di eliminazione

```text
utente preme Elimina
→ POST elimina.php
→ validazione id
→ DELETE
→ redirect
```

Il caricamento di un URL non deve eliminare dati.

## 9. Gestione del titolo duplicato

La soluzione fa due cose:

1. query preventiva per produrre un messaggio comprensibile;
2. vincolo `UNIQUE` nel DB per garantire l'invariante.

Questa doppia protezione è intenzionale.

## 10. Cosa spiegare oralmente

Bisogna saper motivare:

- perché esiste una primary key;
- perché il titolo è UNIQUE;
- perché POST per INSERT/DELETE;
- perché prepared statements;
- differenza fra validazione e vincolo DB;
- perché `htmlspecialchars()`;
- perché non servono JavaScript, framework o sessioni;
- come funziona il redirect dopo una mutazione.

## 11. Avvio locale

Creare database e tabella con:

```bash
mysql < database/schema.sql
```

Configurare le variabili d'ambiente:

```bash
export EXAM_DB_HOST=127.0.0.1
export EXAM_DB_NAME=exam_books
export EXAM_DB_USER=exam_user
export EXAM_DB_PASSWORD='...'
```

Poi:

```bash
php -S 127.0.0.1:18090 -t .
```

Aprire:

```text
http://127.0.0.1:18090/
```

## 12. Confine

Questa è una **soluzione di riferimento**, non l'unica soluzione possibile.

Il criterio corretto non è copiare la struttura esatta, ma soddisfare la traccia con una soluzione spiegabile, semplice e verificabile.
