# Lesson Learned — Bootstrap Rewrite

## Obiettivo della lezione

Questa lezione non introduce nuovi componenti Bootstrap.

L'obiettivo è capire come prendere esercizi già realizzati con HTML e CSS tradizionale e riscriverli usando Bootstrap.

In pratica, non stiamo imparando “più Bootstrap”. Stiamo imparando a usare Bootstrap come strumento di migrazione:

- da layout manuali a griglie Bootstrap;
- da CSS custom a classi utility;
- da form scritte a mano a form standardizzate;
- da componenti improvvisati a componenti Bootstrap coerenti.

La parola chiave della lezione è:

> riscrivere senza reinventare.

---

## File realizzati

Durante la lezione sono stati realizzati questi file:

```text
web/09-bootstrap-rewrite/product-showcase-bootstrap.html
web/09-bootstrap-rewrite/book-detail-bootstrap.html
web/09-bootstrap-rewrite/registration-form-bootstrap.html
web/09-bootstrap-rewrite/LESSON_LEARNED_BOOTSTRAP_REWRITE.md
```

Sono stati usati asset nella cartella:

```text
web/09-bootstrap-rewrite/assets/
```

---

# Parte 1 — Vetrina libri con Bootstrap

## Obiettivo dell'esercizio

Il primo esercizio consisteva nel riprendere una vecchia vetrina responsive e riscriverla usando Bootstrap.

La traccia mostrava due versioni:

- layout mobile;
- layout desktop.

Abbiamo scelto una nuova ambientazione:

> una piccola casa editrice.

Il nome usato è:

```text
Cicellyn Edizioni
```

La scelta importante è stata non usare Bootswatch.

Abbiamo usato Bootstrap 5 default, aggiungendo solo un piccolo CSS di brand dove necessario.

---

## Struttura della pagina

La pagina vetrina è stata organizzata così:

```text
Header / Navbar
Hero semplice
Griglia libri
Sidebar
Footer
```

Il layout mobile diventa:

```text
header
hero
card
card
card
sidebar
footer
```

Il layout desktop diventa:

```text
HEADER

HERO

CARD CARD CARD

SIDEBAR

FOOTER
```

In Bootstrap questo tipo di struttura si ottiene ragionando per contenitori, righe e colonne.

---

## Concetto chiave: container, row, col

Nel CSS tradizionale si tende a pensare in termini di:

- larghezze manuali;
- float;
- margin;
- padding;
- media query scritte a mano.

Con Bootstrap si ragiona invece così:

```html
<div class="container">
  <div class="row">
    <div class="col">
      Contenuto
    </div>
  </div>
</div>
```

La regola mentale è:

- `container` limita e centra il contenuto;
- `row` crea una riga della griglia;
- `col` definisce una colonna;
- `g-*` gestisce lo spazio tra colonne e righe;
- `col-12`, `col-md-*`, `col-lg-*` permettono layout responsive.

Esempio:

```html
<div class="row g-4">
  <div class="col-12 col-lg-8">
    Catalogo libri
  </div>

  <aside class="col-12 col-lg-4">
    Sidebar
  </aside>
</div>
```

Questo significa:

- su mobile ogni blocco occupa tutta la larghezza;
- su desktop il contenuto principale e la sidebar si affiancano.

---

## Hero section: semplificare è meglio

All'inizio la hero era più elaborata.

Poi l'abbiamo semplificata perché l'obiettivo della lezione non era creare una landing page commerciale, ma capire la migrazione Bootstrap.

La versione migliore è una hero leggibile:

```html
<section class="py-5 bg-light border-bottom">
  <div class="container">
    <h1 class="display-5 fw-bold">Cicellyn Edizioni</h1>
    <p class="lead mb-0">
      Una piccola casa editrice dedicata a storie, saggi e visioni narrative.
    </p>
  </div>
</section>
```

Classi importanti:

