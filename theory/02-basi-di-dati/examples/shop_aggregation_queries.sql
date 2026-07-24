-- Query esercitazione SQL — aggregazione
-- Lezione 4 — Basi di dati
-- Database: shop

SELECT titolo, anno
FROM brani
WHERE anno > 2010;

SELECT b.titolo, a.nome AS autore
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id;

SELECT titolo, anno
FROM brani
ORDER BY anno;

SELECT titolo, anno
FROM brani
ORDER BY anno DESC, titolo ASC;

SELECT titolo, durata_minuti
FROM brani
ORDER BY durata_minuti DESC
LIMIT 3;

SELECT titolo, anno
FROM brani
ORDER BY anno DESC
LIMIT 5;

SELECT DISTINCT anno
FROM brani
ORDER BY anno DESC;

SELECT COUNT(*) AS numero_brani
FROM brani;

SELECT COUNT(*) AS brani_anni90
FROM brani
WHERE anno BETWEEN 1990 AND 1999;

SELECT COUNT(*) AS totale, COUNT(anno) AS con_anno
FROM brani;

SELECT MIN(anno) AS piu_vecchio, MAX(anno) AS piu_recente
FROM brani;

SELECT ROUND(AVG(anno)) AS anno_medio
FROM brani;

SELECT COUNT(*) AS quanti
FROM brani
WHERE durata_minuti > 5;

SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY quanti DESC;

SELECT anno, COUNT(*) AS quanti
FROM brani
WHERE anno IS NOT NULL
GROUP BY anno
ORDER BY quanti DESC
LIMIT 5;

SELECT g.nome AS genere, MAX(b.anno) AS anno_piu_recente
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY anno_piu_recente DESC;

SELECT g.nome AS genere, COUNT(*) AS quanti
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
HAVING COUNT(*) >= 5
ORDER BY quanti DESC;

SELECT a.nome AS autore, COUNT(*) AS quanti
FROM brani b
INNER JOIN autori a ON b.autore_id = a.autore_id
GROUP BY a.nome
HAVING COUNT(*) > 1
ORDER BY quanti DESC, autore;

SELECT g.nome AS genere, COUNT(*) AS quanti, ROUND(AVG(b.anno)) AS anno_medio
FROM brani b
INNER JOIN generi g ON b.genere_id = g.genere_id
GROUP BY g.nome
ORDER BY anno_medio;
