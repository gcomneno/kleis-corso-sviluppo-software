# Kleis C# Course

Raccolta delle esercitazioni svolte durante un corso di formazione su C# e .NET.

## 🎯 Obiettivo

Consolidare le basi della programmazione con C#, lavorando su esercizi pratici che coprono:

- input/output da console
- gestione delle stringhe
- strutture di controllo (`if`, `switch`, cicli)
- gestione degli errori (TryParse vs Convert)
- logica applicativa (es. classificazione di un triangolo)

## 🗂️ Struttura del progetto

La repository è organizzata come una **solution .NET (`Kleis.sln`)** che contiene più progetti, uno per ogni esercitazione:

Kleis/
├── Kleis.sln
├── Esercitazione-2/
├── Esercitazione-4/
├── Esercitazione-6/

Ogni cartella rappresenta un progetto console indipendente.

## ▶️ Esecuzione

Eseguire una specifica esercitazione:

dotnet run --project "Esercitazione-6/Esercitazione-6.csproj"

Oppure:

cd Esercitazione-6
dotnet run

## 🧠 Note tecniche

- Utilizzo di `TryParse` per la validazione dell'input utente
- Uso di `switch` e `if/else` per confronto tra approcci
- Struttura a progetti separati per evitare conflitti con i top-level statements
- Repository gestita interamente da riga di comando (`git` + `gh`)

## 🚀 Evoluzione

Questa repository verrà aggiornata con:
- nuove esercitazioni
- refactor progressivi
- miglioramenti di struttura e leggibilità

## 👤 Autore

GitHub: https://github.com/gcomneno
