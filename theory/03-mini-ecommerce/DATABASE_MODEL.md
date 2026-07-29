# Modello database — Mini-ecommerce

## Obiettivo

Definire una base dati semplice ma realistica per un mini-ecommerce.

Il modello deve essere abbastanza piccolo da essere completabile durante il corso, ma abbastanza solido da dimostrare comprensione delle relazioni.

## Tabelle candidate

## utenti / clienti

Rappresenta chi accede al sito.

Campi possibili:

- `utente_id`
- `nome`
- `email`
- `password_hash`
- `ruolo`
- `data_registrazione`

Note:

- `email` deve essere unica;
- la password non va salvata in chiaro;
- `ruolo` può distinguere cliente e admin.

## prodotti / articoli

Rappresenta ciò che viene venduto.

Campi possibili:

- `prodotto_id`
- `nome`
- `descrizione`
- `prezzo`
- `categoria_id`
- `disponibile`
- `data_creazione`

Note:

- il prezzo deve usare `DECIMAL`;
- la disponibilità può essere booleana o numerica;
- la categoria è utile ma non obbligatoria per una prima versione.

## categorie

Rappresenta una classificazione dei prodotti.

Campi possibili:

- `categoria_id`
- `nome`

Relazione:

- una categoria può avere molti prodotti;
- ogni prodotto appartiene a una categoria, se il campo è obbligatorio;
- oppure può non avere categoria, se il campo è facoltativo.

## ordini

Rappresenta l'intestazione dell'acquisto.

Campi possibili:

- `ordine_id`
- `utente_id`
- `data_ordine`
- `stato`
- `totale`

Note:

- `utente_id` collega l'ordine al cliente;
- `stato` può essere `in attesa`, `pagato`, `annullato`;
- il totale può essere calcolato dalle righe oppure salvato per semplicità.

## righe_ordine

Rappresenta i prodotti contenuti in un ordine.

Campi possibili:

- `riga_id`
- `ordine_id`
- `prodotto_id`
- `quantita`
- `prezzo_unitario`

Note:

- `prezzo_unitario` va salvato per conservare il prezzo storico;
- `ordine_id` collega la riga all'ordine;
- `prodotto_id` collega la riga al prodotto.

## Relazioni principali

```text
utenti 1 ------ N ordini
ordini 1 ------ N righe_ordine
prodotti 1 ------ N righe_ordine
categorie 1 ------ N prodotti
```

## Decisione sul carrello

Il carrello può essere gestito in due modi.

## Opzione A — Carrello in sessione

Pro:

- più semplice;
- adatto a progetto base;
- non richiede nuove tabelle.

Contro:

- se la sessione scade, il carrello si perde;
- meno realistico.

## Opzione B — Carrello nel database

Tabelle possibili:

- `carrelli`
- `righe_carrello`

Pro:

- più realistico;
- carrello persistente;
- recuperabile dopo login.

Contro:

- più complesso;
- richiede più query e più gestione.

## Scelta provvisoria

Per un mini-ecommerce da esame, partire da carrello in sessione.

Solo se resta tempo, valutare carrello persistito nel database.

## Regole progettuali

1. Ogni tabella importante deve avere una chiave primaria.
2. Ogni relazione deve essere espressa con una chiave esterna quando possibile.
3. I prezzi devono usare `DECIMAL`.
4. Le password devono essere salvate come hash, mai in chiaro.
5. Le righe ordine devono salvare il prezzo storico.
6. Le cancellazioni devono essere gestite con attenzione per non rompere gli ordini storici.
