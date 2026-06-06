# Spiegazione del Form di registrazione HTML/CSS

La pagina è costruita con un’idea semplice: una `form` centrale che contiene tutti i campi della registrazione. 
La `form` non è solo un contenitore estetico: semanticamente dice al browser “questi elementi fanno parte dello stesso invio dati”. 
Dentro ci sono campi testuali, una select, radio button, checkbox, textarea e pulsanti. Quindi è un esercizio completo sulle form HTML.

La scelta principale è stata questa:

```html
<form>
    ...
</form>
```

Qui non stiamo ancora usando `action` e `method`, perché al momento non abbiamo un backend. Quindi la form raccoglie dati, ma non li invia davvero a un server. È giusto così perché per ora l’obiettivo è capire struttura, campi e layout.

I campi `Nome`, `Cognome` e `Genere` sono organizzati con "righe" ripetute, da qui l'uso di una classe specifica:

```html
<div class="row">
    <label for="nome">Nome</label>
    <input type="text" id="nome" name="nome">
</div>
```

Questa scelta è pulita perché ogni riga ha una responsabilità chiara: una label e un campo. 
La `label` è collegata all’input tramite `for="nome"` e `id="nome"`. Questo non è solo “ordine” ma migliora anche accessibilità e usabilità. 
Se clicchi sulla label, il browser sa a quale campo si riferisce!

L’attributo `name` invece serve per il futuro backend:

```html
name="nome"
```

Quando un form viene inviato, il server riceve coppie tipo:

```text
nome = valore inserito
```

Quindi `id` serve soprattutto al browser e al CSS/JS, mentre `name` serve soprattutto all’invio dei dati. 
Questa è una distinzione molto importante!!

Per il campo `Genere` ho usato:

```html
<select>
    <option>...</option>
</select>
```

Perché qui l’utente deve scegliere tra valori predefiniti. 
È più corretto di un campo testo libero perché se chiedo il genere con una select, limito gli errori di input.

Per “Registrazione per” ho usato radio button:

```html
<input type="radio" name="registrazione">
```

I radio button sono corretti quando l’utente deve scegliere ééuna sola opzione** tra più possibilità. Il fatto che entrambi abbiano lo stesso `name` è fondamentale: è quello che li rende parte dello stesso gruppo. Se i `name` fossero diversi, il browser permetterebbe di selezionarli entrambi, e sarebbe sbagliato!

Per la privacy ho usato una checkbox:

```html
<input type="checkbox" id="privacy" name="privacy">
```

La checkbox è diversa dal radio button: qui non scegli tra alternative, ma confermi una condizione sì/no. 
Infatti “Accettazione Privacy” è proprio un caso da checkbox!!

La `textarea` è stata usata per le note perché un normale `input type="text"` è pensato per testi brevi. 
Le note invece possono essere più lunghe, quindi:

```html
<textarea id="note" name="note">Note</textarea>
```

Qui abbiamo messo “Note” come contenuto, perché volevo solo replicare la figura. In un progetto reale, probabilmente useremmo `placeholder="Note"` invece del testo dentro la textarea, così il campo resterebbe vuoto ma mostrerebbe un suggerimento.

Passiamo al CSS.

La prima scelta è stata:

```css
* {
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}
```

`box-sizing: border-box` è una scelta molto comoda: dice al browser che `width`, `padding` e `border` devono essere calcolati in modo più prevedibile. Senza questa regola, un elemento largo 500px con padding e bordo può diventare più largo di quanto ti aspetti. 
Con `border-box`, si  evitano mal di testa geometrici!

La `form` è centrata così:

```css
form {
    width: 900px;
    margin: 0 auto;
    padding: 10px 70px 25px 70px;
    border: 2px solid #009fe3;
}
```

`width: 900px` serve a replicare un layout fisso, come quello dell’immagine. Non è responsive, ma in questa esercitazione va bene: l’obiettivo non è ancora il mobile, è capire il posizionamento base.

`margin: 0 auto` centra orizzontalmente il blocco. È una tecnica classica: se un elemento ha una larghezza definita, `auto` sui margini laterali lo mette al centro!

`padding` crea spazio interno tra bordo della form e contenuto. Il bordo azzurro serve a visualizzare chiaramente il perimetro del modulo.

Le righe sono gestite così:

```css
.row {
    margin-bottom: 18px;
}
```

Ogni campo ha un po’ di distanza dal successivo. Non usare `<br>` per spaziare, perché quello è HTML usato male! gli spazi visuali sono responsabilità del CSS.

Le label hanno larghezza fissa:

```css
label {
    display: inline-block;
    width: 220px;
    font-size: 28px;
}
```

Questa è una scelta didattica molto chiara: tutte le label occupano lo stesso spazio, quindi gli input partono allineati. `inline-block` permette alla label di stare sulla stessa riga dell’input, ma anche di avere una larghezza.

Gli input principali sono larghi e alti:

```css
input[type="text"],
select {
    width: 500px;
    height: 55px;
    border: 2px solid #43a62a;
    font-size: 24px;
    padding: 5px;
}
```

Qui uso un selettore multiplo per evitare duplicazione. 
Stessa estetica per input testuali e select: bordo verde, altezza uguale, font grande. 

I radio button e la checkbox sono ingranditi:

```css
.radio-row input[type="radio"] {
    width: 42px;
    height: 42px;
}
```

e:

```css
.privacy input[type="checkbox"] {
    width: 30px;
    height: 30px;
}
```

Questa scelta serve solo a replicare l’immagine, dove i controlli sono molto grandi. Non è detto che sia sempre la scelta migliore in un sito reale, ma qui è corretta perché stiamo riproducendo un layout visivo preciso!!

La textarea ha larghezza piena:

```css
textarea {
    width: 100%;
    height: 170px;
    border: 2px solid #43a62a;
    text-align: center;
    padding-top: 65px;
}
```

`width: 100%` significa: prendi tutta la larghezza disponibile dentro la form. Il testo “Note” è centrato più o meno come nell’immagine usando `text-align: center` e `padding-top`.

I pulsanti sono stati sistemati così:

```css
.buttons {
    margin-top: 15px;
    text-align: center;
}
```

e poi:

```css
input[type="reset"],
input[type="submit"] {
    width: 300px;
    height: 60px;
    margin: 0 25px;
    background-color: #17687f;
    border: 3px solid #073044;
    color: white;
    font-size: 26px;
}
```

Qui il punto importante è la larghezza. Se fossero troppo grandi finirebbero uno sotto l’altro! 
Riducendo `width` e `margin`, rientrano nella larghezza disponibile e si affiancano correttamente.

Nel layout CSS non basta dire “voglio due elementi vicini”. Devi fare i conti con:

```text
larghezza elemento + margini + bordo + padding + spazio disponibile
```

Se la somma supera lo spazio, il secondo elemento va a capo! CSS non perdona!!

---

La scelta generale è stata quella di **replicare fedelmente l’immagine, non creare una form moderna super-fighissima!**.
Quindi ho volutamente evitato Flexbox, Grid, responsive design, CSS esterno, validazioni avanzate, JavaScript, backend, pippo, pluto e paperino!
Sarebbero strumenti migliori in un progetto reale, ma troppo avanti rispetto all’obiettivo di questa lezione!
Qui si voleva rinforzare solo HTML form base, label/input, CSS selectors, spacing, border, width, layout statico.
