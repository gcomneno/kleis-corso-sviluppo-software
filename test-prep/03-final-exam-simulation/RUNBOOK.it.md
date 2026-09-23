# Runbook — esecuzione e verifica

## Obiettivo

Portare la soluzione dalla sola lettura del codice a una verifica reale.

## Parte A

### 1. Creare il database

```bash
mysql < soluzione/database/schema.sql
mysql exam_books < soluzione/database/seed.sql
```

Creare un utente applicativo con i soli privilegi necessari:

```sql
CREATE USER 'exam_user'@'localhost' IDENTIFIED BY 'password-locale';
GRANT SELECT, INSERT, DELETE ON exam_books.* TO 'exam_user'@'localhost';
FLUSH PRIVILEGES;
```

Perché non `UPDATE`? La traccia non richiede modifica dei libri.

### 2. Configurare il runtime

```bash
cd test-prep/03-final-exam-simulation/soluzione

export EXAM_DB_HOST=127.0.0.1
export EXAM_DB_NAME=exam_books
export EXAM_DB_USER=exam_user
export EXAM_DB_PASSWORD='password-locale'
```

### 3. Verificare la sintassi

```bash
find . -name '*.php' -print0 | xargs -0 -n1 php -l
```

### 4. Avviare il server

```bash
php -S 127.0.0.1:18090 -t .
```

### 5. Test manuale

Provare in quest'ordine:

1. apertura pagina;
2. inserimento libro nuovo;
3. verifica presenza nella lista;
4. tentativo di stesso titolo;
5. verifica rifiuto;
6. eliminazione;
7. verifica sparizione dalla lista;
8. ricarica pagina;
9. verifica persistenza.

## Parte B

Caricare la fixture:

```bash
mysql < soluzione/parte-b/schema-and-seed.sql
```

Eseguire:

```bash
mysql exam_students < soluzione/parte-b/soluzione.sql
```

Confrontare il risultato con:

```text
soluzione/parte-b/risultato-atteso.it.md
```

## Gate finale

La prova non è considerata superata perché "il codice sembra giusto".

Serve evidenza di:

```text
PHP_SYNTAX=PASS
BOOK_CREATE=PASS
BOOK_LIST=PASS
DUPLICATE_TITLE_REJECTED=PASS
BOOK_DELETE=PASS
DATA_PERSISTENCE=PASS
SQL_JOIN=PASS
SQL_ORDER=PASS
FINAL_SIMULATION=PASS
```
