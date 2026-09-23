<?php

declare(strict_types=1);

require __DIR__ . '/include/db.php';

/*
 * La pagina principale ha due responsabilità visibili:
 * 1. mostrare la lista;
 * 2. mostrare il form di inserimento.
 *
 * La mutation NON viene eseguita qui: il form invia a salva.php.
 */

$stmt = $pdo->query(
    'SELECT id, isbn, titolo, autore
       FROM libri
   ORDER BY titolo ASC'
);
$libri = $stmt->fetchAll();

$message = $_GET['message'] ?? '';
$error = $_GET['error'] ?? '';

function e(string $value): string
{
    return htmlspecialchars($value, ENT_QUOTES | ENT_SUBSTITUTE, 'UTF-8');
}
?>
<!doctype html>
<html lang="it">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Libri da leggere</title>
    <link rel="stylesheet" href="assets/style.css">
</head>
<body>
<main class="page">
    <header>
        <p class="eyebrow">Simulazione esame finale</p>
        <h1>Libri da leggere</h1>
        <p>Piccola applicazione PHP con persistenza MySQL.</p>
    </header>

    <?php if ($message !== ''): ?>
        <p class="notice success"><?= e($message) ?></p>
    <?php endif; ?>

    <?php if ($error !== ''): ?>
        <p class="notice error"><?= e($error) ?></p>
    <?php endif; ?>

    <section aria-labelledby="lista-title">
        <h2 id="lista-title">Lista libri</h2>

        <?php if ($libri === []): ?>
            <p>Nessun libro presente.</p>
        <?php else: ?>
            <div class="table-wrap">
                <table>
                    <thead>
                    <tr>
                        <th>ISBN</th>
                        <th>Titolo</th>
                        <th>Autore</th>
                        <th>Azioni</th>
                    </tr>
                    </thead>
                    <tbody>
                    <?php foreach ($libri as $libro): ?>
                        <tr>
                            <td><?= e((string) $libro['isbn']) ?></td>
                            <td><?= e((string) $libro['titolo']) ?></td>
                            <td><?= e((string) $libro['autore']) ?></td>
                            <td>
                                <form action="elimina.php" method="post">
                                    <input
                                        type="hidden"
                                        name="id"
                                        value="<?= (int) $libro['id'] ?>"
                                    >
                                    <button class="danger" type="submit">
                                        Elimina
                                    </button>
                                </form>
                            </td>
                        </tr>
                    <?php endforeach; ?>
                    </tbody>
                </table>
            </div>
        <?php endif; ?>
    </section>

    <section aria-labelledby="nuovo-title">
        <h2 id="nuovo-title">Aggiungi un libro</h2>

        <form class="book-form" action="salva.php" method="post">
            <label>
                ISBN
                <input
                    name="isbn"
                    type="text"
                    maxlength="20"
                    required
                >
            </label>

            <label>
                Titolo
                <input
                    name="titolo"
                    type="text"
                    maxlength="255"
                    required
                >
            </label>

            <label>
                Autore
                <input
                    name="autore"
                    type="text"
                    maxlength="255"
                    required
                >
            </label>

            <button type="submit">Salva libro</button>
        </form>
    </section>
</main>
</body>
</html>
