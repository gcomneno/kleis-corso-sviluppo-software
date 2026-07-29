# Soluzioni commentate — SQL E-commerce 05

## 1. Creare la tabella clienti

```sql
CREATE TABLE clienti (
  cliente_id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  email VARCHAR(150) NOT NULL UNIQUE,
  citta VARCHAR(80),
  data_registrazione DATE NOT NULL
);
```

`cliente_id` identifica ogni cliente.

`email` è `UNIQUE`, quindi non può ripetersi.

`citta` può essere `NULL`.

## 2. Controllare la struttura

```sql
DESCRIBE clienti;
```

Serve a verificare campi, tipi, chiavi e vincoli.

## 3. Testare UNIQUE

```sql
INSERT INTO clienti (nome, email, citta, data_registrazione)
VALUES ('Mario Rossi', 'mario@example.com', 'Lucca', '2026-07-29');

INSERT INTO clienti (nome, email, citta, data_registrazione)
VALUES ('Mario Doppio', 'mario@example.com', 'Pisa', '2026-07-29');
```

Il secondo inserimento viene rifiutato perché l'email è duplicata.

## 4. Aggiungere il prezzo

```sql
ALTER TABLE brani
ADD COLUMN prezzo DECIMAL(6,2) NOT NULL DEFAULT 0.99;
```

`DEFAULT 0.99` assegna un prezzo anche ai brani già presenti.

## 5. Aggiornare alcuni prezzi

```sql
UPDATE brani
SET prezzo = 1.29
WHERE anno >= 2000;

UPDATE brani
SET prezzo = 1.49
WHERE durata_minuti >= 8;
```

L'ordine degli aggiornamenti conta: il secondo può sovrascrivere alcuni prezzi impostati dal primo.

## 6. Distribuzione dei prezzi

```sql
SELECT prezzo, COUNT(*) AS quanti_brani
FROM brani
GROUP BY prezzo
ORDER BY prezzo;
```

Risultato atteso:

| prezzo | quanti_brani |
|---:|---:|
| 0.99 | 80 |
| 1.29 | 20 |
| 1.49 | 7 |

## 7. Creare la tabella ordini

```sql
CREATE TABLE ordini (
  ordine_id INT AUTO_INCREMENT PRIMARY KEY,
  cliente_id INT NOT NULL,
  data_ordine DATETIME NOT NULL,
  stato VARCHAR(20) NOT NULL DEFAULT 'in attesa',
  FOREIGN KEY (cliente_id) REFERENCES clienti(cliente_id)
);
```

`cliente_id` collega ogni ordine a un cliente esistente.

## 8. Testare l'integrità referenziale

```sql
INSERT INTO ordini (cliente_id, data_ordine)
VALUES (999999, NOW());
```

Se il cliente non esiste, il database rifiuta l'inserimento.

## 9. Creare righe_ordine

```sql
CREATE TABLE righe_ordine (
  riga_id INT AUTO_INCREMENT PRIMARY KEY,
  ordine_id INT NOT NULL,
  brano_id INT NOT NULL,
  quantita INT NOT NULL DEFAULT 1,
  prezzo_unitario DECIMAL(6,2) NOT NULL,
  FOREIGN KEY (ordine_id) REFERENCES ordini(ordine_id),
  FOREIGN KEY (brano_id) REFERENCES brani(id)
);
```

`righe_ordine` collega ordini e brani.

## 10. Perché prezzo_unitario

`prezzo_unitario` salva il prezzo del brano al momento dell'acquisto.

Se domani il prezzo in `brani` cambia, gli ordini già effettuati conservano il prezzo storico.

## 11. Inserire un ordine completo

Versione didattica con id mostrato a video:

```sql
INSERT INTO ordini (cliente_id, data_ordine)
VALUES (3, NOW());

SELECT LAST_INSERT_ID();
```

Versione più pratica con variabile:

```sql
INSERT INTO ordini (cliente_id, data_ordine)
VALUES (3, NOW());

SET @ordine_id = LAST_INSERT_ID();

INSERT INTO righe_ordine (ordine_id, brano_id, quantita, prezzo_unitario)
VALUES
  (@ordine_id, 2, 1, 0.99),
  (@ordine_id, 4, 2, 1.29);
```

## 12. Controllare il risultato

```sql
SELECT *
FROM righe_ordine
WHERE ordine_id = @ordine_id;
```

## Risposte alle domande di verifica

1. `AUTO_INCREMENT` assegna automaticamente un nuovo id progressivo.
2. `UNIQUE` sull'email impedisce registrazioni duplicate.
3. `DECIMAL(6,2)` è adatto ai prezzi perché conserva valori esatti.
4. `DEFAULT` assegna un valore predefinito quando non viene specificato.
5. Una `FOREIGN KEY` impedisce collegamenti verso righe inesistenti.
6. Uno-a-molti: una riga può collegarsi a molte righe. Molti-a-molti: molte righe da entrambe le parti, quindi serve una tabella ponte.
7. `righe_ordine` è tabella ponte perché collega `ordini` e `brani`.
8. Non si inventa l'id ordine perché lo assegna il database.
9. `LAST_INSERT_ID()` recupera l'id appena generato.
10. In PHP/PDO il concetto corrisponde a `lastInsertId()`.
