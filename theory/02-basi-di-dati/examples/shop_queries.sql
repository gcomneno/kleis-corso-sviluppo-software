-- Query esercitazione SQL — database shop
-- Lezione 3 — Basi di dati

-- 1. Tutti i brani
SELECT *
FROM brani;

-- 2. Solo titolo e anno
SELECT titolo, anno
FROM brani;

-- 3. Elenco dei generi
SELECT *
FROM generi;

-- 4. Brani del 1991
SELECT *
FROM brani
WHERE anno = 1991;

-- 5. Brani dopo il 2000
SELECT titolo, anno
FROM brani
WHERE anno > 2000;

-- 6. Brani più corti di 3 minuti
SELECT titolo, durata_minuti
FROM brani
WHERE durata_minuti < 3;

-- 7. Brani non del 1991
SELECT titolo, anno
FROM brani
WHERE anno <> 1991;

-- 7b. Variante che include anche gli anni NULL
SELECT titolo, anno
FROM brani
WHERE anno <> 1991 OR anno IS NULL;

-- 8. Brani del 1991, 1994 o 1999
SELECT titolo, anno
FROM brani
WHERE anno IN (1991, 1994, 1999);

-- 9. Titoli che iniziano per S
SELECT titolo
FROM brani
WHERE titolo LIKE 'S%';

-- 10. Titoli che contengono love
SELECT titolo
FROM brani
WHERE titolo LIKE '%love%';

-- 11. Brani senza anno
SELECT titolo
FROM brani
WHERE anno IS NULL;

-- 12. Brani degli anni Settanta
SELECT titolo, anno
FROM brani
WHERE anno >= 1970 AND anno <= 1979;

-- 13. Brani prima del 1960 o dopo il 2015
SELECT titolo, anno
FROM brani
WHERE anno < 1960 OR anno > 2015;

-- 14. Brani dopo il 1990 con love o you nel titolo
SELECT titolo, anno
FROM brani
WHERE anno > 1990
  AND (titolo LIKE '%love%' OR titolo LIKE '%you%');

-- 15. Ricavo id autore Prince
SELECT autore_id
FROM autori
WHERE nome = 'Prince';

-- 15b. Inserisco Purple Rain
INSERT INTO brani (titolo, autore_id, genere_id, durata_minuti, anno)
VALUES ('Purple Rain', 57, NULL, 8.41, NULL);

-- 16. Ricavo id genere Funk
SELECT genere_id
FROM generi
WHERE nome = 'Funk';

-- 16b. Completo Purple Rain
UPDATE brani
SET anno = 1984, genere_id = 10
WHERE titolo = 'Purple Rain';

-- 17. Cancello Purple Rain
DELETE FROM brani
WHERE titolo = 'Purple Rain';

-- 18. Titolo e autore
SELECT b.titolo, a.nome
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id;

-- 19. Titolo, autore, genere e anno
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
INNER JOIN generi g ON b.genere_id = g.genere_id;

-- 20. Tutti i brani dopo il 1990, genere compreso quando disponibile
SELECT b.titolo, a.nome AS autore, g.nome AS genere, b.anno
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
LEFT JOIN generi g ON b.genere_id = g.genere_id
WHERE b.anno > 1990;
