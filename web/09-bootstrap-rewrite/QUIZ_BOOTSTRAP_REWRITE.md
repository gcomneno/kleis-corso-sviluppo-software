# Quiz — Bootstrap Rewrite

Quiz basato solo sul contenuto di:

```text
web/09-bootstrap-rewrite/LESSON_LEARNED_BOOTSTRAP_REWRITE.md
```

Obiettivo: verificare se hai capito come migrare esercizi HTML/CSS tradizionali verso Bootstrap, senza rifare componenti già studiati e senza trasformare ogni pagina in un carro allegorico di classi a caso.

---

## Sezione 1 — Concetti generali

### 1. Qual è l'obiettivo principale della lezione “Bootstrap Rewrite”?

A. Imparare Bootswatch  
B. Imparare nuovi componenti Bootstrap avanzati  
C. Riscrivere esercizi HTML/CSS già fatti usando Bootstrap  
D. Creare un sito completo per una casa editrice reale  

---

### 2. Quale frase riassume meglio la filosofia della lezione?

A. Riscrivere senza reinventare  
B. Aggiungere più CSS custom possibile  
C. Usare sempre Bootswatch  
D. Evitare Bootstrap e usare solo Flexbox manuale  

---

### 3. Perché non è stato usato Bootswatch?

A. Perché non funziona con Bootstrap 5  
B. Perché l'obiettivo era imparare Bootstrap default  
C. Perché impedisce di usare le card  
D. Perché non supporta i form  

---

### 4. Quali sono i tre elementi base della griglia Bootstrap citati nella lesson learned?

A. table, tr, td  
B. wrapper, box, item  
C. container, row, col  
D. header, main, footer  

---

### 5. Che cosa fa principalmente `container` in Bootstrap?

A. Crea una modale  
B. Limita e centra il contenuto  
C. Rende obbligatorio un campo form  
D. Applica un colore di sfondo scuro  

---

## Sezione 2 — Layout e responsive

### 6. In Bootstrap, che cosa permette di ottenere una combinazione come `col-12 col-lg-8`?

A. Una colonna sempre larga 8 colonne  
B. Una colonna nascosta su mobile  
C. Una colonna larga tutta la riga su mobile e 8 colonne da desktop  
D. Una colonna valida solo nei form  

---

### 7. Perché la sidebar non deve essere trattata come elemento speciale?

A. Perché Bootstrap non supporta sidebar  
B. Perché è semplicemente una colonna della griglia  
C. Perché deve sempre stare nel footer  
D. Perché va sempre costruita con JavaScript  

---

### 8. Quale classe Bootstrap è stata usata per aggiungere spaziatura verticale alla hero section?

A. `my-auto`  
B. `px-0`  
C. `py-5`  
D. `gap-5`  

---

### 9. Quale classe è stata usata per rendere più grande il titolo della hero?

A. `display-5`  
B. `text-muted`  
C. `form-label`  
D. `object-fit-contain`  

---

### 10. Perché la hero è stata semplificata?

A. Perché Bootstrap non permette hero complesse  
B. Perché l'obiettivo era didattico, non creare una landing commerciale  
C. Perché il browser non caricava le immagini  
D. Perché la sidebar non funzionava  

---

## Sezione 3 — Card, immagini e logo

### 11. Quale classe è stata usata per rendere le card tutte della stessa altezza?

A. `w-100`  
B. `h-100`  
C. `vh-100`  
D. `align-middle`  

---

### 12. Perché nel `card-body` è utile usare `d-flex flex-column`?

A. Per disabilitare il responsive  
B. Per ordinare il contenuto in verticale e controllare meglio l'allineamento interno  
C. Per trasformare la card in una tabella  
D. Per rendere obbligatorio il bottone  

---

### 13. Che cosa fa `mt-auto` sul bottone dentro una card flessibile?

A. Lo nasconde su mobile  
B. Lo spinge verso il fondo della card  
C. Lo trasforma in un link  
D. Lo rende blu  

---

