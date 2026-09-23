<?php

declare(strict_types=1);

require __DIR__ . '/include/db.php';

if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    http_response_code(405);
    header('Allow: POST');
    exit('Metodo non consentito');
}

$id = filter_input(
    INPUT_POST,
    'id',
    FILTER_VALIDATE_INT,
    ['options' => ['min_range' => 1]]
);

if ($id === false || $id === null) {
    header('Location: index.php?error=' . rawurlencode('Identificativo non valido.'));
    exit;
}

$delete = $pdo->prepare(
    'DELETE FROM libri WHERE id = :id'
);
$delete->execute(['id' => $id]);

header('Location: index.php?message=' . rawurlencode('Libro eliminato.'));
exit;
