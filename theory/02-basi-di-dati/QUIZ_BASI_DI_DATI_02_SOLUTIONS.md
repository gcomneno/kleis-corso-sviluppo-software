# Soluzioni — Quiz Basi di dati 02

## Risposte a risposta multipla

### 1. Risposta corretta: B

Il database dell'esercitazione si chiama `MUSICA`.

---

### 2. Risposta corretta: A

Nella prima versione il genere era un campo testuale dentro la tabella `Brani`.

---

### 3. Risposta corretta: B

Il testo libero può generare valori incoerenti: `ROCK`, `rock`, `Rock and roll`, errori di battitura e varianti inutili.

---

### 4. Risposta corretta: C

La struttura viene migliorata aggiungendo una tabella `GeneriMusicali`.

---

### 5. Risposta corretta: B

La tabella contiene `idgenere` e `genere`.

---

### 6. Risposta corretta: C

Dopo il miglioramento, in `Brani` si salva l'identificativo del genere, non il testo del genere.

---

### 7. Risposta corretta: A

Una relazione collega logicamente record appartenenti a tabelle diverse.

---

### 8. Risposta corretta: A

`GeneriMusicali.idgenere` identifica univocamente un genere, quindi è chiave primaria.

---

### 9. Risposta corretta: A

`Brani.idgenere` collega il brano al genere corrispondente, quindi è chiave esterna.

---

### 10. Risposta corretta: B

Una tabella separata riduce duplicazioni e mantiene i valori coerenti.

---

### 11. Risposta corretta: A

CRUD significa Create, Read, Update, Delete.

---

### 12. Risposta corretta: C

Create corrisponde a `INSERT`.

---

### 13. Risposta corretta: A

Read corrisponde a `SELECT`.

---

### 14. Risposta corretta: C

Update corrisponde a `UPDATE`.

---

### 15. Risposta corretta: A

Delete corrisponde a `DELETE`.

---

### 16. Risposta corretta: A

`WHERE` filtra i record su cui lavorare.

---

### 17. Risposta corretta: A

Senza `WHERE`, `DELETE FROM brani;` cancella tutti i record della tabella.

---

### 18. Risposta corretta: A

Senza `WHERE`, l'`UPDATE` modifica tutti i record della tabella.

---

### 19. Risposta corretta: A

`LIKE '%rossi%'` cerca valori che contengono `rossi` in qualunque posizione.

---

### 20. Risposta corretta: A

`IN` controlla se un campo contiene uno dei valori indicati nella lista.

---

## Risposte aperte — Esempi

### 21. Perché separare i generi

Separare i generi evita di riscrivere lo stesso testo in tanti record.

Inoltre riduce errori di battitura, permette valori coerenti e rende più facile creare menu a discesa nelle interfacce.

---

### 22. Differenza tra `GeneriMusicali.idgenere` e `Brani.idgenere`

`GeneriMusicali.idgenere` è chiave primaria perché identifica un genere nella tabella dei generi.

`Brani.idgenere` è chiave esterna perché collega un brano a uno dei generi presenti nella tabella `GeneriMusicali`.

---

### 23. Query SELECT

```sql
SELECT titolo, autore
FROM brani;
```

---

### 24. Query UPDATE

```sql
UPDATE brani
SET anno = 1999
WHERE idprogressivo = 3;
```

---

### 25. Perché WHERE è fondamentale

`WHERE` limita l'operazione ai record corretti.

Senza `WHERE`, `UPDATE` modifica tutti i record e `DELETE` cancella tutti i record.

È una delle principali cause di disastri nei database.

---

## Mini-esercizio finale — Esempio di soluzione

### 1. Tabelle principali

- `generi_musicali`
- `brani`

### 2. Chiavi primarie

- `generi_musicali.idgenere`
- `brani.idprogressivo`

### 3. Chiavi esterne

- `brani.idgenere` → `generi_musicali.idgenere`

### 4. INSERT

```sql
INSERT INTO brani (titolo, autore, anno, duratamin, idgenere)
VALUES ('Come mai', '883', 1992, 4.5, 1);
```

### 5. SELECT

```sql
SELECT titolo, autore, anno
FROM brani
WHERE idgenere = 1;
```

### 6. UPDATE

```sql
UPDATE brani
SET duratamin = 4.6
WHERE idprogressivo = 1;
```

### 7. DELETE sicura

```sql
DELETE FROM brani
WHERE idprogressivo = 1;
```
