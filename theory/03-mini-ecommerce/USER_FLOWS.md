# Flussi utente — Mini-ecommerce

## Obiettivo

Descrivere cosa succede nel sito dal punto di vista dell'utente e del database.

## Flusso 1 — Navigazione catalogo

1. Utente apre homepage o catalogo.
2. Il sistema legge i prodotti dal database.
3. Il sistema mostra nome, descrizione breve e prezzo.
4. L'utente apre il dettaglio di un prodotto.
5. Il sistema legge il prodotto per id.
6. Il sistema mostra dettaglio e pulsante aggiungi al carrello.

Query tipiche:

- `SELECT` elenco prodotti;
- `SELECT` prodotto per id;
- eventuale `JOIN` con categoria.

## Flusso 2 — Aggiunta al carrello

1. Utente clicca aggiungi al carrello.
2. Il sistema riceve `prodotto_id`.
3. Il sistema valida che il prodotto esista.
4. Il sistema aggiunge il prodotto al carrello in sessione.
5. Se il prodotto è già presente, aumenta la quantità.
6. Il sistema reindirizza al carrello o al catalogo.

Dati necessari:

- id prodotto;
- quantità;
- prezzo corrente letto dal database o riletto al checkout.

## Flusso 3 — Modifica carrello

1. Utente apre il carrello.
2. Il sistema mostra prodotti, quantità, prezzo unitario e subtotale.
3. Utente modifica quantità o rimuove prodotto.
4. Il sistema aggiorna la sessione.
5. Il totale viene ricalcolato.

Regole:

- quantità minima 1;
- prodotto rimosso se quantità diventa 0;
- carrello vuoto gestito con messaggio chiaro.

## Flusso 4 — Registrazione

1. Utente compila form registrazione.
2. Il sistema valida nome, email e password.
3. Il sistema controlla che email non sia già usata.
4. Il sistema salva password hash.
5. Il sistema crea utente.
6. Il sistema può effettuare login automatico o chiedere login.

Rischi:

- email duplicata;
- password salvata in chiaro;
- input non validato.

## Flusso 5 — Login

1. Utente inserisce email e password.
2. Il sistema cerca utente per email.
3. Il sistema verifica password con hash.
4. Se corretta, salva dati minimi in sessione.
5. Se errata, mostra errore generico.

Dati in sessione:

- id utente;
- nome;
- ruolo.

## Flusso 6 — Checkout

1. Utente apre checkout.
2. Il sistema verifica che sia loggato.
3. Il sistema verifica che il carrello non sia vuoto.
4. Il sistema rilegge i prodotti dal database.
5. Il sistema calcola totale.
6. Utente conferma.
7. Il sistema crea record in `ordini`.
8. Il sistema recupera id ordine.
9. Il sistema crea righe in `righe_ordine`.
10. Il sistema svuota carrello.
11. Il sistema mostra conferma.

Concetto chiave:

- `lastInsertId()` collega ordine e righe ordine.

## Flusso 7 — Area admin

1. Utente admin accede al pannello.
2. Il sistema controlla ruolo.
3. Admin visualizza prodotti.
4. Admin crea o modifica prodotto.
5. Il sistema valida input e salva modifiche.

Regola:

- un utente non admin non deve poter accedere neanche conoscendo l'URL.
