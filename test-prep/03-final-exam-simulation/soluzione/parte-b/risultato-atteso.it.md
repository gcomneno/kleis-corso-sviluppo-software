# Parte B — risultato atteso

Applicando la join e ordinando `Esito` in ordine crescente:

| Nome | Cognome | DataEsame | Esito |
| --- | --- | --- | ---: |
| Lucia | Bianchi | 12-12-2024 | 25 |
| Alessandro | Neri | 16-12-2024 | 25 |
| Marco | Verdi | 10-12-2024 | 28 |
| Marco | Verdi | 12-12-2024 | 30 |

## Come ricavarlo manualmente

1. Ogni riga di `Esami` contiene `IdStudente`.
2. Si cerca lo studente con lo stesso identificativo.
3. Si sostituisce l'id con Nome e Cognome nel risultato.
4. Si mantengono DataEsame ed Esito.
5. Si ordinano le righe per Esito crescente.

I due esiti `25` sono equivalenti rispetto al solo criterio di ordinamento richiesto; la traccia non specifica un secondo criterio.
