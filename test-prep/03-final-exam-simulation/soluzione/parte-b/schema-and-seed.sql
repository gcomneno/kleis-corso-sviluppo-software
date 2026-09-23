-- Fixture ripetibile per la Parte B.
-- Serve soltanto a verificare la query della simulazione.

DROP DATABASE IF EXISTS exam_students;
CREATE DATABASE exam_students
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE exam_students;

CREATE TABLE Studenti (
    IdStudente INT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Cognome VARCHAR(100) NOT NULL
) ENGINE=InnoDB;

CREATE TABLE Esami (
    IdEsame INT PRIMARY KEY,
    IdStudente INT NOT NULL,
    DataEsame DATE NOT NULL,
    Esito INT NOT NULL,
    CONSTRAINT fk_esami_studenti
        FOREIGN KEY (IdStudente)
        REFERENCES Studenti(IdStudente)
) ENGINE=InnoDB;

INSERT INTO Studenti (IdStudente, Nome, Cognome) VALUES
(1, 'Marco', 'Verdi'),
(2, 'Lucia', 'Bianchi'),
(3, 'Alessandro', 'Neri');

INSERT INTO Esami (IdEsame, IdStudente, DataEsame, Esito) VALUES
(1, 1, '2024-12-10', 28),
(2, 2, '2024-12-12', 25),
(3, 1, '2024-12-12', 30),
(4, 3, '2024-12-16', 25);