- `py-5` aggiunge padding verticale;
- `bg-light` crea uno sfondo chiaro;
- `border-bottom` separa visivamente la sezione;
- `display-5` rende il titolo grande;
- `fw-bold` rende il testo grassetto;
- `lead` rende il paragrafo più evidente;
- `mb-0` rimuove il margine inferiore.

Lesson learned:

> Bootstrap permette di costruire sezioni pulite usando poche classi semantiche e leggibili.

---

## Card tutte della stessa altezza

Problema incontrato:

> le card avevano altezze diverse.

Soluzione Bootstrap:

```html
<div class="card h-100">
  ...
</div>
```

`h-100` forza la card a occupare tutta l'altezza disponibile nella colonna.

Per rendere anche il contenuto interno più ordinato:

```html
<div class="card-body d-flex flex-column">
  ...
  <a href="#" class="btn btn-primary mt-auto">Scopri</a>
</div>
```

Classi importanti:

- `d-flex` trasforma il body in contenitore flessibile;
- `flex-column` dispone gli elementi in verticale;
- `mt-auto` spinge il bottone verso il fondo della card.

Lesson learned:

> per allineare i bottoni in basso nelle card non serve CSS custom: si può usare Flexbox tramite classi Bootstrap.

---

## Immagini delle card: cover vs contain

Problema incontrato:

> le copertine venivano tagliate.

La prima soluzione usava:

```html
class="card-img-top object-fit-cover"
style="height: 320px;"
```

`object-fit-cover` riempie il contenitore, ma taglia l'immagine se le proporzioni non coincidono.

Per le copertine dei libri è meglio:

```html
<img src="assets/books/primo-cerchio.png"
     class="card-img-top object-fit-contain bg-light p-2"
     style="height: 360px;"
     alt="Il Primo Cerchio">
```

Differenza importante:

- `object-fit-cover` riempie e taglia;
- `object-fit-contain` mostra tutta l'immagine;
- `bg-light` evita vuoti visivi brutti intorno all'immagine;
- `p-2` aggiunge un piccolo respiro.

Lesson learned:

> per immagini decorative o hero può andare bene `cover`; per copertine, loghi e immagini informative è quasi sempre meglio `contain`.

---

## Sidebar

La sidebar contiene:

- ricerca;
- categorie;
- newsletter.

In Bootstrap può essere realizzata con una `card` o con blocchi separati.

Esempio concettuale:

```html
<aside class="col-12 col-lg-3">
  <div class="card">
    <div class="card-body">
      <h2 class="h4">Cerca e filtra</h2>
      ...
    </div>
  </div>
</aside>
```

Lesson learned:

> la sidebar non deve essere trattata come elemento speciale: è semplicemente una colonna della griglia.

---

## Logo nella navbar: mantenere le proporzioni

Problema incontrato:

> il logo risultava deformato.

Causa:

```html
<img src="..." width="36" height="36">
```

Imporre sia larghezza sia altezza a un'immagine rettangolare la deforma.

Soluzione:

```html
<img src="assets/logo-cicellyn-edizioni.png"
     alt="Cicellyn Edizioni"
     style="height: 56px; width: auto;">
```

Lesson learned:

> per un logo in navbar conviene fissare solo l'altezza e lasciare `width: auto`.

---

## Colore di brand senza Bootswatch

Bootstrap default usa il blu per `primary`.

Per creare un bordeaux coerente con il logo abbiamo aggiunto un piccolo CSS custom:

```css
:root {
  --brand-bordeaux: #8b1e2d;
  --brand-bordeaux-dark: #6f1724;
}

.text-brand {
  color: var(--brand-bordeaux) !important;
}
```

E per il bottone:

```css
.btn-brand {
  --bs-btn-color: #fff;
  --bs-btn-bg: var(--brand-bordeaux);
  --bs-btn-border-color: var(--brand-bordeaux);
  --bs-btn-hover-color: #fff;
  --bs-btn-hover-bg: var(--brand-bordeaux-dark);
  --bs-btn-hover-border-color: var(--brand-bordeaux-dark);
}
```

