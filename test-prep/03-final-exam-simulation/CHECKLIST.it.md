# Checklist finale

## Parte A — Funzionale

- [ ] La pagina principale si apre senza errori PHP.
- [ ] La lista mostra tutti i libri presenti.
- [ ] Il form consente l'inserimento dei dati richiesti.
- [ ] Un libro valido viene salvato.
- [ ] Dopo il salvataggio il libro compare nella lista.
- [ ] Un titolo duplicato viene rifiutato.
- [ ] L'eliminazione rimuove il libro corretto.
- [ ] L'eliminazione reale non avviene tramite semplice GET.
- [ ] I messaggi di errore sono comprensibili.

## Parte A — Tecnica

- [ ] HTML semanticamente valido e leggibile.
- [ ] CSS separato e personalizzato.
- [ ] PHP separa almeno connessione DB e pagine/azioni principali.
- [ ] PDO usa prepared statement.
- [ ] Output dinamico escapato con `htmlspecialchars()`.
- [ ] Input validato lato server.
- [ ] Il database ha una primary key.
- [ ] Il database applica il vincolo `UNIQUE` sul titolo.
- [ ] Non ci sono credenziali reali committate.
- [ ] La descrizione tecnica spiega scelte e trade-off.

## Parte B

- [ ] È presente `INNER JOIN`.
- [ ] La condizione collega `Esami.IdStudente` e `Studenti.IdStudente`.
- [ ] Sono selezionate solo Nome, Cognome, DataEsame, Esito.
- [ ] È presente `ORDER BY Esito ASC`.
- [ ] Il risultato manuale contiene quattro righe.
- [ ] Le righe con esito 25 precedono 28 e 30.

## Gate

```text
PART_A_FUNCTIONAL=PASS
PART_A_DATA_MODEL=PASS
PART_A_SECURITY_BASELINE=PASS
PART_B_SQL=PASS
PART_B_EXPECTED_RESULT=PASS
FINAL_SIMULATION=PASS
```
