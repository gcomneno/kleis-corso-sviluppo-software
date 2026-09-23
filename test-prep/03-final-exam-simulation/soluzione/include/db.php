<?php

declare(strict_types=1);

/*
 * Connessione PDO minimale.
 *
 * Scelta:
 * - credenziali da ambiente, non hard-coded;
 * - errori PDO come eccezioni;
 * - fetch associativo;
 * - emulated prepares disabilitati.
 */

$host = getenv('EXAM_DB_HOST') ?: '127.0.0.1';
$dbName = getenv('EXAM_DB_NAME') ?: 'exam_books';
$user = getenv('EXAM_DB_USER') ?: 'exam_user';
$password = getenv('EXAM_DB_PASSWORD');

if ($password === false) {
    throw new RuntimeException('EXAM_DB_PASSWORD non configurata.');
}

$dsn = sprintf(
    'mysql:host=%s;dbname=%s;charset=utf8mb4',
    $host,
    $dbName
);

$pdo = new PDO(
    $dsn,
    $user,
    $password,
    [
        PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
        PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
        PDO::ATTR_EMULATE_PREPARES => false,
    ]
);
