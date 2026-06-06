# Lessons Learned — Top Down Design

## Idea generale

Un programma grande diventa più gestibile quando viene diviso in problemi piccoli.

Questo approccio è chiamato:

- top-down design
- decomposizione del problema

---

## Concetto chiave #1 — Main leggibile

L'obiettivo NON è avere tutto il codice nel `Main()`.

L'obiettivo è:

```text
leggere il Main come una storia
```

Esempio:

```csharp
PrintArray(data);
PrintStatistics(data);
RunSearch(data);
```

L'intenzione del programma dovrebbe essere comprensibile
prima ancora dei dettagli implementativi.

---

## Concetto chiave #2 — Metodi piccoli

Ogni metodo dovrebbe avere:

- una responsabilità chiara
- un nome leggibile
- una logica limitata

Un buon metodo non nasconde solo codice:
spiega anche l'intenzione del programma.

---

## Concetto chiave #3 — Array

Uso di:

```csharp
int[] data
```

Gli array permettono di gestire collezioni di valori dello stesso tipo.

---

## Concetto chiave #4 — Ricerca

Metodo:

```csharp
bool ContainsValue(...)
```

Restituisce:

- `true`
- `false`

Introduzione pratica ai booleani.

---

## Concetto chiave #5 — foreach

```csharp
foreach (int number in data)
```

Permette di iterare sugli elementi
senza gestire manualmente gli indici.

---

## Concetto chiave #6 — Naming leggibile

Sono stati usati:

- nomi in inglese
- PascalCase
- nomi autoesplicativi

Esempi:

```csharp
CalculateAverage()
ContainsValue()
ReadInteger()
```

L'obiettivo NON è scrivere meno caratteri,
ma rendere il codice più comprensibile.

---

## Concetto chiave #7 — Separazione delle responsabilità

Il programma è stato separato in fasi logiche:

- caricamento dati
- stampa array
- calcolo statistiche
- ricerca valore

Questo rende il flusso più:

- leggibile
- mantenibile
- modificabile

---

## Flusso logico del programma

Il `Main()` esegue le operazioni in sequenza:

1. caricamento array
2. stampa dati
3. calcolo statistiche
4. ricerca valore

Se una funzione genera un errore NON gestito,
l'esecuzione del programma viene interrotta
e le funzioni successive NON vengono eseguite.

Questo concetto è fondamentale per comprendere:

- controllo del flusso
- comportamento runtime
- gestione errori

---

## Refactoring e osservazioni architetturali

### Duplicazione logica

Le funzioni:

```csharp
CalculateMinimum()
CalculateMaximum()
```

hanno una struttura molto simile.

Differisce principalmente:

- l'operatore di confronto (`<` vs `>`)

In software engineering questa situazione viene chiamata:
"duplicazione di logica".

Per il livello attuale del corso,
mantenere due funzioni separate migliora la leggibilità.

In contesti più avanzati esistono tecniche
per astrarre il comportamento comune.

---

### Main narrativo

Uno degli obiettivi del refactoring
è rendere il `Main()` leggibile quasi come pseudocodice.

Esempio:

```csharp
PrintArray(data);
PrintStatistics(data);
RunSearch(data);
```

Il codice dovrebbe comunicare:

- cosa fa
- in quale ordine
- con quale intenzione

---

### Complessità controllata

Durante il refactoring NON è sempre corretto
astrarre tutto il codice possibile.

A volte:

- codice duplicato ma leggibile
è preferibile a:
- codice troppo astratto e difficile da capire

Specialmente nei progetti didattici.

---

### Separazione tra I/O e Business Logic

Nel programma attuale alcune funzioni gestiscono:

- input/output console
- logica applicativa

In software engineering moderno si tende spesso a separare:

- I/O (console, file, rete, GUI)

da:

- business logic (algoritmi e regole)

Questo rende il codice:

- più riutilizzabile
- più testabile
- meno dipendente dall'ambiente di esecuzione

---

## Curiosità nerd

Molti programmatori junior iniziano scrivendo:

- tutto nel `Main()`
- codice molto lungo
- logica duplicata
- nomi poco descrittivi

La decomposizione in metodi
è uno dei primi veri salti di qualità.

---

## Morale finale

Scrivere codice NON significa solo:

- farlo funzionare

Significa anche:

- organizzarlo
- renderlo leggibile
- renderlo mantenibile
- comunicare chiaramente le intenzioni del programma
