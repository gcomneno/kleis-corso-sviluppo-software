# Lessons Learned — HTML/CSS Form Layout

## Idea generale

Questa lezione mette insieme due concetti importanti:

- layout CSS
- form HTML

Non stiamo più solo scrivendo tag HTML: stiamo iniziando a costruire piccole interfacce.

---

## Concetto chiave #1 — Layout con div

Il tag `div` è un contenitore generico.

Serve per:

- raggruppare elementi
- applicare classi CSS
- costruire sezioni della pagina

---

## Concetto chiave #2 — Classi CSS riutilizzabili

Esempi:

```css
.box
.left
.clear
.unmezzo
.unquarto
```

Le classi permettono di applicare lo stesso stile o comportamento a più elementi.

Questo aiuta a evitare duplicazione.

## Concetto chiave #3 — Float e clear

float:left permette di affiancare elementi orizzontalmente.

clear:both interrompe il flusso degli elementi flottanti e fa ripartire il layout da una nuova riga.

Questa tecnica oggi è considerata un po' old school, ma è utile per capire codice legacy.

## Concetto chiave #4 — Form HTML

Il tag principale è:

<form>

Una form raccoglie dati inseriti dall'utente.

Esempi tipici:

- login
- registrazione
- ricerca
- contatti
- invio dati a un backend

## Concetto chiave #5 — Input

Campi visti:

<input type="text">
<input type="radio">
<input type="checkbox">
<input type="reset">
<input type="submit">

Ogni type cambia il comportamento del campo.

Concetto chiave #6 — Select

<select>
    <option>...</option>
</select>

Permette all'utente di scegliere un valore da una lista.

## Concetto chiave #7 — Textarea

<textarea></textarea>

Serve per inserire testo più lungo rispetto a un normale input.

## Concetto chiave #8 — Label, id e name

Esempio:

<label for="nome">Nome:</label>
<input type="text" id="nome" name="nome">

id collega la label al campo
name identifica il dato quando la form viene inviata

Senza name, molti backend non ricevono il valore del campo.

## Concetto chiave #9 — Required

required="required"
Indica che un campo deve essere compilato prima dell'invio.
È una prima forma di validazione lato browser.

## Curiosità nerd

Una form HTML da sola NON salva dati.

La form può raccogliere dati e inviarli, ma per salvarli davvero serve un backend, cioè un programma lato server che riceve, valida e memorizza le informazioni.

La validazione può essere fatta anche lato frontend, per aiutare subito l’utente a correggere gli errori.

Però la validazione davvero obbligatoria deve stare anche lato backend, perché il backend può essere chiamato direttamente tramite API, senza passare dalla pagina HTML.

Regola d’oro:

Frontend = aiuta l’utente.
Backend = protegge il sistema.

## Morale finale

HTML costruisce la struttura.
CSS controlla l'aspetto.

Le form introducono il primo vero contatto tra:

- interfaccia utente
- dati
- futuro backend
