# Protocollo di simulazione ripetibile

## Scopo

Allenarsi a produrre una soluzione completa **senza copiare il laboratorio PHP precedente**.

La prova va iniziata in una directory vuota.

## Regole consigliate

Durante il primo tentativo:

- non aprire `soluzione/`;
- non copiare file da PHP 1–5;
- sono consentiti solo gli strumenti che sarebbero disponibili in esame;
- prima si progetta, poi si implementa;
- ogni scelta non richiesta deve essere motivata;
- al termine si esegue una verifica funzionale completa.

## Ordine operativo

### Fase 1 — Analisi della traccia

Scrivere prima del codice:

- requisiti funzionali;
- requisiti tecnici;
- dati da persistere;
- operazioni consentite;
- vincoli;
- casi di errore.

### Fase 2 — Disegno dell'interfaccia

Definire almeno:

- lista libri;
- form di inserimento;
- messaggi di successo/errore;
- azione di eliminazione.

### Fase 3 — Modello dati

Decidere:

- tabella;
- chiave primaria;
- colonne;
- tipi;
- vincolo di unicità sul titolo;
- strategia di eliminazione.

### Fase 4 — Implementazione

Implementare:

```text
CREATE libro
READ lista
DELETE libro
UNIQUE titolo
```

Non serve implementare UPDATE: non è richiesto dalla traccia.

### Fase 5 — Parte B SQL

Scrivere la query senza guardare la soluzione e costruire manualmente il risultato ordinato.

### Fase 6 — Verifica

Usare [CHECKLIST.it.md](CHECKLIST.it.md).

## Ripetizione

Una nuova simulazione deve partire da zero. Non modificare la soluzione di riferimento: creare una nuova cartella di tentativo, per esempio:

```text
attempts/
  01/
  02/
  03/
```

Questo rende misurabile il miglioramento tra un tentativo e il successivo.