### 14. Perché `object-fit-cover` non era adatto alle copertine dei libri?

A. Perché tagliava le immagini  
B. Perché non funziona con PNG  
C. Perché cancella l'attributo `alt`  
D. Perché richiede JavaScript  

---

### 15. Quale classe è più adatta per mostrare una copertina intera senza tagliarla?

A. `object-fit-cover`  
B. `object-fit-fill`  
C. `object-fit-contain`  
D. `object-fit-none`  

---

### 16. Perché il logo nella navbar si era deformato?

A. Perché Bootstrap non supporta immagini nella navbar  
B. Perché erano stati impostati sia `width` sia `height` fissi  
C. Perché mancava `alt`  
D. Perché era dentro un link  

---

### 17. Qual è una soluzione corretta per mantenere proporzionato un logo?

A. Impostare solo l'altezza e lasciare `width: auto`  
B. Impostare sempre `width="36"` e `height="36"`  
C. Usare `object-fit-cover`  
D. Convertirlo sempre in SVG manualmente  

---

## Sezione 4 — Colore di brand

### 18. Perché è stato creato un piccolo CSS custom per il bordeaux?

A. Per sostituire completamente Bootstrap  
B. Perché Bootstrap default usa il blu come colore primary  
C. Perché Bootstrap non ha classi per i bottoni  
D. Perché Bootswatch era obbligatorio  

---

### 19. Quale approccio è stato adottato per il colore di brand?

A. Riscrivere tutto il CSS di Bootstrap  
B. Creare poche classi mirate come `text-brand`, `btn-brand`, `btn-outline-brand`  
C. Usare solo stili inline ovunque  
D. Eliminare tutti i bottoni  

---

### 20. Che vantaggio ha usare variabili CSS come `--brand-bordeaux`?

A. Permette di cambiare il colore in un solo punto  
B. Impedisce il responsive  
C. Elimina la necessità dell'HTML  
D. Rende obbligatorio JavaScript  

---

## Sezione 5 — Scheda libro

### 21. Qual è la struttura tipica della scheda libro realizzata?

A. Una sola colonna con tutto centrato  
B. Una tabella HTML  
C. Due colonne: copertina a sinistra, informazioni a destra  
D. Un carousel obbligatorio  

---

### 22. Nella scheda libro, perché si usa `col-md-5 col-lg-4` per la copertina?

A. Per nasconderla su desktop  
B. Per darle meno spazio rispetto ai contenuti testuali  
C. Per renderla sempre larga tutta la pagina  
D. Per forzare un errore di validazione  

---

### 23. Perché nella sezione “Altri libri” non bisogna mostrare il libro corrente?

A. Perché Bootstrap non permette duplicati  
B. Perché peggiora l'esperienza utente e non propone alternative reali  
C. Perché rompe il footer  
D. Perché impedisce il caricamento del CSS  

---

## Sezione 6 — Form Bootstrap

### 24. Nel vecchio esercizio, quale tecnica CSS era usata per allineare input e label?

A. CSS Grid  
B. Bootstrap row/col  
C. `float: right`  
D. Flexbox con `justify-content-between`  

---

### 25. Con Bootstrap, quale struttura sostituisce bene `float: right` nei form?

A. `table table-striped`  
B. `row` con label e input dentro colonne  
C. `modal-dialog`  
D. `accordion-item`  

---

### 26. Quale classe Bootstrap va usata per gli input testuali?

A. `form-select`  
B. `form-control`  
C. `form-check`  
D. `form-textarea-only`  

---

### 27. Quale classe Bootstrap va usata per una select?

A. `form-control`  
B. `form-select`  
C. `select-control`  
D. `input-select`  

---

### 28. Quale struttura Bootstrap è dedicata a radio e checkbox?

A. `form-check`  
B. `form-grid`  
C. `card-check`  
D. `input-radio-row`  

---

### 29. A che cosa serve `novalidate` nella form Bootstrap?

A. A disattivare completamente ogni validazione  
B. A disattivare la grafica nativa del browser per usare feedback Bootstrap  
C. A rendere tutti i campi opzionali  
D. A inviare la form automaticamente  

