# ⚔️ C# vs ANSI C — Differenze Fondamentali

## 🎯 Obiettivo
Confrontare i concetti chiave tra ANSI C e C# per evitare errori di modello mentale.

---

## 🧠 1. Modello di memoria

| Concetto         | ANSI C                  | C#                             |
|------------------|-------------------------|--------------------------------|
| Gestione memoria | Manuale (`malloc/free`) | Automatica (Garbage Collector) |
| Accesso memoria  | Diretto (puntatori)     | Astratto (reference)           |
| Sicurezza        | Bassa                   | Alta                           |

👉 In C controlli tutto!  
👉 In C# deleghi al runtime

---

## 🔗 2. Puntatori vs Riferimenti

### ANSI C
```c
char* s = "ciao";
s[0] = 'X'; // modifica reale
````

### C#

```csharp
string s = "ciao";
// s[0] = 'X'; ❌ impossibile
```

👉 C = accesso diretto alla memoria
👉 C# = accesso mediato dal runtime

---

## 🔒 3. Mutabilità delle stringhe

| Linguaggio | Stringhe     |
| ---------- | ------------ |
| C          | Mutabili     |
| C#         | ❌ Immutabili |

### C

```c
char s[] = "ciao";
s[0] = 'X'; // OK
```

### C#

```csharp
string s = "ciao";
s = s.ToUpper(); // nuova stringa
```

👉 In C# ogni modifica crea una nuova stringa

---

## 🔁 4. Passaggio parametri

| Tipo            | ANSI C             | C#                |
| --------------- | ------------------ | ----------------- |
| Default         | Puntatore / valore | Sempre per valore |
| Reference reale | Puntatori          | `ref` / `out`     |

### C

```c
void f(int* x) {
    *x = 10;
}
```

### C#

```csharp
void F(ref int x) {
    x = 10;
}
```

👉 In C# passi **copie dei riferimenti**, non i riferimenti stessi

---

## 🧩 5. Reference Type vs Value Type

### C#

```csharp
int a = 10;        // value type
string s = "ciao"; // reference type
```

| Tipo           | Comportamento         |
| -------------- | --------------------- |
| Value type     | copia del valore      |
| Reference type | copia del riferimento |

---

## 🔄 6. Effetti collaterali

### ANSI C

```c
void f(char* s) {
    s[0] = 'X'; // modifica globale
}
```

### C#

```csharp
void F(string s) {
    s = s.ToUpper(); // nessun effetto esterno
}
```

👉 C = modifiche globali facili
👉 C# = più isolamento (immutabilità)

---

## 🧵 7. Thread safety

| Linguaggio | Sicurezza    |
| ---------- | ------------ |
| C          | ❌ manuale    |
| C#         | ✔ migliorata |

👉 Le stringhe immutabili in C# sono thread-safe per definizione

---

## 🧠 8. Filosofia

| ANSI C                 | C#                       |
| ---------------------- | ------------------------ |
| Controllo totale       | Astrazione               |
| Performance            | Sicurezza + produttività |
| Responsabilità manuale | Runtime gestito          |

---

## 🎯 Regola d’oro

> In C modifichi la memoria
> In C# lavori con oggetti e riferimenti

---

## 🧨 Conclusione

* C = potenza + rischio
* C# = sicurezza + astrazione

👉 Non sono concorrenti, sono "strumenti diversi per problemi diversi"

