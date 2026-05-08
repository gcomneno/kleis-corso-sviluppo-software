# Lessons Learned — Stringhe in C#
Cosa ho imparato davvero sulle stringhe?  
spoiler: non è la teoria cosmologica, quella è un'altra cosa e poi non è stata ancora dimostrata!

## Idea generale
Le stringhe in C# sono "oggetti immutabili" usati per gestire del testo.

Le due parole magiche di questa lezione sono:
1. OGGETTI; se ne parlerà più in avanti però, stai calmo!!
2. IMMUTABILI; concetto per nerd! Mmmuahuauahuahuahuhauaua (risata da boss di ultimo livello!)

## Immutabilità
Una stringa non può essere modificata: qualsiasi operazione crea un nuovo oggetto.

Esempio:
string s = "ciao";
s = s.ToUpper(); // nuova stringa!

(non ci credi? prova. Non vuoi? fidati e basta! 😄)

---

## Concetti chiave

### Interpolazione
Uso di `$"..."` per inserire variabili dentro stringhe in modo leggibile.

### Metodi principali studiati
- Length
- ToUpper / ToLower
- IndexOf
- Substring
- Concat

(Tutti questi metodi NON modificano la stringa originale -> vedi parola magica 2.)

---

## Caratteri speciali
Uso del backslash `\` per escape:
- \n nuova riga
- \" virgolette
- \\ backslash

---

## Modello mentale
Stringa = oggetto + riferimento  
-> non si modifica, si sostituisce

---

## Errori comuni
- Pensare che ToUpper modifichi la stringa
- Dimenticare controllo su IndexOf (-1)
- Dimenticare il latte sul fuoco!
- Usare Substring senza controllare Length
