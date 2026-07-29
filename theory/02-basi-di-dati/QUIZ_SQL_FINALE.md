# Quiz SQL finale — Basi di dati

## Obiettivo

Ripasso completo del modulo SQL.

Il quiz copre:

- concetti base di database relazionale;
- tabelle, record, campi, chiavi;
- `SELECT`;
- `WHERE`;
- operatori di confronto;
- `LIKE`;
- `IN`;
- `NULL`;
- operatori logici;
- `INSERT`;
- `UPDATE`;
- `DELETE`;
- `INNER JOIN`;
- `LEFT JOIN`;
- `ORDER BY`;
- `LIMIT`;
- `DISTINCT`;
- funzioni di aggregazione;
- `GROUP BY`;
- `HAVING`;
- progettazione di tabelle per e-commerce;
- chiavi esterne;
- flusso ordine con `LAST_INSERT_ID()`.

## Regole

1. Non guardare subito le soluzioni.
2. Scrivi prima la risposta a parole o la query.
3. Solo dopo confronta con `QUIZ_SQL_FINALE_SOLUTIONS.md`.
4. Per le query di modifica (`INSERT`, `UPDATE`, `DELETE`), pensa sempre prima alla `WHERE`.

---

# Parte 1 — Concetti base

## 1. Database e DBMS

Spiega la differenza tra database e DBMS.

## 2. Tabella, record e campo

Associa correttamente:

| Termine | Significato |
|---|---|
| tabella | ? |
| record | ? |
| campo | ? |

## 3. Chiave primaria

Che cos'è una chiave primaria?

## 4. Chiave esterna

Che cos'è una chiave esterna?

## 5. Relazione uno-a-molti

Nel rapporto tra `clienti` e `ordini`, quale tabella contiene la chiave esterna e perché?

---

# Parte 2 — SELECT e WHERE

## 6. Tutti i brani

Scrivi una query che visualizza tutti i campi di tutti i brani.

## 7. Solo alcune colonne

Scrivi una query che visualizza solo `titolo` e `anno` dalla tabella `brani`.

## 8. Filtro per anno

Scrivi una query che trova tutti i brani pubblicati nel 1991.

## 9. Brani dopo il 2000

Scrivi una query che mostra `titolo` e `anno` dei brani pubblicati dopo il 2000.

## 10. Brani più corti di 3 minuti

Scrivi una query che mostra `titolo` e `durata_minuti` dei brani con durata inferiore a 3.

---

# Parte 3 — Operatori, LIKE, IN e NULL

## 11. Diverso da 1991

Scrivi una query che mostra `titolo` e `anno` dei brani non pubblicati nel 1991.

Poi spiega perché questa query non include i brani con `anno NULL`.

## 12. IN

Scrivi una query che trova i brani pubblicati nel 1991, 1994 oppure 1999 usando `IN`.

## 13. LIKE iniziale

Scrivi una query che trova i brani il cui titolo inizia con `S`.

## 14. LIKE interno

Scrivi una query che trova i brani il cui titolo contiene `love`.

## 15. NULL

Scrivi una query che trova i brani senza anno.

## 16. Anni Settanta

Scrivi una query che mostra i brani pubblicati dal 1970 al 1979 compresi.

## 17. AND e OR

Scrivi una query che trova i brani pubblicati dopo il 1990 il cui titolo contiene `love` oppure `you`.

Attenzione alle parentesi.

---

# Parte 4 — INSERT, UPDATE, DELETE

## 18. INSERT semplice

Prima ricava l'id di `Prince`, poi scrivi la query per inserire `Purple Rain` con:

- autore: Prince;
- durata: 8.41;
- anno: `NULL`;
- genere: `NULL`.

## 19. UPDATE

Scrivi una query che aggiorna `Purple Rain` impostando:

- anno: 1984;
- genere_id: 10.

## 20. DELETE

Scrivi una query che cancella `Purple Rain`.

## 21. Rischio UPDATE

Perché una `UPDATE` senza `WHERE` è pericolosa?

## 22. Rischio DELETE

Perché una `DELETE` senza `WHERE` è pericolosa?

---

# Parte 5 — JOIN

## 23. Titolo e autore

Scrivi una query che mostra il titolo di ogni brano e il nome del suo autore.

## 24. Titolo, autore, genere, anno

Scrivi una query che mostra:

- titolo;
- autore;
- genere;
- anno.

Collega `brani`, `autori` e `generi`.

## 25. INNER JOIN e righe mancanti

Perché alcuni brani possono sparire quando usi `INNER JOIN generi`?

## 26. LEFT JOIN

Riscrivi la query dell'esercizio 24 usando `LEFT JOIN` su `generi`, così da non perdere i brani senza genere.

---

# Parte 6 — ORDER BY, LIMIT, DISTINCT

## 27. Ordinamento crescente

Scrivi una query che mostra `titolo` e `anno` dei brani ordinati per anno crescente.

Che cosa succede ai valori `NULL` in MySQL?

## 28. Ordinamento con doppio criterio

Scrivi una query che ordina i brani:

1. dal più recente al più vecchio;
2. a parità di anno, per titolo alfabetico.

