# Lessons Learned — Triangolo

## Idea generale
Dato 3 lati:
- verificare se formano un triangolo
- determinare il tipo

---

## Concetto chiave #1 — Validazione
Non tutti i valori formano un triangolo.

Regola:
a + b > c
a + c > b
b + c > a

---

## Concetto chiave #2 — Separazione logica
- IsTriangolo() → validazione
- TipoTriangolo() → classificazione

---

## Concetto chiave #3 — Metodo riutilizzabile
I metodi permettono di:
- evitare duplicazione
- rendere il codice leggibile

---

## Modello mentale
Input → Validazione → Classificazione → Output

---

## Errori comuni
- non validare i lati
- duplicare la logica
- complicare codice semplice

---

## Nota finale
Problema semplice, ma utile per capire:
→ come separare responsabilità
