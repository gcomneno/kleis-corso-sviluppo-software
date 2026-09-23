# Trascrizione — Parte B

## Parte B – Domanda Aperta sul Database (10 punti)

Sono fornite due tabelle.

### Studenti

| IdStudente | Nome | Cognome |
| ---: | --- | --- |
| 1 | Marco | Verdi |
| 2 | Lucia | Bianchi |
| 3 | Alessandro | Neri |

### Esami

| IdEsame | IdStudente | DataEsame | Esito |
| ---: | ---: | --- | ---: |
| 1 | 1 | 10-12-2024 | 28 |
| 2 | 2 | 12-12-2024 | 25 |
| 3 | 1 | 12-12-2024 | 30 |
| 4 | 3 | 16-12-2024 | 25 |

## Richiesta

Date le tabelle sopra riportate:

- scrivere una query SQL che restituisca **Nome, Cognome, DataEsame e Esito** degli esami effettuati;
- ordinare il risultato per **Esito in ordine crescente**;
- rappresentare graficamente, in forma tabellare, il risultato atteso della query.

## Competenze verificate

La domanda misura in particolare:

- comprensione di chiave primaria e chiave esterna;
- relazione uno-a-molti fra Studenti ed Esami;
- uso di `INNER JOIN`;
- condizione di join;
- selezione delle colonne;
- ordinamento con `ORDER BY ... ASC`;
- capacità di calcolare manualmente il risultato della query.