Lesson learned:

> personalizzare Bootstrap non significa riscriverlo. È meglio creare poche classi di brand mirate.

---

# Parte 2 — Scheda libro Bootstrap

## Obiettivo dell'esercizio

Dopo la vetrina è stata creata una pagina dettaglio libro:

```text
book-detail-bootstrap.html
```

La pagina contiene:

- navbar;
- intestazione;
- copertina;
- titolo;
- descrizione;
- dettagli editoriali;
- bottoni;
- altri libri della casa editrice;
- footer.

---

## Layout principale della scheda libro

La struttura base usa una riga con due colonne:

```html
<div class="row g-4 align-items-start">
  <div class="col-md-5 col-lg-4">
    Copertina
  </div>

  <div class="col-md-7 col-lg-8">
    Informazioni libro
  </div>
</div>
```

Significato:

- su mobile le colonne vanno una sotto l'altra;
- da `md` in poi si affiancano;
- la copertina occupa meno spazio;
- il contenuto testuale occupa più spazio.

Lesson learned:

> una pagina dettaglio è spesso una griglia a due colonne: media a sinistra, contenuto a destra.

---

## Box informativi

I dati come autore, genere, formato e disponibilità sono stati trasformati in piccoli riquadri.

Esempio:

```html
<div class="border rounded p-3 h-100">
  <h3 class="h6 text-uppercase text-muted">Autore</h3>
  <p class="mb-0">Giancarlo Cicellyn Comneno</p>
</div>
```

Classi importanti:

- `border` aggiunge il bordo;
- `rounded` arrotonda gli angoli;
- `p-3` aggiunge padding interno;
- `h-100` uniforma l'altezza;
- `text-uppercase` trasforma il testo in maiuscolo;
- `text-muted` attenua il colore;
- `mb-0` elimina margini inutili.

Lesson learned:

> molti piccoli blocchi grafici possono essere creati solo con utility Bootstrap.

---

## Sezione “Altri libri”

Problema emerso:

> la sezione “Altri libri” proponeva anche il libro attualmente aperto.

Questo è sbagliato dal punto di vista UX.

Se l'utente è nella pagina di un libro, la sezione correlata deve proporre alternative o contenuti affini, non duplicare la pagina corrente.

Lesson learned:

> nelle sezioni “correlati”, “altri prodotti” o “potrebbe interessarti”, bisogna escludere l'elemento corrente.

Nel nostro caso il problema è stato riconosciuto confrontando la copertina del libro aperto con le card della sezione correlata.

---

# Parte 3 — Form di registrazione Bootstrap

## Obiettivo dell'esercizio

Il secondo esercizio ufficiale consisteva nel riprendere la vecchia form:

```text
web/05-html-css-form-layout/esercizio-5-form-registrazione.html
```

e riscriverla usando Bootstrap.

La traccia del docente mostrava una form semplice, senza navbar e senza ambientazione Cicellyn Edizioni.

Quindi la form Bootstrap finale è autonoma e didattica.

File finale:

```text
web/09-bootstrap-rewrite/registration-form-bootstrap.html
```

---

## Struttura della vecchia form

La vecchia form usava CSS manuale:

```css
form {
  padding: 1%;
  margin: 30 auto;
  width: 40%;
  border: 2px solid blue;
}
```

e classi custom:

```css
.inputop {
  width: 60%;
  float: right;
}
```

Problema didattico:

- `float` oggi è inadatto per costruire layout di form;
- le larghezze fisse sono poco responsive;
- il CSS custom cresce subito;
- l'allineamento label/input è fragile.

---

## Riscrittura Bootstrap

La form Bootstrap usa:

```html
<form class="registration-box mx-auto border border-2 border-primary bg-white p-4">
```

Classi importanti:

