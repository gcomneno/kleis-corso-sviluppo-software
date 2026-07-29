# Roadmap — Mini-ecommerce

## Obiettivo

Costruire progressivamente un mini-ecommerce basilare, compatibile con un esame finale di corso.

Il progetto deve dimostrare:

- comprensione del database;
- uso corretto di PHP;
- gestione di sessioni e form;
- separazione minima delle responsabilità;
- capacità di spiegare le scelte tecniche.

## Fase 0 — Preparazione

Obiettivo: progettare prima di scrivere codice.

Attività:

- definire moduli;
- definire modello dati;
- definire flussi principali;
- identificare rischi;
- preparare checklist d'esame.

Output:

- documentazione progettuale;
- schema database;
- sequenza di implementazione.

## Fase 1 — Database

Obiettivo: definire la base dati.

Tabelle minime:

- utenti o clienti;
- prodotti o articoli;
- categorie, se richieste;
- ordini;
- righe_ordine.

Concetti coinvolti:

- chiavi primarie;
- chiavi esterne;
- relazioni uno-a-molti;
- relazione molti-a-molti tramite tabella ponte;
- prezzi salvati sulle righe ordine;
- integrità referenziale.

## Fase 2 — Catalogo prodotti

Obiettivo: mostrare prodotti/articoli.

Funzionalità minime:

- elenco prodotti;
- dettaglio prodotto;
- prezzo;
- eventuale categoria;
- eventuale disponibilità.

Questa fase può funzionare anche senza login.

## Fase 3 — Carrello

Obiettivo: permettere all'utente di costruire un ordine.

Funzionalità minime:

- aggiungere prodotto;
- rimuovere prodotto;
- modificare quantità;
- svuotare carrello;
- calcolare totale;
- conservare il carrello durante la navigazione.

Decisione provvisoria:

- per un progetto base, il carrello in sessione è probabilmente sufficiente.

## Fase 4 — Checkout e ordini

Obiettivo: trasformare il carrello in ordine.

Funzionalità minime:

- conferma carrello;
- creazione record in `ordini`;
- recupero id ordine;
- creazione righe in `righe_ordine`;
- salvataggio prezzo unitario storico;
- svuotamento carrello dopo conferma.

Concetto SQL centrale:

- `LAST_INSERT_ID()` o equivalente PHP/PDO `lastInsertId()`.

## Fase 5 — Login e autenticazione

Obiettivo: riconoscere l'utente.

Funzionalità minime:

- registrazione;
- login;
- logout;
- password hash;
- sessione utente.

Nota importante: il login è importante, ma non deve bloccare lo sviluppo del catalogo e del carrello.

## Fase 6 — Autorizzazione

Obiettivo: distinguere cosa può fare un utente.

Ruoli minimi:

- cliente;
- admin.

Azioni admin possibili:

- creare prodotti;
- modificare prodotti;
- disattivare prodotti;
- vedere ordini.

Azioni cliente:

- vedere catalogo;
- usare carrello;
- confermare ordine;
- vedere i propri ordini.

## Fase 7 — Rifinitura esame

Obiettivo: rendere il progetto spiegabile.

Preparare:

- schema database;
- elenco moduli;
- flusso carrello-ordine;
- spiegazione login/sessione;
- spiegazione sicurezza;
- limiti noti;
- possibili miglioramenti.

## Sequenza consigliata

1. database;
2. catalogo;
3. carrello;
4. checkout;
5. ordini;
6. login;
7. autorizzazione;
8. admin;
9. validazione e sicurezza;
10. rifinitura esame.