## 29. LIMIT

Scrivi una query che mostra i 5 brani più recenti.

## 30. I 3 brani più lunghi

Scrivi una query che mostra i 3 brani con durata maggiore.

## 31. DISTINCT

Scrivi una query che mostra gli anni diversi presenti nella tabella `brani`.

---

# Parte 7 — Aggregazioni

## 32. COUNT totale

Scrivi una query che conta tutti i brani.

## 33. COUNT campo

Scrivi una query che mostra:

- totale dei brani;
- numero di brani con anno compilato.

## 34. COUNT(*) vs COUNT(anno)

Spiega la differenza tra `COUNT(*)` e `COUNT(anno)`.

## 35. MIN e MAX

Scrivi una query che mostra l'anno più vecchio e l'anno più recente presenti nel database.

## 36. AVG e ROUND

Scrivi una query che calcola l'anno medio dei brani, arrotondato all'intero.

## 37. BETWEEN

Scrivi una query che conta i brani pubblicati tra il 1990 e il 1999 compresi.

## 38. Durata minuti

Perché non è corretto calcolare `SUM(durata_minuti)` se il campo usa il formato `minuti.secondi`?

---

# Parte 8 — GROUP BY e HAVING

## 39. Brani per genere

Scrivi una query che mostra quanti brani contiene ogni genere, ordinando dal genere più numeroso.

## 40. Anni con più brani

Scrivi una query che mostra i 5 anni con più brani, escludendo gli anni `NULL`.

## 41. Generi con almeno 5 brani

Scrivi una query che mostra solo i generi con almeno 5 brani.

## 42. Autori con più di un brano

Scrivi una query che mostra solo gli autori presenti con più di un brano.

## 43. WHERE vs HAVING

Spiega la differenza tra `WHERE` e `HAVING`.

## 44. Aggregazione con JOIN

Scrivi una query che mostra, per ogni genere:

- nome del genere;
- numero di brani;
- anno medio arrotondato.

Ordina dal genere mediamente più vecchio.

---

# Parte 9 — Progettazione e-commerce

## 45. Tipi di dato

Scegli il tipo MySQL corretto:

| Dato | Tipo |
|---|---|
| id cliente | ? |
| email | ? |
| prezzo | ? |
| data registrazione | ? |
| data e ora ordine | ? |
| quantità acquistata | ? |

## 46. Tabella clienti

Scrivi la `CREATE TABLE` per una tabella `clienti` con:

- `cliente_id`;
- `nome`;
- `email`;
- `citta`;
- `data_registrazione`.

Vincoli:

- `cliente_id` chiave primaria auto incrementale;
- `nome` obbligatorio;
- `email` obbligatoria e unica;
- `citta` facoltativa;
- `data_registrazione` obbligatoria.

## 47. ALTER TABLE prezzo

Scrivi la query per aggiungere a `brani` una colonna `prezzo DECIMAL(6,2)` obbligatoria con valore predefinito `0.99`.

## 48. Tabella ordini

Scrivi la `CREATE TABLE` per `ordini` con:

- `ordine_id`;
- `cliente_id`;
- `data_ordine`;
- `stato`.

`cliente_id` deve essere chiave esterna verso `clienti(cliente_id)`.

## 49. Tabella righe_ordine

Scrivi la `CREATE TABLE` per `righe_ordine` con:

- `riga_id`;
- `ordine_id`;
- `brano_id`;
- `quantita`;
- `prezzo_unitario`.

`ordine_id` deve puntare a `ordini(ordine_id)`.

`brano_id` deve puntare a `brani(id)`.

## 50. prezzo_unitario

Perché `prezzo_unitario` va salvato in `righe_ordine`, anche se il prezzo è già presente in `brani`?

## 51. LAST_INSERT_ID

A cosa serve `LAST_INSERT_ID()` nel flusso di registrazione ordine?

## 52. Flusso ordine

Metti in ordine i passaggi:

- inserire righe ordine;
- creare ordine;
- recuperare id ordine;
- leggere carrello.

## 53. Collegamento con PHP/PDO

Quale metodo PDO corrisponde concettualmente a `LAST_INSERT_ID()`?

---

# Parte 10 — Debug e ragionamento

## 54. Query sbagliata con NULL

Che cosa c'è di sbagliato?

```sql
SELECT titolo FROM brani WHERE anno = NULL;
```

## 55. Query sbagliata con gruppi

Che cosa c'è di sbagliato?

```sql
SELECT g.nome, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
WHERE COUNT(*) >= 5
GROUP BY g.nome;
```

## 56. Query pericolosa

Che cosa fa questa query?

```sql
DELETE FROM brani;
```

## 57. JOIN da scegliere

Vuoi mostrare tutti i brani, anche quelli senza genere. Quale JOIN devi usare tra `brani` e `generi`?

## 58. Chiave esterna

Che cosa succede se provi a inserire un ordine con `cliente_id` inesistente?

## 59. AUTO_INCREMENT

Perché non bisogna inventare manualmente il numero dell'ordine?

## 60. Domanda finale

Spiega in 5 righe il percorso completo del modulo SQL: da database come catalogo fino a mini e-commerce.