- `mx-auto` centra orizzontalmente;
- `border` aggiunge il bordo;
- `border-2` aumenta lo spessore;
- `border-primary` applica il blu Bootstrap;
- `bg-white` imposta sfondo bianco;
- `p-4` aggiunge padding interno.

Abbiamo mantenuto un micro CSS solo per la larghezza massima:

```css
.registration-box {
  max-width: 640px;
}
```

Lesson learned:

> Bootstrap riduce molto il CSS custom, ma non lo elimina sempre. Piccoli CSS locali sono accettabili quando servono a rifinire il layout.

---

## Allineare label e input

Nel vecchio esercizio l'allineamento era fatto con `float`.

Con Bootstrap si usa la griglia:

```html
<div class="row align-items-center mb-3">
  <label for="nome" class="col-sm-4 col-form-label fs-5">Nome</label>
  <div class="col-sm-8">
    <input type="text" id="nome" name="nome" class="form-control">
  </div>
</div>
```

Significato:

- `row` crea una riga;
- `align-items-center` centra verticalmente label e input;
- `col-sm-4` assegna 4 colonne alla label;
- `col-sm-8` assegna 8 colonne all'input;
- `form-control` applica lo stile Bootstrap al campo;
- `mb-3` aggiunge margine inferiore;
- `fs-5` aumenta la dimensione del testo.

Lesson learned:

> per sostituire `float: right`, usare la griglia Bootstrap.

---

## Input, select e textarea

Bootstrap ha classi specifiche per i campi.

Input testuale:

```html
<input type="text" class="form-control">
```

Select:

```html
<select class="form-select">
  ...
</select>
```

Textarea:

```html
<textarea class="form-control"></textarea>
```

Lesson learned:

> non tutti i campi usano la stessa classe: `input` e `textarea` usano `form-control`, mentre `select` usa `form-select`.

---

## Radio e checkbox

Radio e checkbox sono gestiti con `form-check`.

Esempio radio:

```html
<div class="form-check">
  <input type="radio" class="form-check-input" id="singolo" name="quantita">
  <label class="form-check-label" for="singolo">Singolo</label>
</div>
```

Checkbox:

```html
<div class="form-check">
  <input type="checkbox" class="form-check-input" id="privacy" required>
  <label class="form-check-label" for="privacy">Accettazione Privacy</label>
</div>
```

Lesson learned:

> radio e checkbox non vanno trattati come input testuali: Bootstrap usa una struttura dedicata.

---

## Validazione Bootstrap

Abbiamo aggiunto la validazione “alla maniera Bootstrap”.

La form usa:

```html
<form class="needs-validation" novalidate>
```

Significato:

- `needs-validation` identifica la form da validare;
- `novalidate` disattiva la validazione grafica nativa del browser;
- Bootstrap mostra i propri feedback dopo il submit.

I campi obbligatori hanno `required`:

```html
<input type="text" class="form-control" required>
```

Il messaggio di errore usa:

```html
<div class="invalid-feedback">
  Inserisci il nome.
</div>
```

Lo script finale:

```html
<script>
  (() => {
    "use strict";

    const forms = document.querySelectorAll(".needs-validation");

    Array.from(forms).forEach((form) => {
      form.addEventListener("submit", (event) => {
        if (!form.checkValidity()) {
          event.preventDefault();
          event.stopPropagation();
        }

        form.classList.add("was-validated");
      }, false);
    });
  })();
</script>
```

Lesson learned:

> Bootstrap non valida magicamente da solo: usa le API HTML5 del browser e aggiunge classi CSS per mostrare feedback coerenti.

---

## Errore corretto: invalid-feedback sempre visibile

Problema incontrato:

> il messaggio di errore sotto “Registrazione per” era visibile subito.

Causa:

```html
<div class="invalid-feedback d-block">
```

`d-block` forza il messaggio a essere sempre visibile.

Soluzione:

```html
<div class="invalid-feedback">
```

