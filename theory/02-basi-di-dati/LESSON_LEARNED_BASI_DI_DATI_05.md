# Lesson Learned — Basi di dati 05

## Argomento

SQL per un progetto e-commerce basato sul database `shop`.

Nelle lezioni precedenti il database `shop` era soprattutto un catalogo musicale formato da:

- `brani`
- `autori`
- `generi`

Con questa lezione il database inizia a diventare la base dati di un piccolo negozio online.

Un e-commerce non deve solo sapere quali prodotti esistono. Deve anche sapere chi compra, cosa compra, quando compra e a quale prezzo.

## Obiettivo della lezione

Imparare a costruire le tabelle necessarie a un progetto e-commerce minimo.

Alla fine della lezione sappiamo usare:

- tipi di dato MySQL;
- `CREATE TABLE`;
- `PRIMARY KEY`;
- `AUTO_INCREMENT`;
- `NOT NULL`;
- `UNIQUE`;
- `DEFAULT`;
- `ALTER TABLE`;
- `FOREIGN KEY`;
- relazioni uno-a-molti;
- relazioni molti-a-molti tramite tabella ponte;
- `INSERT`;
- `LAST_INSERT_ID()`;
- collegamento concettuale con PHP/PDO.

## Cosa manca al database shop

Il catalogo iniziale risponde alla domanda:

> Quali brani vendiamo?

Un e-commerce deve rispondere anche alla domanda:

> Chi ha comprato cosa?

Per questo servono nuovi elementi.

| Elemento | Scopo |
|---|---|
| `clienti` | chi si registra e acquista |
| `ordini` | intestazione dell'acquisto |
| `righe_ordine` | prodotti contenuti in ogni ordine |
| `prezzo` | prezzo di vendita del brano |

## Tipi di dato principali

Per questo progetto bastano pochi tipi MySQL.

| Tipo | Contiene | Esempio |
|---|---|---|
| `INT` | numeri interi | id, quantità |
| `DECIMAL(6,2)` | numeri decimali esatti | prezzo: 1.29 |
| `VARCHAR(n)` | testo fino a n caratteri | nome, email |
| `DATE` | data | data registrazione |
| `DATETIME` | data e ora | momento ordine |

Per il denaro si usa `DECIMAL`, non un tipo approssimato.

Un prezzo deve restare esatto.

```sql
DECIMAL(6,2)
```

Significa: massimo 6 cifre totali, di cui 2 dopo la virgola.

## CREATE TABLE

`CREATE TABLE` crea una tabella.

```sql
CREATE TABLE nome_tabella (
  colonna1 TIPO vincoli,
  colonna2 TIPO vincoli
);
```

Creare una tabella significa decidere:

- quali colonne servono;
- che tipo di dati conterranno;
- quali campi sono obbligatori;
- quale campo identifica la riga;
- quali valori devono essere unici;
- quali relazioni devono essere protette.

## Tabella clienti

```sql
CREATE TABLE clienti (
  cliente_id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  email VARCHAR(150) NOT NULL UNIQUE,
  citta VARCHAR(80),
  data_registrazione DATE NOT NULL
);
```

Significato dei vincoli:

| Vincolo | Significato |
|---|---|
| `PRIMARY KEY` | identifica ogni riga in modo univoco |
| `AUTO_INCREMENT` | assegna automaticamente un numero progressivo |
| `NOT NULL` | campo obbligatorio |
| `UNIQUE` | valore non duplicabile |
| `DEFAULT` | valore predefinito |

`email` è `UNIQUE`: due clienti non possono registrarsi con lo stesso indirizzo.

`citta` non è `NOT NULL`, quindi può restare vuota.

## DESCRIBE

`DESCRIBE` mostra la struttura di una tabella.

```sql
DESCRIBE clienti;
```

Serve per verificare campi, tipi, chiavi, vincoli e `AUTO_INCREMENT`.

## Collegamento con PHP

Questa tabella sarebbe dietro la pagina di registrazione.

Il form HTML raccoglie:

- nome;
- email;
- città.

PHP riceve i dati ed esegue una `INSERT` in `clienti`.

Il database protegge le regole fondamentali:

- nome obbligatorio;
- email obbligatoria;
- email non duplicata.

## ALTER TABLE

Il catalogo `brani` esiste già, ma non ha un prezzo.

Senza prezzo non si vende nulla.

Per aggiungere una colonna a una tabella esistente si usa `ALTER TABLE`.

```sql
ALTER TABLE brani
ADD COLUMN prezzo DECIMAL(6,2) NOT NULL DEFAULT 0.99;
```

`DEFAULT 0.99` assegna un prezzo valido anche ai brani già presenti.

Poi possiamo aggiornare alcuni prezzi.

```sql
UPDATE brani
SET prezzo = 1.29
WHERE anno >= 2000;

UPDATE brani
SET prezzo = 1.49
WHERE durata_minuti >= 8;
```

Anche qui `WHERE` è fondamentale.

Una `UPDATE` senza `WHERE` modifica tutti i brani.

## Relazioni tra tabelle

Le tabelle di un e-commerce non vivono isolate.

Un ordine appartiene a un cliente.

