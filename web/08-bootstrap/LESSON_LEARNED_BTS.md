Il corso sta seguendo un percorso abbastanza classico:

```text
HTML
    ↓
CSS
    ↓
Responsive Design
    ↓
Bootstrap	<<===== NOI SIAMO QUI!
    ↓
JavaScript
    ↓
Backend
```

Abbiamo già imparato:
✅ Box Model
✅ `display: block`, `inline`, `inline-block`
✅ Flexbox
✅ Responsive Design
✅ Media Query
✅ Componentizzazione del CSS
✅ Layout a colonne

Bootstrap non inventa nuovi concetti: **incapsula quelli che conosci già** in classi CSS predefinite. 
È un framework front-end open source che fornisce componenti e un sistema di layout responsive basato su HTML, CSS e JavaScript.

Per esempio, oggi scrivi:
```css
.container {
    display: flex;
    justify-content: space-between;
}
```

Con Bootstrap diventa semplicemente:
```html
<div class="d-flex justify-content-between">
```

Stesso concetto.

---
Oppure oggi fai una media query:

```css
@media (min-width:768px){
    ...
}
```

Bootstrap ha già definito i breakpoint:
```text
sm
md
lg
xl
xxl
```

quindi scrivi direttamente:
```html
col-md-6
```

che significa:
> "Da tablet in poi occupa metà riga."
---

Oggi una card la costruisci così:
```html
<div class="prodotto">
```
più 40 righe di CSS.

Con Bootstrap:
```html
<div class="card">
```

e hai già:
- bordi
- ombre
- padding
- spaziature
- responsiveness
- tipografia

## Come studiarlo (e come NON studiarlo)

Molti principianti fanno questo errore:
> "Devo imparare tutte le classi Bootstrap."
No.
Le classi sono centinaia.

Quello che devi imparare è **la filosofia**.
La documentazione ufficiale in quest'ordine:

1. **Getting Started**
   - come si aggiunge Bootstrap a una pagina
   - CDN
   - struttura base

2. **Layout**
   - Containers
   - Grid
   - Breakpoints

3. **Utilities**
   - Margin (`m-*`)
   - Padding (`p-*`)
   - Display (`d-*`)
   - Flex (`d-flex`, `justify-content-*`, `align-items-*`)
   - Width (`w-*`)
   - Height (`h-*`)

4. **Components**
   - Buttons
   - Cards
   - Navbar
   - Forms
   - Tables
   - Alerts

5. **Helpers**
   - Colors
   - Text
   - Borders
   - Shadows

Questo 20% ti permette già di costruire la maggior parte delle interfacce.

| CSS puro                 | Bootstrap                |
| ------------------------ | ------------------------ |
| `display:flex`           | `d-flex`                 |
| `justify-content:center` | `justify-content-center` |
| `align-items:center`     | `align-items-center`     |
| `margin-top:3rem`        | `mt-5`                   |
| `padding:1rem`           | `p-3`                    |
| `width:100%`             | `w-100`                  |

È il modo migliore per non imparare Bootstrap "a memoria", ma per capire **che sta semplicemente traducendo il CSS che già conosci**.
