# Checklist esame — Mini-ecommerce

## Obiettivo

Preparare il progetto finale in modo spiegabile.

L'esame non valuterà solo se qualcosa funziona, ma anche se si capisce cosa si è costruito.

## Checklist funzionale

Il progetto dovrebbe permettere di:

- vedere elenco prodotti;
- vedere dettaglio prodotto;
- aggiungere prodotto al carrello;
- modificare quantità nel carrello;
- rimuovere prodotto dal carrello;
- calcolare totale carrello;
- registrare un utente;
- fare login;
- fare logout;
- confermare ordine;
- salvare ordine e righe ordine;
- vedere conferma ordine;
- proteggere almeno una pagina admin.

## Checklist database

Essere pronti a spiegare:

- chiavi primarie;
- chiavi esterne;
- relazione utenti-ordini;
- relazione ordini-righe_ordine;
- relazione prodotti-righe_ordine;
- perché esiste `prezzo_unitario`;
- perché non si salva la password in chiaro;
- perché si usa `DECIMAL` per i prezzi.

## Checklist PHP

Essere pronti a spiegare:

- differenza tra `GET` e `POST`;
- uso delle sessioni;
- login e logout;
- password hashing;
- query parametrizzate;
- gestione del carrello in sessione;
- uso di `lastInsertId()`;
- validazione input.

## Checklist sicurezza

Controllare:

- password non in chiaro;
- query preparate;
- input validato;
- pagine admin protette;
- utente non autorizzato reindirizzato;
- id numerici controllati;
- errori non troppo dettagliati mostrati all'utente.

## Checklist carrello

Il carrello deve gestire:

- prodotto nuovo;
- prodotto già presente;
- quantità aggiornata;
- rimozione;
- svuotamento;
- totale;
- carrello vuoto;
- checkout con utente non loggato;
- checkout con carrello vuoto.

## Checklist spiegazione orale

Saper spiegare in modo semplice:

1. quali tabelle ci sono;
2. perché servono;
3. come passa un prodotto dal catalogo al carrello;
4. come il carrello diventa ordine;
5. perché serve una tabella `righe_ordine`;
6. come funziona il login;
7. come vengono protette le pagine admin;
8. quali limiti ha il progetto;
9. cosa si migliorerebbe con più tempo.

## Rischi principali

| Rischio | Prevenzione |
|---|---|
| progetto troppo grande | partire dal flusso minimo catalogo-carrello-ordine |
| login troppo complesso | implementare prima versione semplice e sicura |
| carrello confuso | definire bene struttura dati in sessione |
| database incoerente | usare chiavi esterne |
| admin non protetto | controllo ruolo centralizzato |
| query insicure | usare query preparate |
| esame poco spiegabile | mantenere documentazione e checklist |

## Versione minima accettabile

Una versione minima, ma difendibile, dovrebbe avere:

- catalogo prodotti;
- carrello in sessione;
- checkout;
- salvataggio ordine e righe ordine;
- login base;
- protezione pagina admin;
- database coerente.

## Versione ideale

Una versione più completa potrebbe aggiungere:

- registrazione utente;
- storico ordini cliente;
- gestione prodotti admin;
- categorie;
- disponibilità prodotti;
- messaggi flash;
- layout più curato;
- validazione più robusta.
