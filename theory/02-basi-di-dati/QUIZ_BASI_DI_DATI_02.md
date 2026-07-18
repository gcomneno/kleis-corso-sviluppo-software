# Quiz — Basi di dati 02

## Istruzioni

Rispondi senza guardare le soluzioni.

Obiettivo: verificare relazioni tra tabelle e operazioni CRUD SQL.

---

## Domande a risposta multipla

### 1. Quale database viene proposto nell'esercitazione?

A. SCUOLA
B. MUSICA
C. MAGAZZINO
D. CLIENTI

---

### 2. Nella prima versione della tabella `Brani`, il genere era salvato come:

A. campo testuale dentro `Brani`
B. file esterno
C. immagine
D. password

---

### 3. Quale problema nasce salvando il genere come testo libero?

A. Il database non può contenere numeri
B. Possono nascere valori incoerenti come `ROCK`, `rock`, `Rock and roll`
C. La tabella non può avere righe
D. SQL smette di funzionare

---

### 4. Quale tabella viene aggiunta per migliorare la struttura?

A. Utenti
B. Carrelli
C. GeneriMusicali
D. Password

---

### 5. Quali campi contiene la tabella `GeneriMusicali` secondo l'esercizio?

A. titolo, autore
B. idgenere, genere
C. idcliente, nome
D. anno, durata

---

### 6. Dopo il miglioramento, nella tabella `Brani` si salva:

A. il nome del genere scritto a mano
B. una immagine del genere
C. l'id del genere
D. il colore del genere

---

### 7. Che cos'è una relazione tra tabelle?

A. Un collegamento logico tra record di tabelle diverse
B. Un commento nel codice HTML
C. Un tipo di font
D. Una cartella del sistema operativo

---

### 8. In `GeneriMusicali`, `idgenere` è tipicamente:

A. chiave primaria
B. chiave esterna
C. file CSS
D. valore casuale senza significato

---

### 9. In `Brani`, `idgenere` è tipicamente:

A. chiave esterna
B. chiave primaria della tabella `GeneriMusicali`
C. titolo del brano
D. comando SQL

---

### 10. Perché usare una tabella separata per i generi?

A. Per rendere il database più confuso
B. Per evitare duplicazioni e mantenere valori coerenti
C. Per impedire le query
D. Per cancellare i brani

---

### 11. Che cosa significa CRUD?

A. Create, Read, Update, Delete
B. Copy, Run, Upload, Download
C. Code, Render, Use, Debug
D. Commit, Rebase, Undo, Deploy

---

### 12. Quale comando SQL corrisponde a Create?

A. SELECT
B. DELETE
C. INSERT
D. WHERE

---

### 13. Quale comando SQL corrisponde a Read?

A. SELECT
B. UPDATE
C. DELETE
D. INSERT

---

### 14. Quale comando SQL corrisponde a Update?

A. SELECT
B. INSERT
C. UPDATE
D. FROM

---

### 15. Quale comando SQL corrisponde a Delete?

A. DELETE
B. SELECT
C. VALUES
D. LIKE

---

### 16. A cosa serve `WHERE`?

A. A filtrare i record su cui operare
B. A creare un database
C. A cambiare il nome del DBMS
D. A creare una tabella HTML

---

### 17. Perché `DELETE FROM brani;` è pericoloso?

A. Perché cancella tutti i record della tabella
B. Perché inserisce dati duplicati
C. Perché crea una relazione
D. Perché trasforma i numeri in testo

---

### 18. Perché `UPDATE brani SET anno = 1979;` è pericoloso?

A. Perché modifica tutti i record della tabella
B. Perché cancella il database
C. Perché crea una nuova tabella
D. Perché impedisce le SELECT

---

### 19. A cosa serve `LIKE '%rossi%'`?

A. A cercare valori che contengono `rossi` in qualunque posizione
B. A cercare solo il valore esatto `rossi`
C. A cancellare tutti gli autori
D. A creare una chiave primaria

---

### 20. A cosa serve `IN (25, 26, 28, 29)`?

A. A selezionare record il cui campo corrisponde a uno dei valori indicati
B. A ordinare alfabeticamente
C. A creare un menu a discesa
D. A rinominare una tabella

---

## Domande aperte

### 21. Spiega perché spostare i generi musicali in una tabella separata migliora il database.

---

### 22. Spiega la differenza tra `GeneriMusicali.idgenere` e `Brani.idgenere`.

---

### 23. Scrivi una query SQL per leggere titolo e autore di tutti i brani.

---

### 24. Scrivi una query SQL per modificare l'anno del brano con `idprogressivo = 3`.

---

### 25. Spiega perché `WHERE` è fondamentale con `UPDATE` e `DELETE`.

---

## Mini-esercizio finale

Progetta una versione migliorata del database `MUSICA`.

Devi indicare:

1. tabelle principali;
2. chiavi primarie;
3. chiavi esterne;
4. una query `INSERT`;
5. una query `SELECT`;
6. una query `UPDATE`;
7. una query `DELETE` sicura con `WHERE`.
