# Lesson Learned — Basi di dati 02

## Argomento

Relazioni tra tabelle e prime operazioni SQL CRUD.

La lezione parte da un'esercitazione pratica: creare un database chiamato `MUSICA`, pensato per contenere le tabelle necessarie a un sito web che vende brani musicali.

## Punto di partenza

La prima idea è creare una tabella `Brani` con questi campi:

- `idprogressivo`
- `titolo`
- `autore`
- `anno`
- `duratamin`
- `genere`

Questa struttura funziona per iniziare, ma ha un difetto importante: il genere musicale viene scritto direttamente dentro ogni brano.

Esempio:

| idprogressivo | titolo | autore | anno | duratamin | genere |
|---:|---|---|---:|---:|---|
| 1 | Come mai | 883 | 1992 | 4.5 | POP |
| 2 | Brano rock 1 | Autore A | 1980 | 3.8 | ROCK |
| 3 | Brano rock 2 | Autore B | 1985 | 4.1 | ROCK |

Il problema nasce quando devo correggere o rinominare un genere.

Se decido di cambiare `ROCK` in `Rock 'n roll`, devo aggiornare tutti i brani che hanno quel valore.

Questo è scomodo e rischioso.

## Problema dei dati duplicati

Quando la stessa informazione viene ripetuta molte volte, aumentano i rischi:

- errori di battitura
- valori scritti in modi diversi
- aggiornamenti incompleti
- spreco di spazio
- difficoltà nel creare interfacce coerenti

Esempio di valori incoerenti:

- `ROCK`
- `rock`
- `Rock`
- `Rock and roll`
- `Rocn 'n roll`

Il database non può sapere automaticamente che questi valori indicano lo stesso concetto.

Per lui sono stringhe diverse.

## Miglioramento della struttura

La soluzione proposta nella lezione è separare i generi musicali in una tabella dedicata.

Si crea quindi una tabella `GeneriMusicali` con questi campi:

- `idgenere`
- `genere`

Poi nella tabella `Brani` non si salva più il nome del genere, ma l'identificativo del genere.

La tabella `Brani` diventa:

- `idprogressivo`
- `titolo`
- `autore`
- `anno`
- `duratamin`
- `idgenere`

La tabella `GeneriMusicali` contiene invece:

- `idgenere`
- `genere`

## Prima e dopo

Prima:

| titolo | autore | genere |
|---|---|---|
| Brano 1 | Autore A | ROCK |
| Brano 2 | Autore B | ROCK |
| Brano 3 | Autore C | POP |

Dopo:

Tabella `GeneriMusicali`:

| idgenere | genere |
|---:|---|
| 1 | POP |
| 2 | ROCK |

Tabella `Brani`:

| titolo | autore | idgenere |
|---|---|---:|
| Brano 1 | Autore A | 2 |
| Brano 2 | Autore B | 2 |
| Brano 3 | Autore C | 1 |

Ora il nome `ROCK` è scritto una sola volta.

Se voglio rinominarlo, modifico un solo record nella tabella `GeneriMusicali`.

## Relazione tra tabelle

Una relazione collega record di tabelle diverse.

In questo esempio:

- `GeneriMusicali.idgenere` identifica un genere
- `Brani.idgenere` indica a quale genere appartiene un brano

Quindi:

- `GeneriMusicali.idgenere` è chiave primaria
- `Brani.idgenere` è chiave esterna

La chiave esterna permette di collegare ogni brano al suo genere.

## Perché creare una tabella dei generi

I motivi principali sono due.

### 1. Coerenza dei dati

Se il genere viene scelto da una tabella dedicata, l'utente può usare un menu a discesa invece di scrivere il testo a mano.

Questo riduce errori come:

- `rock`
- `ROCK`
- `Rock and roll`
- `Rocn 'n roll`

Il dato resta uniforme.

### 2. Risparmio di spazio

Se ho 100.000 brani rock, salvare ogni volta la parola `ROCK` significa ripetere la stessa stringa migliaia di volte.

Salvare un numero come `2` occupa meno spazio.

Questo esempio mostra uno dei motivi per cui si usano le relazioni nei database relazionali.

## CRUD

CRUD è una sigla che indica le quattro operazioni fondamentali sui dati.

| Lettera | Significato | Operazione |
|---|---|---|
| C | Create | creare/inserire record |
| R | Read | leggere record |
| U | Update | aggiornare record |
| D | Delete | cancellare record |

Nel linguaggio SQL queste operazioni corrispondono spesso a:

| CRUD | SQL |
|---|---|
| Create | `INSERT` |
| Read | `SELECT` |
| Update | `UPDATE` |
| Delete | `DELETE` |

## INSERT

`INSERT` serve a inserire nuovi dati in una tabella.

```sql
INSERT INTO brani (titolo, autore, anno, duratamin, idgenere)
VALUES ('Come mai', '883', 1992, 4.5, 1);
```

Significato:

- aggiungi un nuovo record nella tabella `brani`
- valorizza i campi indicati
- usa i valori specificati nella riga `VALUES`

