# Lesson learned · Bootstrap 5

## 01 · Setup minimo Bootstrap

Cose che non sapevo bene:

- Bootstrap è un set di classi CSS già pronte.
- Per il comportamento responsive serve il meta tag viewport.
- Il CSS di Bootstrap va caricato nel `<head>`, prima di eventuali CSS personalizzati.
- Bootstrap 5 lavora con approccio mobile-first.
- Bootstrap va usato tramite classi HTML, non “invocato” da JavaScript.

## 02 · Container

Cose che non sapevo bene:

- `.container` serve a centrare e ordinare il contenuto nella pagina.
- `.container` non crea un effetto grafico vistoso: gestisce larghezze e margini.
- Senza `.container`, il contenuto può partire troppo vicino ai bordi.
- Bootstrap ragiona molto per blocchi/contenitori prima ancora che per singoli componenti.

## 03 · Spacing utilities

Cose che non sapevo bene:

- Bootstrap permette di gestire margini e padding tramite classi già pronte.
- `mt-*` gestisce il margine superiore.
- `mb-*` gestisce il margine inferiore.
- `p-*` gestisce il padding interno su tutti i lati.
- Le classi di spacing aiutano a evitare CSS custom prematuro.
- `border` è utile per visualizzare meglio i limiti di un box durante gli esercizi.

## 04 · Buttons

Cose che non sapevo bene:

- I bottoni Bootstrap usano una classe base e una classe variante.
- `btn` definisce il comportamento/stile base del bottone.
- `btn-primary`, `btn-secondary`, `btn-success`, `btn-danger` definiscono la variante visiva.
- La variante comunica anche un significato: azione principale, secondaria, positiva, pericolosa.
- Senza `btn`, la variante da sola non basta per ottenere un vero bottone Bootstrap.

## Concetto core · Classi componibili

Cose che non sapevo bene:

- Bootstrap non va capito come una raccolta casuale di classi CSS.
- Bootstrap usa classi piccole, specializzate e componibili.
- Ogni classe aggiunge un pezzo di comportamento visivo o strutturale.
- Una classe può definire il componente base, per esempio `btn`.
- Un'altra classe può definire una variante, per esempio `btn-primary`.
- Altre classi possono aggiungere spacing, layout, bordi, dimensioni o stati.
- Questo approccio evita classi monolitiche troppo specifiche.
- Il vantaggio è poter costruire interfacce combinando mattoncini coerenti.
- Capire questa logica è più importante che memorizzare tutte le classi.
- Bootstrap è mobile-first e class-composition oriented: prima si capisce la filosofia, poi si impara il catalogo.

## Metodo · Playground ed esempi stabili

Regola operativa:

- `index.html` è il playground corrente e può essere sovrascritto durante gli esercizi.
- `examples/` contiene esempi stabili da conservare.
- Un esempio va salvato separatamente solo quando rappresenta un concetto importante.
- Non conviene creare un nuovo file per ogni micro-variazione.
- Conviene creare un nuovo file quando l'esempio aiuta a ricordare un concetto core o un confronto importante.

🏷️ Tags: LeLe-Worthy, Workflow, Mental-Model

## 05 · Container vs container-fluid

Cose che non sapevo bene:

- `.container` centra il contenuto e gli assegna una larghezza massima.
- `.container-fluid` occupa tutta la larghezza disponibile della finestra.
- `.container` è utile per pagine ordinate e contenuti centrali.
- `.container-fluid` è utile per sezioni larghe, dashboard, hero section o layout a tutta pagina.
- La scelta tra `container` e `container-fluid` è una scelta di layout, non di decorazione.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Mental-Model

## 06 · Grid base: row e col

Cose che non sapevo bene:

- La griglia Bootstrap si costruisce con `container`, `row` e `col`.
- `container` definisce l'area ordinata della pagina.
- `row` definisce una riga della griglia.
- `col` definisce una colonna dentro quella riga.
- Più colonne `.col` nella stessa riga si dividono lo spazio in modo uguale.
- La griglia serve a costruire layout, non solo ad allineare contenuti.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Grid, Mental-Model

## 07 · Grid a 12 colonne

Cose che non sapevo bene:

- La griglia Bootstrap divide idealmente ogni riga in 12 colonne.
- Le 12 colonne sono una misura logica, non linee visibili automaticamente.
- `col-6` occupa metà riga.
- `col-4` occupa un terzo della riga.
- `col-8` occupa due terzi della riga.
- `col-3` occupa un quarto della riga.
- La somma delle colonne nella stessa riga dovrebbe idealmente arrivare a 12.
- Questo rende facile costruire layout proporzionali senza scrivere CSS custom.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Grid, Mental-Model

## 08 · Responsive grid e breakpoint

Cose che non sapevo bene:

