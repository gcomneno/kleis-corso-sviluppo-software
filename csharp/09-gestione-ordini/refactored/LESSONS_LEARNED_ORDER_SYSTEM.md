# 📘 Lessons Learned — Gestione Ordini

## Obiettivo dell’esercizio

Questo esercizio simula un piccolo sistema di gestione ordini, con l’obiettivo di evolvere da una struttura semplice basata su array paralleli a una architettura OOP più modulare e mantenibile.

---

# STEP 1 — Versione base con array paralleli

## Struttura iniziale

La prima implementazione utilizza:

- array paralleli per rappresentare i dati:
  - nomi prodotti
  - categorie
  - prezzi
  - quantità

- cicli `for` per iterare sugli elementi
- logica di calcolo scritta direttamente nel programma principale

---

## Problemi principali

### 1. Dati non strutturati

Gli array paralleli richiedono gestione manuale degli indici.

Un errore di allineamento può causare incoerenza nei dati.

---

### 2. Scalabilità limitata

Aggiungere un nuovo campo significa:

- creare un nuovo array
- aggiornare tutti i cicli
- modificare tutta la logica esistente

---

### 3. Logica accoppiata

Calcoli e gestione dati sono nello stesso punto del codice.

Questo rende difficile:

- manutenzione
- riuso
- testabilità

---

## Valore didattico

Nonostante i limiti, STEP 1 è fondamentale perché:

- introduce la gestione di dati iterativi
- allena l’uso dei cicli
- simula un problema reale in forma semplificata

---

# STEP 2 — Refactoring verso OOP

## Nuova architettura

Il sistema viene rifattorizzato introducendo una separazione delle responsabilità:

```text
Program
  ↓
OrderService
  ↓
OrderCalculator
  ↓
OrderItem (Model)
```

---

## Componenti

### OrderItem (Model)

Rappresenta i dati di un singolo prodotto:

- Nome
- Categoria
- Prezzo
- Quantità

---

### OrderCalculator (Business Logic)

Contiene tutta la logica di calcolo:

- importo lordo
- sconti categoria
- importo netto

---

### OrderService (Orchestrazione)

Gestisce il flusso:

- crea dati di input
- richiama il calculator
- stampa output

---

## Vantaggi ottenuti

### 1. Separazione delle responsabilità

Ogni classe ha un solo compito.

---

### 2. Maggiore leggibilità

Il codice è più chiaro e modulare.

---

### 3. Scalabilità

È possibile aggiungere nuove funzionalità senza modificare tutto il sistema.

---

### 4. Manutenibilità

Ogni componente può essere modificato indipendentemente.

---

## CONFRONTO FINALE

### STEP 1

Dati + logica + flusso nello stesso punto.

### STEP 2

Separazione in:

- Model → dati
- Service → flusso
- Calculator → logica

---

## CONCETTO CHIAVE

Il passaggio fondamentale non è tecnico ma mentale:

> da codice che funziona  
> a sistema che si può evolvere

---

## CONCLUSIONE

Questo esercizio introduce i primi concetti reali di architettura software:

- separation of concerns
- domain modeling
- service layer
- business logic isolation