Una riga d'ordine appartiene a un ordine.

Una riga d'ordine si riferisce a un brano.

Questi legami si chiamano relazioni.

Nel database si realizzano con chiavi esterne.

## InnoDB

In MySQL, le chiavi esterne richiedono un motore che supporti le relazioni.

Il motore corretto è `InnoDB`.

`MyISAM` non supporta le relazioni tramite `FOREIGN KEY`.

## Tabella ordini

```sql
CREATE TABLE ordini (
  ordine_id INT AUTO_INCREMENT PRIMARY KEY,
  cliente_id INT NOT NULL,
  data_ordine DATETIME NOT NULL,
  stato VARCHAR(20) NOT NULL DEFAULT 'in attesa',
  FOREIGN KEY (cliente_id) REFERENCES clienti(cliente_id)
);
```

La chiave esterna dice:

> `cliente_id` deve corrispondere a un cliente realmente presente.

Il database rifiuta un ordine collegato a un cliente inesistente.

Questo si chiama integrità referenziale.

## Relazione uno-a-molti

Tra `clienti` e `ordini` c'è una relazione uno-a-molti.

Un cliente può avere molti ordini.

Ogni ordine appartiene a un solo cliente.

```text
clienti 1 ------ N ordini
```

La chiave esterna sta nella tabella dalla parte del molti, quindi in `ordini`.

## Relazione molti-a-molti

Tra `ordini` e `brani` c'è una relazione molti-a-molti.

Un ordine può contenere molti brani.

Uno stesso brano può comparire in molti ordini.

Non si collega direttamente `ordini` a `brani`.

Serve una tabella ponte.

```text
ordini 1 ------ N righe_ordine N ------ 1 brani
```

La tabella ponte è `righe_ordine`.

## Tabella righe_ordine

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

Questa tabella memorizza le singole voci dell'ordine.

Esempio:

| ordine_id | brano_id | quantita | prezzo_unitario |
|---:|---:|---:|---:|
| 9 | 2 | 1 | 0.99 |
| 9 | 4 | 2 | 1.29 |

## Perché salvare prezzo_unitario

Il prezzo del brano esiste già in `brani`.

Però il prezzo di listino può cambiare.

Un ordine già effettuato deve conservare il prezzo del giorno dell'acquisto.

Per questo `righe_ordine` salva `prezzo_unitario`.

È una scelta tipica dei gestionali reali: l'ordine fotografa la situazione al momento dell'acquisto.

## Flusso di un ordine

Quando un cliente conferma il carrello, il sito deve:

1. creare l'intestazione dell'ordine;
2. recuperare l'id generato dal database;
3. inserire le righe collegate a quell'id.

```sql
INSERT INTO ordini (cliente_id, data_ordine)
VALUES (3, NOW());

SELECT LAST_INSERT_ID();

INSERT INTO righe_ordine (ordine_id, brano_id, quantita, prezzo_unitario)
VALUES
  (9, 2, 1, 0.99),
  (9, 4, 2, 1.29);
```

Nel PDF l'id `9` è un esempio.

Nella pratica non bisogna inventarlo a mano.

Lo assegna il database con `AUTO_INCREMENT`.

## LAST_INSERT_ID

`LAST_INSERT_ID()` restituisce l'id generato dall'ultima `INSERT`.

Nel progetto PHP, con PDO, il concetto corrisponde a:

```text
PDO::lastInsertId()
```

Schema logico:

```text
1. PHP inserisce l'ordine
2. PHP recupera l'id generato
3. PHP cicla sui prodotti del carrello
4. PHP inserisce una riga in righe_ordine per ogni prodotto
```

Questa è una delle prime connessioni vere tra SQL e backend.

## Mappa finale

```text
clienti
  cliente_id PK
  nome
  email UNIQUE
  citta
  data_registrazione

ordini
  ordine_id PK
  cliente_id FK -> clienti.cliente_id
  data_ordine
  stato

righe_ordine
  riga_id PK
  ordine_id FK -> ordini.ordine_id
  brano_id FK -> brani.id
  quantita
  prezzo_unitario

brani
  id PK
  titolo
  autore_id FK
  genere_id FK
  durata_minuti
  anno
  prezzo
```

## Errori da evitare

1. Usare tipi approssimati per il denaro.
2. Dimenticare la `PRIMARY KEY`.
3. Inserire a mano valori gestiti da `AUTO_INCREMENT`.
4. Dimenticare `NOT NULL` sui campi obbligatori.
5. Gestire l'unicità dell'email solo lato PHP.
6. Creare relazioni su tabelle MyISAM.
7. Dimenticare le `FOREIGN KEY`.
8. Collegare direttamente `ordini` e `brani` senza tabella ponte.
9. Non salvare `prezzo_unitario` nella riga d'ordine.
10. Inventare manualmente l'id ordine invece di usare `LAST_INSERT_ID()`.

## Sintesi finale

Le lezioni precedenti insegnavano a interrogare un database già pronto.

Questa lezione insegna a progettare la base dati di una piccola applicazione reale.

```text
Prima: leggere dati
Ora: progettare dati per un'applicazione
```

La base dati inizia a parlare la stessa lingua del backend PHP.
