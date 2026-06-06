# Lessons Learned — HTML Forms

## Idea generale

Le form HTML permettono all'utente di inserire dati.

Sono la base di:

- login
- registrazione
- ricerca
- invio dati
- contatti
- backend web

---

## Concetto chiave #1 — form

Tag principale:

```html
<form>
```

Una form raggruppa input e controlli.

Concetto chiave #2 — input

Esempi:

<input type="text">
<input type="password">
<input type="email">

Il tipo modifica il comportamento dell'input.

Concetto chiave #3 — label
<label for="username">

Le label migliorano:

accessibilità
leggibilità
UX

## Concetto chiave #4 — name

name="username"

L'attributo name identifica il dato inviato al server.

IMPORTANTISSIMO:
senza name, molti backend ignorano il valore.

## Concetto chiave #5 — button

<button type="submit">

Invia la form.

## Concetto chiave #6 — placeholder

placeholder="nome@dominio.it"

Mostra un suggerimento all'utente.

## Curiosità nerd

Le form HTML sono uno dei pilastri storici del web:

- prima di JavaScript avanzato e SPA moderne,
- gran parte delle applicazioni web funzionava tramite semplici form HTML.

## Morale finale

Le form introducono:

- input utente
- validazione
- invio dati
- interazione col backend

Sono uno dei mattoni fondamentali del web.
