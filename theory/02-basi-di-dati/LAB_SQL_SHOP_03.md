# Laboratorio SQL — Shop 03

## Obiettivo

Esercitarsi su 20 query SQL a difficoltà crescente usando il database `shop`.

## Tabelle coinvolte

| Tabella | Campi principali |
|---|---|
| `brani` | `id`, `titolo`, `autore_id`, `genere_id`, `durata_minuti`, `anno` |
| `autori` | `autore_id`, `nome` |
| `generi` | `genere_id`, `nome` |

## Regole operative

1. Scrivi prima la query.
2. Eseguila.
3. Controlla il numero di righe.
4. Confronta con le soluzioni solo dopo aver provato.
5. Prima di `UPDATE` e `DELETE`, fai sempre una `SELECT` con la stessa `WHERE`.

---

## Livello 1 — SELECT

### 1. Tutti i brani

Visualizza tutti i dati contenuti nella tabella dei brani.

### 2. Titolo e anno

Visualizza soltanto il titolo e l'anno di tutti i brani.

### 3. Generi musicali

Visualizza l'elenco completo dei generi musicali presenti nel database.

---

## Livello 2 — WHERE e operatori di confronto

### 4. Brani del 1991

Trova tutti i brani pubblicati nel 1991.

### 5. Brani dopo il 2000

Visualizza titolo e anno dei brani pubblicati dopo il 2000.

### 6. Brani più corti di 3 minuti

Visualizza titolo e durata dei brani che durano meno di 3 minuti.

### 7. Brani non pubblicati nel 1991

Visualizza titolo e anno di tutti i brani che non sono stati pubblicati nel 1991.

Domanda: perché il totale dei brani del 1991 più quelli non del 1991 non coincide con il totale dei brani?

### 8. Brani del 1991, 1994 o 1999

Trova i brani pubblicati nel 1991, nel 1994 oppure nel 1999 usando `IN`.

---

## Livello 3 — LIKE

### 9. Titoli che iniziano con S

Trova tutti i brani il cui titolo comincia con la lettera `S`.

### 10. Titoli che contengono love

Trova tutti i brani il cui titolo contiene `love` in qualunque posizione.

---

## Livello 4 — NULL e condizioni multiple

### 11. Brani senza anno

Trova i brani per i quali l'anno di pubblicazione non è stato indicato.

### 12. Brani degli anni Settanta

Visualizza titolo e anno dei brani pubblicati dal 1970 al 1979 compresi.

### 13. Brani prima del 1960 oppure dopo il 2015

Visualizza titolo e anno dei brani pubblicati prima del 1960 oppure dopo il 2015.

### 14. Brani dopo il 1990 con love oppure you nel titolo

Trova i brani pubblicati dopo il 1990 il cui titolo contiene `love` oppure `you`.

Attenzione: servono le parentesi.

---

## Livello 5 — INSERT, UPDATE, DELETE

### 15. Inserisci Purple Rain

Inserisci il brano `Purple Rain` di `Prince`, durata 8 minuti e 41 secondi, lasciando vuoti anno e genere.

Prima devi ricavare l'id di Prince dalla tabella `autori`.

### 16. Completa Purple Rain

Aggiorna il brano appena inserito impostando:

- anno: 1984
- genere: Funk

Prima devi ricavare l'id del genere `Funk`.

### 17. Cancella Purple Rain

Cancella dal database il brano `Purple Rain`.

Attenzione: `DELETE` senza `WHERE` svuota la tabella.

---

## Livello 6 — JOIN

### 18. Titolo e autore

Visualizza il titolo di ogni brano affiancato dal nome del suo autore.

### 19. Titolo, autore, genere e anno

Visualizza titolo, autore, genere e anno di ogni brano collegando tutte e tre le tabelle.

Domanda: perché alcuni brani spariscono rispetto all'esercizio precedente?

### 20. LEFT JOIN dopo il 1990

Rifai l'esercizio 19 in modo che non sparisca nessun brano, limitando il risultato ai brani pubblicati dopo il 1990.