## SELECT

`SELECT` serve a leggere dati da una tabella.

```sql
SELECT titolo, autore, anno
FROM brani;
```

Questa query mostra solo titolo, autore e anno.

Per mostrare tutti i campi:

```sql
SELECT *
FROM brani;
```

L'asterisco significa: tutti i campi.

## WHERE

`WHERE` serve a filtrare i record.

```sql
SELECT *
FROM brani
WHERE anno = 1992;
```

Questa query mostra solo i brani dell'anno 1992.

`WHERE` è fondamentale perché permette di lavorare solo sui record che rispettano una certa condizione.

## DELETE

`DELETE` serve a cancellare record.

```sql
DELETE FROM brani
WHERE idprogressivo = 18;
```

Il punto importante è la condizione `WHERE`.

Senza `WHERE`, il comando diventa estremamente pericoloso:

```sql
DELETE FROM brani;
```

Questo comando cancella tutti i record della tabella.

Morale tecnica: `DELETE` senza `WHERE` è come dare una motosega accesa a una scimmia bendata.

## UPDATE

`UPDATE` serve a modificare record esistenti.

```sql
UPDATE brani
SET anno = 1979
WHERE idprogressivo = 30;
```

Anche qui `WHERE` è fondamentale.

Senza `WHERE`, la modifica si applica a tutti i record della tabella.

Esempio pericoloso:

```sql
UPDATE brani
SET anno = 1979;
```

Questo imposta l'anno 1979 su tutti i brani.

## LIKE

`LIKE` serve a cercare stringhe parziali.

Il carattere `%` è un jolly.

```sql
SELECT *
FROM brani
WHERE autore LIKE '%rossi%';
```

Questa condizione trova autori che contengono `rossi` in qualunque posizione.

Esempi intercettati:

- `Mario Rossi`
- `Rossi Pietro`
- `Mauro Rossini`

## IN

`IN` serve a verificare se un campo contiene uno dei valori indicati in una lista.

```sql
DELETE FROM brani
WHERE idprogressivo IN (25, 26, 28, 29);
```

Questa query cancella solo i brani con quegli identificativi.

`IN` è utile quando voglio lavorare su un insieme preciso di valori.

## WHERE con SELECT, UPDATE e DELETE

Le condizioni `WHERE` non servono solo con `SELECT`.

Si usano anche con:

- `UPDATE`
- `DELETE`

Esempi:

```sql
SELECT *
FROM brani
WHERE idgenere = 2;
```

```sql
UPDATE brani
SET idgenere = 3
WHERE idprogressivo = 10;
```

```sql
DELETE FROM brani
WHERE idprogressivo = 10;
```

Il concetto è sempre lo stesso: restringere l'operazione ai record corretti.

## Lezione chiave sulla progettazione

La struttura iniziale con il campo `genere` dentro `Brani` è semplice, ma fragile.

La struttura migliorata con due tabelle è più corretta:

- `Brani`
- `GeneriMusicali`

Il genere viene scritto una volta sola.

I brani lo richiamano tramite `idgenere`.

Questo è un primo esempio pratico di normalizzazione.

## Mappa mentale

Database `MUSICA`:

- contiene le tabelle del dominio musicale

Tabella `Brani`:

- contiene i brani musicali

Tabella `GeneriMusicali`:

- contiene l'elenco dei generi disponibili

Chiave primaria:

- identifica un record nella propria tabella

Chiave esterna:

- collega un record a un record di un'altra tabella

Relazione:

- collega `Brani.idgenere` a `GeneriMusicali.idgenere`

CRUD:

- Create → `INSERT`
- Read → `SELECT`
- Update → `UPDATE`
- Delete → `DELETE`

`WHERE`:

- limita l'operazione ai record che rispettano una condizione

`LIKE`:

- cerca testo parziale

`IN`:

- controlla se un valore è presente in una lista

## Errori da evitare

1. Ripetere la stessa informazione testuale in migliaia di record.
2. Salvare `genere` come testo libero quando esiste un elenco controllato di generi.
3. Dimenticare la clausola `WHERE` in `UPDATE`.
4. Dimenticare la clausola `WHERE` in `DELETE`.
5. Non distinguere chiave primaria e chiave esterna.
6. Pensare che una relazione sia solo un disegno: è un vincolo logico tra dati.
7. Usare `SELECT *` sempre, anche quando servono solo pochi campi.
8. Non controllare bene le condizioni con `LIKE` e `%`.

## Sintesi finale

La seconda lezione mostra il passaggio da una tabella semplice ma fragile a una struttura relazionale più pulita.

Separare i generi musicali in una tabella dedicata evita duplicazioni, migliora la coerenza dei dati e prepara l'applicazione a usare menu a discesa e controlli più sicuri.

Le operazioni CRUD sono la base del lavoro quotidiano sui database:

- inserire
- leggere
- aggiornare
- cancellare

La regola d'oro della lezione è semplice:

Prima progetta bene le tabelle, poi scrivi SQL con `WHERE` acceso e cervello collegato.
