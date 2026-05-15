# Lessons Learned — Codice Fiscale

## Idea generale
Generare una versione semplificata del codice fiscale italiano.

---

## Concetto chiave #1 — Stringhe
Uso di:
- Substring
- Replace
- PadRight
- ToUpper

---

## Concetto chiave #2 — Metodi
Separare la logica in metodi piccoli:
- getSurnameCode()
- getNameCode()
- getYearCode()
- getMonthCode()

---

## Concetto chiave #3 — Ambiguità dell'anno

Il codice fiscale usa solo 2 cifre per rappresentare l’anno.

Esempio:
1926 → 26
2026 → 26

Questo significa che il codice fiscale NON contiene il secolo completo.

Il sistema reale usa database e anagrafe per distinguere i casi.

---

## Curiosità nerd
Questo problema ricorda il famoso Millennium Bug (Y2K):
pochi caratteri usati per rappresentare l’anno → possibile ambiguità futura.
