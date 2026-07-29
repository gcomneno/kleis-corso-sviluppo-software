# Moduli applicativi — Mini-ecommerce

## Obiettivo

Dividere il mini-ecommerce in moduli piccoli, comprensibili e spiegabili.

La modularità serve a evitare un unico file PHP enorme e ingestibile.

## 01 — Autenticazione

Responsabilità:

- registrazione;
- login;
- logout;
- gestione sessione utente;
- password hash;
- controllo credenziali.

Pagine possibili:

- `register.php`
- `login.php`
- `logout.php`

Concetti PHP attesi:

- form;
- `POST`;
- sessioni;
- password hashing;
- query parametrizzate.

## 02 — Autorizzazione

Responsabilità:

- distinguere utenti normali e admin;
- proteggere pagine riservate;
- impedire azioni non autorizzate.

Esempi:

- solo admin può creare prodotti;
- solo admin può modificare prodotti;
- solo utente loggato può confermare un ordine.

Concetti:

- ruolo utente;
- guard clause;
- redirect se non autorizzato.

## 03 — Catalogo articoli/prodotti

Responsabilità:

- mostrare elenco prodotti;
- mostrare dettaglio prodotto;
- mostrare prezzo;
- filtrare eventualmente per categoria;
- mostrare disponibilità.

Pagine possibili:

- `index.php`
- `products.php`
- `product.php`

Query tipiche:

- elenco prodotti;
- dettaglio prodotto per id;
- prodotti per categoria.

## 04 — Carrello

Responsabilità:

- aggiungere prodotto;
- rimuovere prodotto;
- aggiornare quantità;
- svuotare carrello;
- calcolare totale;
- conservare stato tra pagine.

Pagine possibili:

- `cart.php`
- `cart_add.php`
- `cart_update.php`
- `cart_remove.php`
- `cart_clear.php`

Decisione probabile:

- carrello in `$_SESSION`.

Il carrello è il modulo più delicato perché collega catalogo, sessione, checkout e ordini.

## 05 — Checkout

Responsabilità:

- riepilogare carrello;
- validare che il carrello non sia vuoto;
- creare ordine;
- creare righe ordine;
- svuotare carrello;
- mostrare conferma.

Pagine possibili:

- `checkout.php`
- `order_confirm.php`

Concetti chiave:

- transazione, se affrontata;
- `lastInsertId()`;
- salvataggio prezzo storico.

## 06 — Ordini

Responsabilità:

- salvare ordine;
- mostrare storico ordini;
- mostrare dettaglio ordine;
- permettere admin di vedere tutti gli ordini.

Pagine possibili:

- `orders.php`
- `order_detail.php`
- `admin/orders.php`

## 07 — Admin prodotti

Responsabilità:

- creare prodotto;
- modificare prodotto;
- disattivare prodotto;
- eventualmente cancellare prodotto.

Pagine possibili:

- `admin/products.php`
- `admin/product_create.php`
- `admin/product_edit.php`

Nota: cancellare fisicamente prodotti può creare problemi con ordini storici. Meglio usare un campo `disponibile`.

## 08 — Sicurezza e validazione

Responsabilità trasversale:

- validare input;
- proteggere da SQL injection;
- proteggere password;
- controllare sessione;
- controllare autorizzazioni;
- gestire errori.

Regole minime:

- mai concatenare input utente dentro SQL;
- usare query preparate;
- validare id numerici;
- usare `password_hash`;
- usare `password_verify`;
- controllare ruolo prima di azioni admin.
