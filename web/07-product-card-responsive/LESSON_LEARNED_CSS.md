# 📘 Lessons Learned — Comprendere il CSS di `scheda-prodotto`

## 🎯 Obiettivo

Comprendere il significato di ogni sezione del foglio di stile CSS utilizzato per realizzare una semplice scheda prodotto responsive.
Più che memorizzare le proprietà CSS, l'obiettivo è imparare il **ragionamento** che porta alla costruzione di un layout moderno.
---

# 1. Reset iniziale

```css
* {
    box-sizing: border-box;
}
```

## Cosa fa

L'asterisco (`*`) seleziona tutti gli elementi della pagina.

La proprietà:

```css
box-sizing: border-box;
```

dice al browser di includere **padding** e **bordi** all'interno della larghezza e dell'altezza dichiarate.

## Perché è importante

Senza questa proprietà i calcoli delle dimensioni diventano meno intuitivi.

Con `border-box` il layout risulta molto più prevedibile.

È una delle regole più utilizzate nello sviluppo frontend moderno.

---

# 2. Stile globale della pagina

```css
body {
    margin:0;
    font-family:Arial, sans-serif;
    background:#f2f2f2;
}
```

## margin: 0

Rimuove il margine che il browser applica automaticamente.

## font-family

Imposta il carattere di tutta la pagina.

## background

Utilizza un grigio molto chiaro per mettere in risalto la scheda bianca.

---

# 3. Il contenitore principale

```css
.product-card
```

Questa classe rappresenta il componente principale.

Contiene:
- titolo
- immagine
- descrizione
- tabella
- pulsante

È il "contenitore" dell'intero componente.

---

# 4. Width e Max Width

```css
width:90%;
max-width:800px;
```

## width

La scheda occupa il 90% dello spazio disponibile.
Su smartphone si adatta automaticamente.

## max-width

Su monitor molto grandi la scheda non continua ad allargarsi.
Questo migliora la leggibilità.

---

# 5. Centratura automatica

```css
margin:30px auto;
```

## Verticalmente

Lascia 30 pixel sopra e sotto.

## Orizzontalmente

La parola:

```css
auto
```

fa calcolare automaticamente i margini laterali.

Il risultato è una scheda perfettamente centrata.

---

# 6. Padding

```css
padding:20px;
```

Crea spazio interno tra il contenuto e il bordo.

Senza padding il testo sarebbe "attaccato" ai bordi.

---

# 7. Sfondo e bordo

```css
background:white;
border:1px solid #ccc;
```

Lo sfondo bianco crea contrasto con il body grigio.

Il bordo sottile separa visivamente la scheda dal resto della pagina.

---

# 8. Titolo

```css
.product-card h1
```

Il titolo viene semplicemente centrato.

È un esempio di selettore contestuale:

la regola vale solo per gli `<h1>` contenuti nella scheda prodotto.

---

# 9. Gestione delle immagini

```css
width:100%;
max-height:320px;
object-fit:cover;
```

## width

L'immagine occupa tutta la larghezza della scheda.

## max-height

Evita immagini eccessivamente alte.

## object-fit

Questa proprietà è molto importante.

Con:

```css
object-fit:cover;
```

l'immagine riempie completamente il contenitore senza deformarsi.

Se necessario il browser ritaglia automaticamente le parti eccedenti.

È la stessa tecnica utilizzata da moltissimi social network.

---

# 10. Paragrafo descrittivo

```css
font-size:18px;
line-height:1.5;
```

Il testo diventa più leggibile grazie a:

- carattere leggermente più grande
- maggiore distanza tra le righe

---

# 11. Tabella

```css
width:100%;
border-collapse:collapse;
```

La tabella occupa tutta la larghezza disponibile.

La proprietà:

```css
border-collapse:collapse;
```

unisce i bordi delle celle eliminando il doppio bordo.

---

# 12. Celle della tabella

```css
.product-card th,
.product-card td
```

Lo stesso stile viene applicato sia alle celle dati (`td`) sia alle intestazioni (`th`).

In questo modo si evita di duplicare il codice.

---

# 13. Intestazione della tabella

```css
.product-card th
```

Solo le celle di intestazione ricevono uno sfondo grigio.

Questo rende immediatamente riconoscibile la prima riga.

---

# 14. Il link trasformato in pulsante

```css
display:inline-block;
padding:10px 15px;
background:#333;
color:white;
text-decoration:none;
```

Un normale collegamento HTML viene trasformato in un piccolo pulsante.

Le proprietà aggiungono:
- spazio interno
- sfondo
- testo bianco
- eliminazione della sottolineatura

---

# 🧠 Il concetto più importante

La vera lezione non riguarda le singole proprietà CSS.
Riguarda la progettazione.

Tutte le regole iniziano con:

```css
.product-card ...
```

Questo significa che il CSS è **incapsulato** all'interno del componente.
Le regole non modificano il resto della pagina.
È lo stesso principio della **Separation of Concerns** utilizzato nello sviluppo backend.
Ogni componente gestisce il proprio comportamento senza interferire con gli altri.

---

# 🚀 Conclusione

Questo esercizio introduce numerosi concetti fondamentali dello sviluppo frontend:
- Box Model
- Box Sizing
- Gestione dello spazio (margin e padding)
- Layout responsive
- Gestione delle immagini
- Tabelle HTML
- Selettori contestuali
- Componentizzazione del CSS
- Separation of Concerns applicata al frontend

Il risultato finale non è soltanto una pagina HTML con un po' di stile, ma un primo esempio di **componente riutilizzabile**,organizzato e facilmente estendibile!!
