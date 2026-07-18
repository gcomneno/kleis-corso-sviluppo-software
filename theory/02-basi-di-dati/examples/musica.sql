-- Esercitazione SQL — Database MUSICA
-- Lezione 2 — Basi di dati
--
-- Obiettivo:
-- creare una struttura relazionale semplice per gestire brani musicali e generi.

CREATE DATABASE IF NOT EXISTS musica;

USE musica;

DROP TABLE IF EXISTS brani;
DROP TABLE IF EXISTS generi_musicali;

CREATE TABLE generi_musicali (
    idgenere INT AUTO_INCREMENT PRIMARY KEY,
    genere VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE brani (
    idprogressivo INT AUTO_INCREMENT PRIMARY KEY,
    titolo VARCHAR(150) NOT NULL,
    autore VARCHAR(100) NOT NULL,
    anno INT,
    duratamin DECIMAL(4, 2),
    idgenere INT NOT NULL,
    CONSTRAINT fk_brani_generi
        FOREIGN KEY (idgenere)
        REFERENCES generi_musicali(idgenere)
);

INSERT INTO generi_musicali (genere) VALUES
    ('POP'),
    ('ROCK'),
    ('JAZZ'),
    ('CLASSICA');

INSERT INTO brani (titolo, autore, anno, duratamin, idgenere) VALUES
    ('Come mai', '883', 1992, 4.50, 1),
    ('Brano rock 1', 'Autore A', 1980, 3.80, 2),
    ('Brano jazz 1', 'Mario Rossi Quartet', 1975, 5.20, 3);

-- READ: leggere alcuni campi dalla tabella brani.
SELECT titolo, autore, anno
FROM brani;

-- READ con relazione tra tabelle.
SELECT
    brani.titolo,
    brani.autore,
    brani.anno,
    generi_musicali.genere
FROM brani
JOIN generi_musicali
    ON brani.idgenere = generi_musicali.idgenere;

-- UPDATE sicuro con WHERE.
UPDATE brani
SET anno = 1979
WHERE idprogressivo = 2;

-- LIKE: cerca autori che contengono 'rossi'.
SELECT *
FROM brani
WHERE autore LIKE '%rossi%';

-- IN: seleziona record con id specifici.
SELECT *
FROM brani
WHERE idprogressivo IN (1, 2, 3);

-- DELETE sicuro con WHERE.
DELETE FROM brani
WHERE idprogressivo = 999;
