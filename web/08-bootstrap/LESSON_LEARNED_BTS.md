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

## 14 · Forms base con tema Darkly

Cose che non sapevo bene:

- Bootstrap dà uno stile coerente anche ai form.
- `form-label` serve a stilizzare le label dei campi.
- Il collegamento `for` della label con `id` del campo resta importante per chiarezza e accessibilità.
- `form-control` si usa per input testuali e textarea.
- `form-select` si usa per i menu `<select>`.
- `mb-3` aiuta a separare visivamente i gruppi campo.
- Con un tema Bootswatch, anche i form seguono la stessa pelle grafica del resto dell'interfaccia.
- Un form Bootstrap non è solo più bello: è più coerente, leggibile e prevedibile.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Forms, Theme, Mental-Model

## Concetto core · Bootstrap per siti vetrina e prototipi

Cose che non sapevo bene:

- Bootstrap permette di creare rapidamente siti vetrina, landing page, prototipi e interfacce semplici.
- Il vantaggio principale non è solo estetico, ma operativo: layout, componenti e responsive sono già organizzati.
- `container`, grid, card, buttons, forms e temi coprono molti bisogni comuni.
- Bootswatch permette di cambiare aspetto globale senza riscrivere il markup.
- Bootstrap è molto utile quando serve una UI coerente in poco tempo.
- Il rischio è creare siti tutti uguali o non capire cosa si sta componendo.
- Per usarlo bene bisogna capire la grammatica delle classi, non copiare pezzi a caso.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Workflow, Prototype, Sito-Vetrina, Mental-Model

## 15 · Forms help text

Cose che non sapevo bene:

- `form-text` serve a mostrare un testo di aiuto sotto un campo.
- Il testo di aiuto rende il form più chiaro e riduce ambiguità.
- `aria-describedby` collega un input al testo che lo descrive.
- L'`id` del testo di aiuto deve corrispondere al valore di `aria-describedby`.
- Help text e accessibilità vanno progettati insieme.
- Un buon form non deve solo raccogliere dati: deve aiutare l'utente a inserirli correttamente.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Forms, Accessibility, Mental-Model

## 16 · Forms validation feedback

Cose che non sapevo bene:

- Bootstrap può mostrare feedback visivo per campi validi o non validi.
- `is-valid` mostra un campo come valido.
- `is-invalid` mostra un campo come non valido.
- `valid-feedback` mostra il messaggio positivo.
- `invalid-feedback` mostra il messaggio di errore.
- Le classi `is-valid` e `is-invalid` non validano davvero i dati: comunicano solo uno stato visivo.
- La logica di validazione può arrivare da HTML5, JavaScript o backend.
- Validazione e feedback non sono la stessa cosa: una decide, l'altro comunica.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Forms, Validation, Mental-Model

## 17 · Forms checkbox e radio

Cose che non sapevo bene:

- Bootstrap usa `form-check` per organizzare checkbox e radio.
- `form-check-input` si applica all'input checkbox/radio.
- `form-check-label` si applica alla label collegata.
- Le checkbox permettono di selezionare più opzioni.
- I radio button servono a scegliere una sola opzione dentro un gruppo.
- Nei radio button il gruppo è determinato dall'attributo HTML `name`.
- Più radio con lo stesso `name` permettono una sola scelta alla volta.
- Bootstrap migliora aspetto e layout, ma alcuni comportamenti fondamentali restano HTML puro.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Forms, HTML-Core, Mental-Model

## 18 · Forms grid layout

Cose che non sapevo bene:

- La grid Bootstrap può essere usata anche dentro i form.
- `row g-3` organizza i campi e aggiunge spazio tra righe e colonne.
- `col-12 col-md-6` rende un campo largo tutta la riga su mobile e metà riga da `md` in su.
- `col-12 col-md-8` e `col-12 col-md-4` permettono layout proporzionali anche nei form.
- I campi possono impilarsi su schermi piccoli e affiancarsi su schermi più grandi.
- La grid evita di scrivere media query custom per molti form comuni.
- Bootstrap permette di combinare Forms, Grid, Gutters e Theme nello stesso esempio.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Forms, Grid, Responsive, Mental-Model

## 19 · Forms input groups

Cose che non sapevo bene:

- `input-group` permette di raggruppare input con testo, simboli o bottoni.
- `input-group-text` serve per elementi testuali agganciati all'input.
- `form-control` resta l'input principale.
- Simboli come `@`, `€` o `.00` possono diventare parte visiva del controllo.
- Anche un bottone Bootstrap può essere inserito dentro un `input-group`.
- Gli input group sono utili per username, prezzi, ricerca, URL, email e campi con prefissi o suffissi.
- Il vantaggio è creare controlli più chiari e integrati senza CSS custom.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Forms, Input-Group, Mental-Model

## 20 · Alerts

Cose che non sapevo bene:

- Gli alert servono a comunicare messaggi importanti all'utente.
- `alert` definisce il componente base.
- `alert-success` comunica successo o esito positivo.
- `alert-info` comunica informazioni utili o neutre.
- `alert-warning` comunica attenzione o possibile rischio.
- `alert-danger` comunica errore o problema grave.
- Gli alert seguono lo stesso pattern dei bottoni: classe base più variante semantica.
- Le varianti aiutano l'utente a capire il tipo di messaggio anche prima di leggere tutto il testo.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Alerts, Semantic-UI, Mental-Model

## 21 · Dismissible alerts

Cose che non sapevo bene:

