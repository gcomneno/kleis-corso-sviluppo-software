-- Parte B — soluzione di riferimento.
--
-- INNER JOIN è appropriata perché la richiesta riguarda
-- gli esami effettuati e ogni riga di Esami deve essere
-- associata allo studente tramite IdStudente.

SELECT
    s.Nome,
    s.Cognome,
    e.DataEsame,
    e.Esito
FROM Esami AS e
INNER JOIN Studenti AS s
    ON e.IdStudente = s.IdStudente
ORDER BY e.Esito ASC;
