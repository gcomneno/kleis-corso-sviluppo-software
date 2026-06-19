# Lessons Learned — Layout Responsive (Flex + Grid)

## Obiettivo della lezione

Comprendere come trasformare un layout statico in un sistema responsivo in grado di adattarsi a dispositivi diversi:

- mobile
- tablet
- desktop

---

# Concetto chiave

Un layout moderno non è una pagina fissa, ma un **sistema adattivo**.
Lo stesso contenuto cambia disposizione in base allo spazio disponibile.

---

# Mobile First

## Struttura

- layout verticale
- elementi uno sotto l’altro
- priorità alla leggibilità

## Tecniche usate

- `flex-direction: column`
- stacking naturale dei blocchi

---

# Tablet (intermedio)

## Evoluzione del layout

- introduce griglie semplici
- contenuti affiancati
- maggiore uso dello spazio

## Tecniche usate

- `display: grid`
- `grid-template-columns: 1fr 1fr`

---

# Desktop

## Struttura completa

- layout a due colonne:
  - contenuto principale
  - sidebar filtri
- header e footer sempre visibili

## Tecniche usate

- Flex per struttura generale
- Grid per contenuti interni
- `position: sticky` per sidebar

---

# Concetti fondamentali

## 1. Responsive design

Il contenuto resta lo stesso, cambia la disposizione.

---

## 2. Breakpoint

Punti in cui il layout cambia:

- 768px → tablet
- 1024px → desktop

---

## 3. Flex vs Grid

### Flex
- una dimensione (riga o colonna)
- ottimo per layout lineari

### Grid
- due dimensioni (righe + colonne)
- ottimo per dashboard e layout complessi

---

# Evoluzione mentale

### Prima

> “Disegno una pagina”

### Dopo

> “Costruisco un sistema che si adatta”

---

# Pattern architetturale imparato

- Header
- Main (content + sidebar)
- Footer

Questo è uno dei layout più comuni nel web moderno.

---

# Conclusione

Questa lezione introduce i fondamenti reali del frontend moderno:

- layout dinamici
- responsive design
- uso combinato di Flex e Grid
- progettazione per dispositivi diversi

Il risultato non è una pagina, ma un **sistema di layout adattivo**.
