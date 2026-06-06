# Lessons Learned — CSS Layout

## Idea generale

HTML definisce la struttura della pagina.

CSS definisce:
- aspetto
- spaziature
- colori
- disposizione degli elementi

Questa lezione introduce i primi concetti necessari per costruire veri layout web.

---

## Concetto chiave #1 — DIV

Il tag `div` è un contenitore generico.

Serve per:
- raggruppare elementi
- applicare stili CSS
- costruire layout

---

## Concetto chiave #2 — Classi CSS

Le classi permettono di riutilizzare uno stile su più elementi.

---

## Concetto chiave #3 — ID CSS

Un ID dovrebbe identificare un solo elemento della pagina.

---

## Concetto chiave #4 — Box Model

Ogni elemento HTML è composto da:

- contenuto
- padding
- bordo
- margine

---

## Concetto chiave #5 — Selettori nidificati

Permettono di applicare stili solo a elementi presenti in uno specifico contesto.

---

## Concetto chiave #6 — Scope dei selettori

Esempio: `table a` applica lo stile soltanto ai link presenti dentro una tabella.

---

## Concetto chiave #7 — Layout a colonne

Uso di `float:left` per affiancare elementi.

---

## Concetto chiave #8 — Clear

Uso di `clear: both` per interrompere il flusso dei float.

---

## Curiosità nerd

Oggi Flexbox e Grid hanno sostituito gran parte degli utilizzi di float, ma conoscere float resta utile per comprendere e mantenere codice legacy.

---

## Morale finale

HTML descrive la struttura.

CSS descrive la presentazione.
