# Lessons Learned — CSS Base

## Idea generale

CSS serve a definire:

- stile
- colori
- spaziature
- layout
- aspetto grafico

HTML descrive la struttura.
CSS descrive l'aspetto.

---

## Concetto chiave #1 — Separazione delle responsabilità

HTML:

- contenuto
- struttura

CSS:

- presentazione grafica

---

## Concetto chiave #2 — Selettori

Esempi:

```css
p
ul
li
```

Permettono di selezionare elementi HTML specifici.

Concetto chiave #3 — Selettore universale

* {
    font-size: 15px;
}

Il simbolo * seleziona TUTTI gli elementi.

Concetto chiave #4 — Scope e nesting

Esempio:

p ul li

Questo selettore NON prende tutti gli <li>.

Prende SOLO:

gli <li>
dentro una <ul>
dentro un <p>

Concetto importantissimo:
lo stile può dipendere dal contesto.

Concetto chiave #5 — Padding
padding: 10px 0;

Il padding rappresenta lo spazio INTERNO di un elemento.

Differenza:

padding → spazio interno
margin → spazio esterno
Concetto chiave #6 — nth-of-type
p:nth-of-type(2)

Permette di selezionare elementi specifici in base alla posizione.

Curiosità nerd

Prima del CSS molti stili venivano scritti direttamente nell'HTML:

<font color="red">

Oggi questa pratica è considerata obsoleta.

Morale finale

CSS introduce:

contesto
selezione
ereditarietà
separazione struttura/stile

Ed è uno dei pilastri fondamentali del web moderno.
