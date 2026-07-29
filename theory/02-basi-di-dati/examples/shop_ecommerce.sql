-- Query esercitazione SQL — progetto e-commerce
-- Lezione 5 — Basi di dati
-- Database: shop

-- 1. Creare la tabella clienti.
CREATE TABLE clienti (
  cliente_id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  email VARCHAR(150) NOT NULL UNIQUE,
  citta VARCHAR(80),
  data_registrazione DATE NOT NULL
);

-- 2. Controllare la struttura.
DESCRIBE clienti;

-- 3. Inserimento clienti di prova.
INSERT INTO clienti (nome, email, citta, data_registrazione)
VALUES
  ('Mario Rossi', 'mario@example.com', 'Lucca', '2026-07-29'),
  ('Adele Bianchi', 'adele@example.com', 'Pisa', '2026-07-29'),
  ('Luca Verdi', 'luca@example.com', 'Firenze', '2026-07-29');

-- Questo inserimento è volutamente commentato:
-- deve fallire perché l'email è duplicata.
-- INSERT INTO clienti (nome, email, citta, data_registrazione)
-- VALUES ('Mario Doppio', 'mario@example.com', 'Pisa', '2026-07-29');

-- 4. Aggiungere il prezzo al catalogo.
-- Da eseguire una sola volta su un database che non ha già la colonna prezzo.
ALTER TABLE brani
ADD COLUMN prezzo DECIMAL(6,2) NOT NULL DEFAULT 0.99;

-- 5. Aggiornare alcuni prezzi.
UPDATE brani
SET prezzo = 1.29
WHERE anno >= 2000;

UPDATE brani
SET prezzo = 1.49
WHERE durata_minuti >= 8;

-- 6. Controllare distribuzione dei prezzi.
SELECT prezzo, COUNT(*) AS quanti_brani
FROM brani
GROUP BY prezzo
ORDER BY prezzo;

-- 7. Creare la tabella ordini.
CREATE TABLE ordini (
  ordine_id INT AUTO_INCREMENT PRIMARY KEY,
  cliente_id INT NOT NULL,
  data_ordine DATETIME NOT NULL,
  stato VARCHAR(20) NOT NULL DEFAULT 'in attesa',
  FOREIGN KEY (cliente_id) REFERENCES clienti(cliente_id)
);

-- Questo inserimento è volutamente commentato:
-- deve fallire se il cliente 999999 non esiste.
-- INSERT INTO ordini (cliente_id, data_ordine)
-- VALUES (999999, NOW());

-- 8. Creare la tabella righe_ordine.
CREATE TABLE righe_ordine (
  riga_id INT AUTO_INCREMENT PRIMARY KEY,
  ordine_id INT NOT NULL,
  brano_id INT NOT NULL,
  quantita INT NOT NULL DEFAULT 1,
  prezzo_unitario DECIMAL(6,2) NOT NULL,
  FOREIGN KEY (ordine_id) REFERENCES ordini(ordine_id),
  FOREIGN KEY (brano_id) REFERENCES brani(id)
);

-- 9. Registrare un ordine completo.
-- Sostituire cliente_id se nel proprio database il cliente 3 non esiste.
INSERT INTO ordini (cliente_id, data_ordine)
VALUES (3, NOW());

SET @ordine_id = LAST_INSERT_ID();

INSERT INTO righe_ordine (ordine_id, brano_id, quantita, prezzo_unitario)
VALUES
  (@ordine_id, 2, 1, 0.99),
  (@ordine_id, 4, 2, 1.29);

-- 10. Controllare le righe dell'ordine.
SELECT *
FROM righe_ordine
WHERE ordine_id = @ordine_id;
