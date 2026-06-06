# Lessons Learned — HTML Base

## Idea generale

HTML NON è un linguaggio di programmazione.

HTML serve a descrivere:
- struttura
- contenuto
- organizzazione di una pagina web

---

## Concetto chiave #1 — Struttura documento

Tag principali:
- `<html>`
- `<head>`
- `<body>`

---

## Concetto chiave #2 — Tag testuali

Tag usati:
- `<b>`
- `<i>`
- `<u>`
- `<strong>`
- `<em>`

Nota:
oggi si preferiscono spesso i tag semantici (accessibilità + SEO):
- `<strong>`
- `<em>`

---

## Concetto chiave #3 — Liste

Liste non ordinate:
- `<ul>`

Liste ordinate:
- `<ol>`

Elementi:
- `<li>`

---

## Concetto chiave #4 — Link

Uso del tag:

```html
<a href="...">
```

Differenza:
- `target="_self"` → stessa pagina (default)
- `target="_blank"` → nuova scheda

---

## Concetto chiave #5 — Path relativi

Esempio:

```text
viaggi/europa/europa.html
```

I path relativi sono fondamentali:
- HTML
- Linux
- backend
- Git
- server web

---

## Concetto chiave #6 — Tabelle

Tag principali:
- `<table>` → tabella
- `<tr>` → row (riga)
- `<td>` → data (cella dati)
- `<th>` → header (intestazione)

Le tabelle servono a rappresentare dati strutturati in:
- righe
- colonne

Esempio:

```html
<table border="1">
    <tr>
        <th>Nome</th>
        <th>Età</th>
    </tr>

    <tr>
        <td>Giancarlo</td>
        <td>99</td>
    </tr>
</table>
```

Curiosità storica:
nei primi anni del web le tabelle venivano spesso usate anche per costruire il layout completo dei siti web.

Oggi questa pratica è considerata "old school":
per il layout si usa CSS.

---

## Concetto chiave #7 — colspan e rowspan

Le tabelle HTML permettono anche di unire celle.

Attributi principali:
- `colspan` → unisce più colonne
- `rowspan` → unisce più righe

Esempio con `colspan`:

```html
<table border="1">
    <tr>
        <th colspan="2">Anagrafica</th>
    </tr>

    <tr>
        <td>Nome</td>
        <td>Giancarlo</td>
    </tr>
</table>
```

In questo caso:
`colspan="2"` dice alla cella di occupare 2 colonne.

Esempio con `rowspan`:

```html
<table border="1">
    <tr>
        <td rowspan="2">Italia</td>
        <td>Roma</td>
    </tr>

    <tr>
        <td>Milano</td>
    </tr>
</table>
```

Qui:
`rowspan="2"` occupa 2 righe verticalmente.

---

## Curiosità nerd

Molti tag:

```html
<br/>
```

venivano usati per creare spazi verticali.

Oggi questa pratica è considerata "old school":
layout e spaziature vengono gestiti tramite CSS.

---

## Morale finale

HTML descrive:
- contenuto
- struttura

HTML NON descrive:
- stile avanzato
- logica
- comportamento dinamico