- Bootstrap permette di cambiare layout in base alla larghezza dello schermo.
- `col-12` è il comportamento base: su schermi piccoli occupa tutta la riga.
- `col-md-6` significa: da schermo medio in su occupa 6 colonne su 12.
- Le classi con breakpoint sono additive: valgono dal breakpoint indicato in su.
- Bootstrap usa una logica mobile-first: prima si definisce il comportamento per schermi piccoli, poi si aggiungono regole per schermi più grandi.
- Con `col-12 col-md-6` posso creare card impilate su mobile e affiancate su desktop senza scrivere CSS custom.
- Questo rende il responsive design molto più rapido e leggibile.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Responsive, Grid, Mobile-First, Mental-Model

## 09 · Breakpoint columns

Cose che non sapevo bene:

- Posso combinare più classi `col-*` sullo stesso elemento.
- `col-12 col-md-6 col-lg-4` descrive tre comportamenti responsive diversi.
- Su schermi piccoli `col-12` fa occupare tutta la riga.
- Da `md` in su `col-md-6` fa stare due elementi per riga.
- Da `lg` in su `col-lg-4` fa stare tre elementi per riga.
- Le classi con breakpoint valgono dal breakpoint indicato in su.
- Questa grammatica permette di descrivere layout responsive complessi in modo molto leggibile.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Responsive, Grid, Breakpoints, Mental-Model

## 10 · Grid gutters

Cose che non sapevo bene:

- I gutter sono gli spazi tra le colonne e tra le righe della grid.
- `g-*` gestisce sia lo spazio orizzontale sia quello verticale.
- `gx-*` gestisce solo lo spazio orizzontale.
- `gy-*` gestisce solo lo spazio verticale.
- Una `row` senza gutter adeguato può sembrare troppo compressa.
- I gutter fanno respirare il layout senza dover scrivere CSS custom.
- Nella grid Bootstrap spesso conviene mettere il gutter sulla `row`, non inventare margini manuali su ogni colonna.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Grid, Gutters, Mental-Model

## 11 · Card base

Cose che non sapevo bene:

- Una card Bootstrap è un componente già pronto per raggruppare contenuti.
- `card` definisce il contenitore principale del componente.
- `card-body` definisce il corpo interno della card, con padding già gestito.
- `card-title` definisce il titolo della card.
- `card-text` definisce il testo della card.
- Una card è più espressiva di un semplice `div` con `p-3 border`.
- Grid, gutter, card e button possono lavorare insieme per creare una vera interfaccia.
- Bootstrap combina layout, utility e componenti.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Card, Mental-Model

## 12 · Card con immagini

Cose che non sapevo bene:

- Una card Bootstrap può integrare immagini, testo e azioni.
- `card-img-top` inserisce un'immagine nella parte superiore della card.
- L'immagine non appare come elemento appiccicato, ma come parte del componente.
- `card-img-top`, `card-body`, `card-title`, `card-text` e `btn` lavorano insieme.
- Le card sono utili per progetti, prodotti, articoli, profili, anteprime e contenuti riassuntivi.
- Bootstrap aiuta a costruire interfacce realistiche componendo componenti e utility.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Card, Mental-Model

## Concetto core · Framework CSS, component library e design system

Cose che non sapevo bene:

- Bootstrap è un framework CSS con componenti già pronti.
- Alcuni componenti Bootstrap sono solo visivi, altri hanno bisogno del JavaScript.
- Bootstrap richiede spesso di comporre markup e classi nel modo previsto.
- Una component library può offrire componenti ancora più pronti e standardizzati.
- Un design system definisce regole, stili e componenti comuni per rendere coerenti più pagine o app.
- Posso creare un layer personale sopra Bootstrap, per esempio classi come `my-button`, se voglio standardizzare ancora di più.
- Usare componenti sempre uguali tra app diverse non è necessariamente un problema: per applicazioni interne, gestionali e prototipi può essere un grande vantaggio.
- Prima conviene capire Bootstrap puro, poi eventualmente costruire o adottare un layer più alto.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Design-System, Component-Library, Mental-Model

## 13 · Temi Bootswatch

Cose che non sapevo bene:

- Un tema Bootswatch può sostituire il CSS Bootstrap standard.
- Il markup Bootstrap rimane lo stesso.
- Le classi `container`, `row`, `col-*`, `card`, `btn`, `alert` continuano a funzionare.
- Cambiando il CSS caricato cambia l'aspetto globale dell'interfaccia.
- Bootswatch permette di cambiare la "pelle" dell'app senza cambiare la struttura HTML.
- Questo è utile per prototipi, app interne, gestionali e progetti dove serve un aspetto coerente rapidamente.
- Il tema non elimina la necessità di capire Bootstrap: cambia il vestito, non la grammatica.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Theme, Bootswatch, Mental-Model
