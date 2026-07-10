# Soluzioni — Quiz Basi di dati 01

## Risposte a risposta multipla

### 1. Risposta corretta: B

Una base di dati è una raccolta organizzata di dati pensata per facilitarne accesso e gestione.

---

### 2. Risposta corretta: B

DBMS significa Database Management System.

È il software che permette di gestire il database.

---

### 3. Risposta corretta: C

MySQL è un DBMS.

HTML, CSS e Bootstrap appartengono invece al mondo web/frontend.

---

### 4. Risposta corretta: C

Excel può essere comodo per tabelle semplici, ma non è progettato per gestire bene grandi archivi, integrità dei dati e accessi concorrenti.

---

### 5. Risposta corretta: A

MySQL e MariaDB sono database relazionali.

---

### 6. Risposta corretta: B

Nei database relazionali i dati vengono memorizzati in tabelle.

---

### 7. Risposta corretta: C

Una riga di una tabella si chiama record.

---

### 8. Risposta corretta: B

Una colonna di una tabella si chiama campo.

---

### 9. Risposta corretta: B

I record di una tabella dovrebbero essere omogenei, cioè avere la stessa struttura informativa.

---

### 10. Risposta corretta: A

Un campo rappresenta una specifica informazione contenuta nei record.

Esempio: nome, cognome, email.

---

### 11. Risposta corretta: A

Una stringa è un tipo di dato testuale.

---

### 12. Risposta corretta: B

Un booleano rappresenta una scelta sì/no o vero/falso.

---

### 13. Risposta corretta: B

Creare una tabella significa definirne la struttura: campi, tipi, vincoli, chiavi.

---

### 14. Risposta corretta: A

Una query è una domanda fatta al database.

---

### 15. Risposta corretta: A

SQL è il linguaggio di interrogazione più comune nei database relazionali.

---

### 16. Risposta corretta: A

Il risultato di una query può essere visto come una tabella, anche vuota o con una sola riga.

---

### 17. Risposta corretta: B

Un indice serve a velocizzare le ricerche su un campo.

---

### 18. Risposta corretta: A

Gli indici occupano spazio e devono essere aggiornati quando i dati cambiano.

Quindi aiutano le letture, ma possono pesare sulle scritture.

---

### 19. Risposta corretta: A

Una chiave è un campo, o una combinazione di campi, che identifica un record.

---

### 20. Risposta corretta: A

La chiave primaria identifica un record dentro la propria tabella.

---

### 21. Risposta corretta: C

No.

Due record diversi non possono avere la stessa chiave primaria.

---

### 22. Risposta corretta: A

Una chiave esterna serve a collegare una tabella a un'altra.

---

### 23. Risposta corretta: A

Se `ordini.id_cliente` punta a `clienti.id_cliente`, allora `ordini.id_cliente` è una chiave esterna.

---

### 24. Risposta corretta: A

Un contatore è un campo numerico generato automaticamente e progressivamente dal DBMS.

---

### 25. Risposta corretta: A

I contatori sono usati spesso come chiavi primarie perché permettono di generare valori unici automaticamente.

---

### 26. Risposta corretta: A

Una tabella dovrebbe contenere dati omogenei.

Esempio: nella tabella `clienti` metto clienti, non clienti mischiati con prodotti e ordini in modo casuale.

---

### 27. Risposta corretta: B

Una query può cercare, ordinare, calcolare, modificare o cancellare dati.

---

### 28. Risposta corretta: A

Scegliere il tipo corretto significa dire al database che tipo di informazione può contenere quel campo.

---

### 29. Risposta corretta: A

`clienti` è un esempio di entità che può avere una tabella dedicata.

---

### 30. Risposta corretta: A

Un database è progettato per dati strutturati, integrità, interrogazioni, relazioni e accessi concorrenti.

---

## Risposte aperte — Esempi

### 31. Differenza tra record e campo

Un record è una riga della tabella.

Un campo è una colonna della tabella.

Esempio:

In una tabella `clienti`, ogni record rappresenta un cliente.

I campi possono essere `id_cliente`, `nome`, `cognome`, `email`.

---

### 32. Differenza tra chiave primaria e chiave esterna

La chiave primaria identifica un record nella propria tabella.

La chiave esterna collega un record a un record contenuto in un'altra tabella.

Esempio:

`clienti.id_cliente` è chiave primaria.

`ordini.id_cliente` è chiave esterna, perché collega un ordine al cliente che lo ha fatto.

---

### 33. Esempio tabella clienti

Possibili campi:

- `id_cliente`
- `nome`
- `cognome`
- `email`
- `telefono`
- `data_registrazione`

`id_cliente` potrebbe essere la chiave primaria.

---

### 34. Esempio query in linguaggio naturale

Esempi validi:

- Trova tutti i clienti registrati nel 2026.
- Mostra tutti gli ordini del mese corrente.
- Elenca i prodotti con quantità inferiore a 5.
- Calcola il totale degli ordini di un cliente.

---

### 35. Perché non indicizzare tutto

Gli indici velocizzano le ricerche, ma occupano spazio e devono essere aggiornati quando i dati cambiano.

Troppi indici possono rallentare inserimenti, modifiche e cancellazioni.

Morale: indice sì, ma con cervello acceso.

---

## Mini-esercizio finale — Esempio di soluzione

### 1. Tabelle possibili

- `libri`
- `autori`
- `clienti`
- `ordini`
- `righe_ordine`

La tabella `righe_ordine` può servire perché un ordine può contenere più libri.

---

### 2. Chiavi primarie possibili

- `libri.id_libro`
- `autori.id_autore`
- `clienti.id_cliente`
- `ordini.id_ordine`
- `righe_ordine.id_riga_ordine`

---

### 3. Chiavi esterne possibili

- `libri.id_autore` può collegare un libro al suo autore
- `ordini.id_cliente` può collegare un ordine al cliente
- `righe_ordine.id_ordine` può collegare una riga al suo ordine
- `righe_ordine.id_libro` può collegare una riga al libro ordinato

---

### 4. Query in linguaggio naturale

Esempi:

- Mostra tutti gli ordini fatti da un determinato cliente.
- Trova tutti i libri di un certo autore.
- Calcola il totale di un ordine.
- Mostra i libri più venduti.