- Un alert Bootstrap può essere reso chiudibile dall'utente.
- `alert-dismissible` prepara l'alert ad avere un pulsante di chiusura.
- `fade show` aggiunge/completa l'effetto visivo di comparsa.
- `btn-close` crea il pulsante di chiusura.
- `data-bs-dismiss="alert"` dice a Bootstrap quale componente chiudere.
- Per chiudere davvero l'alert serve il JavaScript di Bootstrap.
- CSS e JavaScript hanno ruoli diversi: il CSS dà aspetto, il JS dà comportamento interattivo.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Alerts, JavaScript, Mental-Model

## 22 · Navbar responsive

Cose che non sapevo bene:

- La navbar Bootstrap è un componente già pronto per la navigazione.
- `navbar` definisce il componente base.
- `navbar-expand-lg` indica che la navbar resta espansa da `lg` in su.
- Sotto il breakpoint indicato, la navbar collassa nel pulsante hamburger.
- `navbar-dark` adatta testi e icone a uno sfondo scuro.
- `bg-primary` applica il colore primary del tema.
- `navbar-brand` identifica il nome/logo del sito.
- `navbar-nav`, `nav-item` e `nav-link` organizzano i link di navigazione.
- `navbar-toggler` è il pulsante hamburger.
- `data-bs-toggle="collapse"` e `data-bs-target="#..."` collegano il bottone al menu collassabile.
- Il comportamento responsive/collapse della navbar richiede il JavaScript di Bootstrap.
- La navbar combina componenti, utility, breakpoint responsive e JavaScript.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Bootstrap-Component, Navbar, Responsive, JavaScript, Mental-Model

## 23 · Hero section

Cose che non sapevo bene:

- Una hero section è il blocco iniziale forte di una pagina vetrina.
- Bootstrap non richiede per forza un componente specifico chiamato `hero`.
- Una hero section può essere costruita componendo classi già note.
- `container` organizza la larghezza del contenuto.
- `row` e `col-*` dividono la sezione in colonne responsive.
- `py-*`, `mt-*`, `g-*` gestiscono spaziature verticali e distanza tra colonne.
- `display-4` rende il titolo più importante visivamente.
- `lead` rende il testo introduttivo più leggibile.
- I bottoni `btn`, `btn-primary`, `btn-outline-light`, `btn-lg` creano call to action chiare.
- Su schermo largo la hero può avere testo a sinistra e card/immagine a destra.
- Su schermo piccolo i blocchi si impilano grazie alla grid responsive.
- Il valore di Bootstrap emerge quando si compongono sezioni complete, non solo singoli componenti.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Hero, Sito-Vetrina, Responsive, Mental-Model

## 24 · Features section / servizi

Cose che non sapevo bene:

- Una sezione servizi/features è un blocco tipico dei siti vetrina.
- Dopo navbar e hero, una sezione con card aiuta a presentare cosa offre il sito.
- `text-center` centra titolo e testo introduttivo della sezione.
- `row g-4` crea una griglia con spazio tra le card.
- `col-12 col-md-4` impila le card su mobile e le affianca da `md` in su.
- `card h-100` aiuta ad avere card della stessa altezza visiva nella stessa riga.
- Le card possono contenere titolo, testo e call to action.
- Combinando navbar, hero e features section si ottiene già un mini-sito professionale.
- Bootstrap è molto produttivo quando si compongono sezioni standard invece di ragionare su singole classi isolate.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Features, Sito-Vetrina, Responsive, Mental-Model

## 25 · Footer

Cose che non sapevo bene:

- Il footer chiude visivamente una pagina o un sito vetrina.
- Bootstrap non obbliga a usare un componente footer specifico: si può costruire componendo classi già note.
- `border-top` separa visivamente il footer dal contenuto principale.
- `py-4` aggiunge spazio verticale sopra e sotto.
- `container` mantiene il footer allineato al resto della pagina.
- `row` e `col-*` permettono di organizzare copyright e link in modo responsive.
- `text-md-end` allinea il testo a destra da `md` in su.
- Su schermo piccolo gli elementi del footer possono impilarsi in modo ordinato.
- Un sito vetrina base può essere composto con navbar, hero, features section e footer.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Footer, Sito-Vetrina, Responsive, Mental-Model

## 26 · Contact section

Cose che non sapevo bene:

- Una sezione contatti rende il sito vetrina più completo e operativo.
- `id="contatti"` permette ai link interni di puntare direttamente alla sezione.
- Una sezione contatti può combinare card informativa e form.
- `col-12 col-lg-5` e `col-12 col-lg-7` creano un layout responsive con due colonne proporzionate.
- Su schermo piccolo le due colonne si impilano automaticamente.
- `h-100` aiuta ad avere card della stessa altezza visiva.
- `list-unstyled` rimuove i pallini da una lista informativa.
- La grid può essere usata sia per la sezione esterna sia dentro il form.
- Una pagina Bootstrap può crescere componendo sezioni standard: navbar, hero, servizi, contatti e footer.
- Questo approccio permette di costruire rapidamente un mini-sito professionale senza CSS custom.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Layout, Contact, Forms, Sito-Vetrina, Responsive, Mental-Model

## 27 · Mini-sito completo

Cose che non sapevo bene:

- I componenti Bootstrap diventano davvero potenti quando vengono composti in una pagina completa.
- Un mini-sito vetrina può nascere combinando navbar, hero, servizi, contatti e footer.
- `index.html` può restare un playground corrente.
- Un file dedicato come `28-mini-site-complete-dark.html` serve a conservare l'esempio finale studiabile.
- Il valore didattico aumenta quando gli esempi progressivi portano a una pagina completa.
- Bootstrap permette di passare velocemente da singoli componenti a una pagina professionale di base.
- La cosa importante non è copiare il file finale, ma capire quali mattoncini lo compongono.

🏷️ Tags: LeLe-Worthy, Bootstrap-Core, Sito-Vetrina, Workflow, Mental-Model
