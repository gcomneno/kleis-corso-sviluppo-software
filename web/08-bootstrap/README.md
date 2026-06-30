# Bootstrap 5 · Prima lezione

Questa cartella raccoglie gli esempi pratici della prima introduzione a Bootstrap 5.

L'obiettivo non è memorizzare tutte le classi, ma capire la grammatica di base:

- Bootstrap come set di classi CSS già pronte;
- setup minimo con CDN;
- approccio mobile-first;
- classi componibili;
- container e container-fluid;
- spacing utilities;
- buttons;
- grid system;
- breakpoint responsive;
- gutter;
- card;
- card con immagini;
- tema Bootswatch.

## Come studiare

Aprire gli esempi HTML in VS Code Preview o nel browser.

Percorso consigliato:

1. leggere `LESSON_LEARNED_BTS.md`;
2. aprire gli esempi in `examples/` in ordine numerico;
3. osservare cosa cambia tra un esempio e il successivo;
4. modificare piccole classi Bootstrap e vedere l'effetto.

## File principali

- `index.html`: esempio corrente/playground.
- `examples/`: esempi stabili e numerati.
- `LESSON_LEARNED_BTS.md`: appunti progressivi e concetti LeLe-Worthy.

## Concetti core

I concetti marcati con:

`LeLe-Worthy`

sono quelli da ripassare con più attenzione, perché rappresentano modelli mentali importanti.

## Nota sui temi

Gli esempi finali usano anche Bootswatch.

Bootswatch permette di cambiare il tema grafico globale mantenendo lo stesso markup Bootstrap.

In pratica:

- Bootstrap resta lo scheletro;
- Bootswatch cambia la pelle.

## Esempio finale

Il file:

`examples/28-mini-site-complete-dark.html`

raccoglie i concetti principali della prima parte del laboratorio in una pagina unica:

- navbar responsive;
- hero section;
- sezione servizi/features;
- sezione contatti con form;
- footer;
- tema Bootswatch Darkly;
- layout responsive mobile-first.

Questo esempio mostra come Bootstrap permetta di costruire rapidamente un mini-sito vetrina componendo classi, utility e componenti già studiati.