Lesson learned:

> attenzione alle utility Bootstrap: una classe come `d-block` può sovrascrivere il comportamento previsto del componente.

---

## Radio con valore di default

Problema incontrato:

> la sezione radio partiva senza selezione e quindi risultava subito non valida.

Soluzione:

```html
<input type="radio"
       id="singolo"
       name="quantita"
       value="solo"
       class="form-check-input"
       required
       checked>
```

Abbiamo selezionato `Singolo` di default.

Inoltre il secondo radio non ha bisogno di `required`:

```html
<input type="radio"
       id="gruppo"
       name="quantita"
       value="multi"
       class="form-check-input">
```

Lesson learned:

> in un gruppo radio basta un solo `required`, perché la validazione riguarda il gruppo con lo stesso `name`.

---

# Mappa mentale della migrazione HTML/CSS → Bootstrap

Quando si riscrive una pagina vecchia in Bootstrap, conviene seguire questo ordine:

## 1. Individuare i blocchi principali

Esempio:

```text
header
main
section
form
footer
sidebar
card
```

Prima si riconoscono i blocchi, poi si traducono.

---

## 2. Sostituire il layout manuale

CSS vecchio:

```css
width: 40%;
margin: 30 auto;
float: right;
```

Bootstrap:

```html
<div class="container">
  <div class="row justify-content-center">
    <div class="col-12 col-md-8 col-lg-6">
      ...
    </div>
  </div>
</div>
```

---

## 3. Sostituire i controlli form

CSS/HTML manuale:

```html
<input class="inputop border">
```

Bootstrap:

```html
<input class="form-control">
```

---

## 4. Usare utility Bootstrap per spaziatura e bordi

CSS vecchio:

```css
padding-bottom: 10px;
border: 2px solid blue;
```

Bootstrap:

```html
<div class="mb-3 border border-2 border-primary p-4">
```

---

## 5. Aggiungere poco CSS custom solo quando serve

Il CSS custom è accettabile per:

- colore di brand;
- altezza immagine;
- larghezza massima locale;
- piccoli aggiustamenti non coperti bene dalle utility.

Non va usato per riscrivere da zero quello che Bootstrap offre già.

---

# Errori da evitare

## 1. Usare Bootstrap ma continuare a ragionare in CSS vecchio

Errore:

```css
float: right;
width: 60%;
```

Meglio:

```html
<div class="row">
  <label class="col-sm-4">Nome</label>
  <div class="col-sm-8">
    <input class="form-control">
  </div>
</div>
```

---

## 2. Usare `object-fit-cover` sulle copertine

Per le copertine dei libri è meglio non tagliare.

Meglio:

```html
object-fit-contain
```

---

## 3. Deformare i loghi

Errore:

```html
<img width="36" height="36">
```

Meglio:

```html
<img style="height: 56px; width: auto;">
```

---

## 4. Forzare messaggi di validazione

Errore:

```html
<div class="invalid-feedback d-block">
```

Meglio:

```html
<div class="invalid-feedback">
```

---

## 5. Confondere esercizi diversi

La form di registrazione non doveva usare il branding Cicellyn Edizioni.

Lesson learned importante:

> quando si migra un esercizio, rispettare il contesto originale della traccia. Non tutto deve diventare parte dello stesso mini-sito.

---

# Conclusione

Questa lezione ha mostrato che Bootstrap non serve solo a “fare pagine belle velocemente”.

Serve soprattutto a:

- riconoscere pattern ricorrenti;
- ridurre CSS ripetitivo;
- costruire layout responsive;
- uniformare form e componenti;
- migrare codice vecchio in modo più ordinato.

La competenza vera non è ricordare mille classi Bootstrap.

La competenza vera è guardare un vecchio HTML/CSS e chiedersi:

> quale parte di questo codice è già risolta da Bootstrap?

Quando si risponde bene a questa domanda, la migrazione diventa molto più semplice.
