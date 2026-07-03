# Soluzioni giustificate — Quiz Bootstrap Rewrite

Soluzioni del quiz basato su:

```text
web/09-bootstrap-rewrite/LESSON_LEARNED_BOOTSTRAP_REWRITE.md
```

---

## Sezione 1 — Concetti generali

### 1. Risposta corretta: C

L'obiettivo della lezione era riprendere esercizi HTML/CSS già fatti e riscriverli usando Bootstrap. Non era una lezione su nuovi componenti né su Bootswatch.

---

### 2. Risposta corretta: A

La frase chiave della lesson learned è “riscrivere senza reinventare”. Bootstrap viene usato per sostituire soluzioni manuali già risolte dal framework.

---

### 3. Risposta corretta: B

Non è stato usato Bootswatch perché l'obiettivo era imparare Bootstrap default, cioè Bootstrap “puro”, senza tema grafico esterno.

---

### 4. Risposta corretta: C

La griglia Bootstrap si basa su `container`, `row` e `col`.

---

### 5. Risposta corretta: B

`container` serve a centrare il contenuto e limitarne la larghezza, evitando pagine stirate a tutta larghezza senza controllo.

---

## Sezione 2 — Layout e responsive

### 6. Risposta corretta: C

`col-12 col-lg-8` significa: tutta larghezza su mobile, 8 colonne su layout large e superiori.

---

### 7. Risposta corretta: B

La sidebar è solo una colonna della griglia. Non richiede una tecnica speciale.

---

### 8. Risposta corretta: C

`py-5` aggiunge padding verticale sopra e sotto.

---

### 9. Risposta corretta: A

`display-5` è una classe tipografica Bootstrap per titoli grandi.

---

### 10. Risposta corretta: B

La hero è stata semplificata perché l'esercizio era didattico: capire la migrazione, non costruire una landing page commerciale.

---

## Sezione 3 — Card, immagini e logo

### 11. Risposta corretta: B

`h-100` rende le card alte quanto lo spazio disponibile nella colonna, aiutando ad uniformarle.

---

### 12. Risposta corretta: B

`d-flex flex-column` permette di organizzare il contenuto della card in verticale e controllare meglio la posizione del bottone.

---

### 13. Risposta corretta: B

`mt-auto` usa il margine superiore automatico per spingere il bottone verso il fondo della card.

---

### 14. Risposta corretta: A

`object-fit-cover` riempie il contenitore ma può tagliare parti dell'immagine. Per una copertina è un problema.

---

### 15. Risposta corretta: C

`object-fit-contain` mostra tutta l'immagine senza tagliarla.

---

### 16. Risposta corretta: B

Il logo si era deformato perché erano stati fissati sia `width` sia `height`, costringendo un'immagine rettangolare dentro un quadrato.

---

### 17. Risposta corretta: A

Impostare solo l'altezza e lasciare `width: auto` mantiene le proporzioni originali.

---

## Sezione 4 — Colore di brand

### 18. Risposta corretta: B

Bootstrap default usa il blu come colore primary. Per ottenere un bordeaux coerente col logo è stato aggiunto un piccolo CSS custom.

---

### 19. Risposta corretta: B

L'approccio corretto è stato creare poche classi mirate, non riscrivere Bootstrap.

---

### 20. Risposta corretta: A

Una variabile CSS permette di modificare il colore una volta sola e riusarlo in più classi.

---

## Sezione 5 — Scheda libro

### 21. Risposta corretta: C

La scheda libro usa un layout a due colonne: copertina a sinistra e informazioni a destra.

---

### 22. Risposta corretta: B

La copertina occupa meno spazio rispetto al contenuto testuale, quindi usa colonne più piccole su breakpoint medi e grandi.

---

### 23. Risposta corretta: B

Mostrare il libro corrente nella sezione “Altri libri” è ridondante e peggiora l'esperienza utente. La sezione deve proporre alternative.

---

## Sezione 6 — Form Bootstrap

### 24. Risposta corretta: C

Nel vecchio esercizio l'allineamento era gestito con `float: right`.

---

### 25. Risposta corretta: B

Con Bootstrap si usa una `row` con label e input dentro colonne, ad esempio `col-sm-4` e `col-sm-8`.

---

### 26. Risposta corretta: B

Gli input testuali usano `form-control`.

---

### 27. Risposta corretta: B

Le select usano `form-select`.

---

### 28. Risposta corretta: A

Radio e checkbox si gestiscono con la struttura `form-check`.

---

### 29. Risposta corretta: B

`novalidate` disattiva la grafica nativa del browser, permettendo di mostrare feedback Bootstrap coerenti.

---

### 30. Risposta corretta: B

Lo script blocca l'invio se la form non è valida e aggiunge `was-validated`, così Bootstrap mostra i messaggi.

---

### 31. Risposta corretta: A

`d-block` forza il messaggio a essere visibile sempre, anche quando Bootstrap vorrebbe nasconderlo.

---

### 32. Risposta corretta: C

In un gruppo radio basta un `required` su un input del gruppo con lo stesso `name`.

---

### 33. Risposta corretta: A

Se `Singolo` è selezionato di default, il gruppo radio parte già valido e non mostra errore immediato.

---

## Sezione 7 — Domande pratiche

### 34. Risposta corretta: A

`mx-auto` centra, `border border-2 border-primary` replica il bordo blu, e la larghezza può essere gestita con griglia o `max-width`.

---

### 35. Risposta corretta: C

`textarea` usa `form-control`, come gli input testuali.

---

### 36. Risposta corretta: C

Il CSS custom è accettabile se è limitato e serve per casi specifici: colore brand, altezza immagini, larghezza massima o piccoli aggiustamenti.

---

### 37. Risposta corretta: B

L'errore più grosso è usare Bootstrap solo come decorazione, continuando però a ragionare con vecchi pattern CSS come float e larghezze rigide.

---

### 38. Risposta corretta: B

La form era un esercizio separato. Bisognava rispettare la traccia originale, non contaminarla col branding della casa editrice.

---

### 39. Risposta corretta: B

La domanda mentale corretta è: “Quale parte di questo codice è già risolta da Bootstrap?”

---

### 40. Risposta corretta: A

Una migrazione sana procede per blocchi e pattern: layout, form, card, immagini, validazione, ecc.

---

## Mini-esercizio finale — Risposta guida

Una possibile risposta corretta:

1. Per centrare la form userei `container`, `row justify-content-center`, una colonna responsive oppure `mx-auto` con una classe locale tipo `registration-box`.

2. Per dare un bordo blu userei `border border-2 border-primary`.

3. Per allineare label e input userei una `row align-items-center`, con `label` in `col-sm-4` e input in `col-sm-8`.

4. Per gli input userei `form-control`; per la select userei `form-select`; per la textarea ancora `form-control`.

5. Per radio e checkbox userei `form-check`, `form-check-input` e `form-check-label`.

6. Per la validazione userei `needs-validation` sul form, `novalidate`, attributi `required`, messaggi `invalid-feedback`, e lo script che aggiunge `was-validated` dopo il submit.

Risposta da scimmietta promossa: non serve ricordare tutto a memoria, ma devi riconoscere il pattern giusto.
