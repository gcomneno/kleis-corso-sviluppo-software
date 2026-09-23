-- Database di riferimento per la Parte A.
-- La traccia non impone un DBMS specifico: qui usiamo MySQL/MariaDB
-- perché è coerente con il percorso PHP/PDO del corso.

CREATE DATABASE IF NOT EXISTS exam_books
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE exam_books;

CREATE TABLE IF NOT EXISTS libri (
    id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,

    -- ISBN è trattato come stringa:
    -- può contenere zeri iniziali e non viene usato per calcoli.
    isbn VARCHAR(20) NOT NULL,

    -- Il requisito certo della traccia è non accettare
    -- due libri con lo stesso titolo.
    titolo VARCHAR(255) NOT NULL,

    autore VARCHAR(255) NOT NULL,

    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT uq_libri_titolo UNIQUE (titolo)
) ENGINE=InnoDB;
