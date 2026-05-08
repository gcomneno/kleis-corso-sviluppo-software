# Confronto Stringhe — ANSI C vs C#

## Modello base

| Concetto   | C             | C#                      |
|------------|---------------|-------------------------|
| Stringa    | array di char | oggetto (System.String) |
| Mutabilità | OK mutabile   | KO! immutabile          |

---

## Modifica contenuto

### C
char s[] = "ciao";
s[0] = 'X'; // modifica diretta

### C#
string s = "ciao";
// s[0] = 'X'; impossibile!

---

## Operazioni

### C
Manipolazione manuale (strcpy, strcat)

### C#
Metodi:
- ToUpper
- Substring
- IndexOf
eccetera...

---

## Memoria

| C                | C#                |
|------------------|-------------------|
| gestione manuale | garbage collector |
| rischio overflow | sicurezza runtime |

---

## Passaggio parametri

### C
puntatori → modifica diretta

### C#
copia del riferimento → no modifica originale

---

## Differenza chiave!

C:
→ lavori sulla memoria

C#:
→ lavori su oggetti immutabili

---

## Conclusione

C = controllo totale + rischio ad onere dello sviluppatore!
C# = sicurezza + astrazione - rischio!