---

### 30. Che cosa fa lo script di validazione Bootstrap quando la form non è valida?

A. Cancella tutti i campi  
B. Aggiunge `was-validated` e blocca l'invio  
C. Cambia pagina  
D. Rimuove Bootstrap  

---

### 31. Perché `invalid-feedback d-block` era un errore?

A. Perché `d-block` rendeva il messaggio sempre visibile  
B. Perché `invalid-feedback` non esiste  
C. Perché impediva al bottone reset di funzionare  
D. Perché cancellava i radio button  

---

### 32. In un gruppo radio, quanti input devono avere `required`?

A. Tutti obbligatoriamente  
B. Nessuno  
C. Basta uno del gruppo con lo stesso `name`  
D. Solo quello non selezionato  

---

### 33. Perché è stato impostato `Singolo` come radio selezionato di default?

A. Per evitare che la sezione partisse già non valida  
B. Perché Bootstrap non supporta radio vuoti  
C. Per nascondere il gruppo radio  
D. Per rendere inutile la privacy  

---

## Sezione 7 — Domande pratiche

### 34. Riscrivi mentalmente questo CSS vecchio in Bootstrap:

```css
form {
  margin: 30 auto;
  width: 40%;
  border: 2px solid blue;
}
```

Quale combinazione è più coerente?

A. `mx-auto border border-2 border-primary` più una larghezza controllata con griglia o `max-width`  
B. `float-end text-primary accordion`  
C. `navbar navbar-expand-lg`  
D. `object-fit-cover h-100`  

---

### 35. Quale delle seguenti trasformazioni è corretta?

A. `<input>` → `form-select`  
B. `<select>` → `form-check`  
C. `<textarea>` → `form-control`  
D. `<button>` → `form-label`  

---

### 36. Quando è accettabile aggiungere poco CSS custom in un progetto Bootstrap didattico?

A. Sempre, per riscrivere tutto Bootstrap  
B. Mai, Bootstrap vieta CSS custom  
C. Quando serve per colore di brand, altezza immagine, larghezza massima locale o piccoli aggiustamenti  
D. Solo dentro JavaScript  

---

### 37. Qual è l'errore concettuale più importante da evitare durante una migrazione Bootstrap?

A. Usare `container`  
B. Continuare a ragionare con CSS vecchio e usare Bootstrap solo come decorazione  
C. Usare `row` e `col`  
D. Usare `form-control`  

---

### 38. Perché la form di registrazione non doveva usare il branding Cicellyn Edizioni?

A. Perché il file immagine era troppo grande  
B. Perché era un esercizio separato e bisognava rispettare la traccia originale  
C. Perché Bootstrap non supporta loghi nei form  
D. Perché il docente aveva vietato i colori  

---

### 39. Quale domanda mentale bisogna farsi davanti a un vecchio HTML/CSS da migrare?

A. “Come posso aggiungere più animazioni?”  
B. “Quale parte di questo codice è già risolta da Bootstrap?”  
C. “Come posso evitare le classi Bootstrap?”  
D. “Come posso trasformare tutto in JavaScript?”  

---

### 40. In una migrazione Bootstrap, quale approccio è più sano?

A. Tradurre blocchi e pattern uno alla volta  
B. Cancellare tutto e improvvisare  
C. Aggiungere componenti non richiesti  
D. Usare Bootswatch anche se l'obiettivo è Bootstrap default  

---

## Mini-esercizio finale

Prendi questa form concettuale:

```text
Titolo
Nome
Cognome
Select genere
Radio singolo/gruppo
Textarea note
Checkbox privacy
Reset
Submit
```

Scrivi a parole quali classi Bootstrap useresti per:

1. centrare la form;
2. dare un bordo blu;
3. allineare label e input;
4. stilizzare input e select;
5. gestire radio e checkbox;
6. validare i campi obbligatori.

Non serve scrivere tutto il codice HTML. Serve dimostrare che hai capito la trasformazione.
