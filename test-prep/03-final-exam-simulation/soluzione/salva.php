<?php

declare(strict_types=1);

require __DIR__ . '/include/db.php';

if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    http_response_code(405);
    header('Allow: POST');
    exit('Metodo non consentito');
}

$isbn = trim((string) ($_POST['isbn'] ?? ''));
$titolo = trim((string) ($_POST['titolo'] ?? ''));
$autore = trim((string) ($_POST['autore'] ?? ''));

if ($isbn === '' || $titolo === '' || $autore === '') {
    header('Location: index.php?error=' . rawurlencode('Compilare tutti i campi.'));
    exit;
}

/*
 * Controllo applicativo:
 * serve per dare un messaggio comprensibile prima dell'INSERT.
 *
 * Il vincolo UNIQUE nel database rimane comunque la garanzia definitiva.
 */
$check = $pdo->prepare(
    'SELECT id
       FROM libri
      WHERE titolo = :titolo
      LIMIT 1'
);
$check->execute(['titolo' => $titolo]);

if ($check->fetch() !== false) {
    header('Location: index.php?error=' . rawurlencode('Titolo già presente.'));
    exit;
}

try {
    $insert = $pdo->prepare(
        'INSERT INTO libri (isbn, titolo, autore)
         VALUES (:isbn, :titolo, :autore)'
    );

    $insert->execute([
        'isbn' => $isbn,
        'titolo' => $titolo,
        'autore' => $autore,
    ]);
} catch (PDOException $exception) {
    /*
     * 23000 copre violazioni di integrità, incluso UNIQUE.
     * Manteniamo il messaggio semplice per l'utente.
     */
    if ($exception->getCode() === '23000') {
        header('Location: index.php?error=' . rawurlencode('Libro duplicato.'));
        exit;
    }

    throw $exception;
}

/*
 * Post/Redirect/Get:
 * evita il reinvio del form ricaricando la pagina.
 */
header('Location: index.php?message=' . rawurlencode('Libro aggiunto.'));
exit;
