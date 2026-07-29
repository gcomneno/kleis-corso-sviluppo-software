# Laboratorio SQL — E-commerce 05

## Obiettivo

Trasformare il database `shop` da catalogo musicale a base dati per un mini e-commerce.

## Parte 1 — Clienti

### 1. Crea la tabella clienti

Crea una tabella `clienti` con:

- `cliente_id`;
- `nome`;
- `email`;
- `citta`;
- `data_registrazione`.

Regole:

- `cliente_id` deve essere chiave primaria con `AUTO_INCREMENT`;
- `nome` è obbligatorio;
- `email` è obbligatoria e unica;
- `citta` è facoltativa;
- `data_registrazione` è obbligatoria.

### 2. Controlla la struttura

Usa `DESCRIBE` per verificare la struttura della tabella `clienti`.

### 3. Testa il vincolo UNIQUE

Prova a inserire due clienti con la stessa email.

Domanda: cosa succede al secondo inserimento?

## Parte 2 — Prezzo dei brani

### 4. Aggiungi il prezzo

Aggiungi alla tabella `brani` una colonna `prezzo` di tipo `DECIMAL(6,2)`, obbligatoria, con valore predefinito `0.99`.

### 5. Aggiorna alcuni prezzi

Imposta:

- prezzo `1.29` per i brani dal 2000 in poi;
- prezzo `1.49` per i brani con durata maggiore o uguale a 8.

### 6. Conta i brani per prezzo

Mostra quanti brani ci sono per ciascun prezzo.

## Parte 3 — Ordini

### 7. Crea la tabella ordini

Crea una tabella `ordini` con:

- `ordine_id`;
- `cliente_id`;
- `data_ordine`;
- `stato`.

`cliente_id` deve essere chiave esterna verso `clienti(cliente_id)`.

### 8. Prova l'integrità referenziale

Prova a inserire un ordine con un `cliente_id` inesistente.

Domanda: cosa deve fare il database?

## Parte 4 — Righe ordine

### 9. Crea la tabella righe_ordine

Crea una tabella `righe_ordine` con:

- `riga_id`;
- `ordine_id`;
- `brano_id`;
- `quantita`;
- `prezzo_unitario`.

`ordine_id` deve puntare a `ordini(ordine_id)`.

`brano_id` deve puntare a `brani(id)`.

### 10. Spiega prezzo_unitario

Perché salviamo `prezzo_unitario` in `righe_ordine` se il prezzo esiste già in `brani`?

## Parte 5 — Flusso ordine

### 11. Inserisci un ordine completo

Simula la conferma di un carrello:

1. inserisci un ordine per un cliente esistente;
2. recupera l'id generato;
3. inserisci due righe d'ordine collegate a quell'id.

### 12. Controlla il risultato

Visualizza le righe dell'ordine appena inserito.

## Domande di verifica

1. A cosa serve `AUTO_INCREMENT`?
2. Perché l'email del cliente deve essere `UNIQUE`?
3. Perché per un prezzo si usa `DECIMAL(6,2)`?
4. A cosa serve `DEFAULT`?
5. Che cosa garantisce una `FOREIGN KEY`?
6. Che differenza c'è tra relazione uno-a-molti e molti-a-molti?
7. Perché `righe_ordine` è una tabella ponte?
8. Perché non si deve inventare a mano il numero dell'ordine?
9. A cosa serve `LAST_INSERT_ID()`?
10. Qual è il collegamento pratico con PHP/PDO?
