# Kleis Software Lab — Percorso di apprendimento

Repository di esercitazioni sviluppate durante il corso di Sviluppatore Software.

Il repository include:

- C#
- HTML
- CSS
- basi web
- logica e problem solving

L'obiettivo NON è solo far funzionare il codice, ma:

- capire cosa si sta facendo
- organizzare il lavoro
- scrivere codice leggibile e riutilizzabile

---

## Ultimi aggiornamenti

- aggiunta validazione input con `TryParse`
- introduzione dei metodi riutilizzabili
- gestione errori e controlli semantici
- confronto tra C# e ANSI C
- introduzione dell’operatore ternario
- migliorata la struttura della solution e del repository
- introduzione generatore semplificato del codice fiscale italiano
- introduzione basi HTML e navigazione multipagina
- introduzione basi CSS e selettori
- introduzione HTML Forms e interazione utente base
- introduzione top-down design e decomposizione del problema
- introduzione refactoring e naming autoesplicativo
- introduzione separazione tra I/O e business logic
- introduzione al box model CSS
- introduzione a classi e id
- primi layout multi-colonna con float
- selettori CSS avanzati e scope degli stili
- form HTML/CSS con layout, select, radio, textarea e checkbox
- pre-test HTML/CSS a risposta multipla con soluzioni separate
- pre-test C# a risposta multipla con soluzioni separate

---

## Struttura

Il repository è organizzato in tre macro-aree:

- `csharp/` → esercitazioni e ripassi C#
- `web/` → esercitazioni HTML/CSS
- `test-prep/` → pre-test e materiali di ripasso
- `theory/` → appunti teorici, metodo, analisi e progettazione

Ogni esercitazione resta organizzata in modo indipendente:

- codice sorgente
- eventuali progetti `.csproj`
- file HTML/CSS
- note didattiche (`LESSONS_LEARNED`)

Questo permette di:

- separare lezioni, esercitazioni e test prep
- isolare i problemi
- evitare conflitti tra esercizi
- mantenere ordine nel tempo

---

## Teoria, metodo e progettazione

- [01-analisi-rischio](./theory/01-analisi-rischio)  
  Lezioni apprese sull'analisi del rischio

---

## Esercitazioni C#

- [01-type-inspector](./csharp/01-type-inspector)  
  Tipi base e ispezione dei valori

- [02-min-max](./csharp/02-min-max)  
  Logica condizionale e confronto

- [03-stringhe](./csharp/03-stringhe)  
  Stringhe, metodi, immutabilità, confronto con C

- [04-calcolatrice](./csharp/04-calcolatrice)  
  Input utente, validazione, metodi, gestione errori

- [05-triangolo](./csharp/05-triangolo)  
  Validazione semantica, metodi riutilizzabili, operatore ternario

- [06-codice-fiscale](./csharp/06-codice-fiscale)  
  Generatore semplificato del codice fiscale italiano

- [07-ripasso-array-top-down](./csharp/07-ripasso-array-top-down)  
  Array, statistiche, ricerca, top-down design e refactoring

- [08-gestione-voti-menu](./csharp/08-gestione-voti-menu)  
  Gestione voti classe con menu, array, metodi e validazione input

---

## HTML / Web Base

- [01-html-base](./web/01-html-base)  
  Struttura base HTML, link, liste, tabelle e path relativi

- [02-css-base](./web/02-css-base)  
  Selettori CSS, scope, padding, nesting e separazione struttura/stile

- [03-html-forms](./web/03-html-forms)  
  Form HTML, input, login, recupero password e UX base

- [04-css-layout](./web/04-css-layout)  
  Div, classi, id, box model, float e layout CSS

- [05-html-css-form-layout](./web/05-html-css-form-layout)  
  Layout CSS complessi e form di registrazione HTML

---

## Pre-test e materiali di ripasso

- [01-html-css](./test-prep/01-html-css)  
  Pre-test HTML/CSS a risposta multipla con soluzioni separate

- [02-csharp](./test-prep/02-csharp)  
  Pre-test C# a risposta multipla con soluzioni separate

## Approccio

Ogni esercizio segue alcune regole:

- separazione della logica
- validazione dell'input (mai fidarsi dell'utente)
- codice semplice prima di codice “furbo”
- commenti utili (non decorativi)
- progressione graduale della complessità
- metodi piccoli e responsabilità chiare
- naming leggibile e intenzionale

---

## Note

Questo repository è volutamente:

- semplice
- progressivo
- didattico

Non è codice “production-ready”, ma una base solida per arrivarci.

---

## Obiettivo finale

Passare da:

> codice che funziona

a:

> codice che funziona, ha senso ed è leggibile!
