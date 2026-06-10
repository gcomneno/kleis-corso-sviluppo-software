# Lessons Learned — Gestione voti classe con menu

## Obiettivo dell'esercizio

In questa esercitazione realizziamo una applicazione console in C# per gestire i voti di una classe.

Il programma usa un menu interattivo che permette di:

- inserire voti
- visualizzare tutti i voti inseriti
- calcolare la media
- trovare voto minimo e massimo
- contare i voti sufficienti
- cercare un voto specifico
- uscire dal programma

Questo esercizio è importante perché unisce più argomenti già visti:

```text
array
for
while
switch
metodi
parametri
valori restituiti
validazione input
```

Il problema principale

Il programma deve gestire al massimo 10 voti.

Per questo usiamo un array:

int[] grades = new int[10];

Però attenzione: un array da 10 elementi non significa che l'utente abbia già inserito 10 voti.

Quando creiamo un array di interi, C# inizializza automaticamente tutti gli elementi a 0.

Quindi questo array:

int[] grades = new int[10];

all'inizio contiene idealmente:

0 0 0 0 0 0 0 0 0 0

Ma questi zeri non sono voti realmente inseriti.

Sono solo valori predefiniti.

La variabile contatore

Per distinguere la capienza dell'array dai voti realmente inseriti usiamo una variabile contatore:

int gradesCount = 0;

Questa variabile indica quanti voti sono stati caricati davvero.

Esempio:

Capienza array: 10
Voti inseriti: 3

L'array potrebbe contenere:

8 5 10 0 0 0 0 0 0 0

Ma i voti validi sono solo i primi 3.

Quindi ogni ciclo deve fermarsi a gradesCount, non a grades.Length.

Corretto:

for (int i = 0; i < gradesCount; i++)
{
    Console.WriteLine(grades[i]);
}

Sbagliato:

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

Nel secondo caso stamperemmo anche gli zeri non inseriti.

Menu interattivo

Il programma usa un ciclo while per restare attivo finché l'utente non sceglie di uscire.

bool exitRequested = false;

while (!exitRequested)
{
    ShowMenu();

    int choice = ReadIntInRange("Scegli un'opzione: ", 0, 6);

    switch (choice)
    {
        case 1:
            // inserisci voti
            break;

        case 0:
            exitRequested = true;
            break;
    }
}

Il while tiene vivo il programma.

Lo switch decide cosa fare in base alla scelta dell'utente.

Perché usare metodi separati

Ogni funzionalità è stata messa in un metodo separato.

Esempi:

InsertGrades(...)
DisplayGrades(...)
DisplayAverage(...)
DisplayMinAndMax(...)
CountPassingGrades(...)
ContainsGrade(...)

Questo rende il programma più leggibile.

Il Main non diventa un blocco gigante difficile da seguire.

La logica viene divisa in piccoli pezzi, ognuno con una responsabilità precisa.

Validazione dell'input

L'utente può sbagliare input.

Può scrivere:

abc
-1
15

Per evitare errori usiamo int.TryParse e controlliamo anche l'intervallo ammesso.

static int ReadIntInRange(string message, int min, int max)
{
    int value;

    Console.Write(message);

    while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
    {
        Console.Write($"Valore non valido. Inserisci un numero da {min} a {max}: ");
    }

    return value;
}

Questa funzione protegge il programma da input non numerici e da numeri fuori intervallo.

Calcolo della media

La media si calcola sommando solo i voti realmente inseriti.

static double CalculateAverage(int[] grades, int gradesCount)
{
    int sum = 0;

    for (int i = 0; i < gradesCount; i++)
    {
        sum += grades[i];
    }

    return (double)sum / gradesCount;
}

La conversione a double è importante.

Senza conversione, C# farebbe una divisione intera tra due int.

Esempio:

13 / 2 = 6

Con double:

13 / 2 = 6.5
Minimo e massimo

Per trovare minimo e massimo partiamo dal primo voto realmente inserito.

int min = grades[0];
int max = grades[0];

Poi controlliamo gli altri voti.

Il ciclo parte da 1 perché il primo elemento è già stato usato come valore iniziale.

for (int i = 1; i < gradesCount; i++)
{
    if (grades[i] < min)
    {
        min = grades[i];
    }
}

Prima di fare questa operazione bisogna controllare che ci sia almeno un voto.

Caso senza voti

Molte operazioni non hanno senso se non ci sono voti inseriti.

Esempi:

calcolare la media
trovare minimo e massimo
cercare un voto
contare sufficienti

Per questo usiamo un metodo di controllo:

static bool HasGrades(int gradesCount)
{
    if (gradesCount == 0)
    {
        Console.WriteLine("Non ci sono ancora voti inseriti.");
        return false;
    }

    return true;
}

Questo evita errori logici e rende il programma più robusto.

Conta voti sufficienti

Un voto è sufficiente se è maggiore o uguale a 6.

if (grades[i] >= 6)
{
    passingGradesCount++;
}

Anche qui il ciclo deve arrivare solo fino a gradesCount.

Cerca voto

La ricerca scorre i voti inseriti e confronta ogni elemento con il voto cercato.

static bool ContainsGrade(int[] grades, int gradesCount, int searchedGrade)
{
    for (int i = 0; i < gradesCount; i++)
    {
        if (grades[i] == searchedGrade)
        {
            return true;
        }
    }

    return false;
}

Appena trova il voto, restituisce true.

Se arriva alla fine senza trovarlo, restituisce false.

Concetto chiave

La parte più importante dell'esercizio non è il menu.

La parte più importante è capire questa differenza:

grades.Length  = capienza massima dell'array
gradesCount    = numero reale di voti inseriti

Se confondiamo queste due cose, il programma considera voti anche gli zeri automatici dell'array.

Questa è la trappola principale dell'esercizio.

Collegamento con l'analisi del rischio

Questo esercizio contiene diversi rischi prevedibili:

Rischio	Soluzione
L'utente inserisce testo invece di numeri	TryParse
L'utente inserisce voti fuori 0-10	controllo intervallo
L'array è pieno	controllo gradesCount < grades.Length
Calcolo media senza voti	controllo HasGrades
Minimo/massimo senza voti	controllo HasGrades
Zeri automatici trattati come voti	uso di gradesCount

Scrivere buon codice significa anche prevedere cosa può andare storto.

Morale finale

Questo esercizio mostra come trasformare un programma semplice in una piccola applicazione strutturata.

Non abbiamo solo scritto istruzioni una dopo l'altra.

Abbiamo progettato un flusso:

menu
scelta utente
validazione
azione
ritorno al menu
uscita

E abbiamo separato le responsabilità in metodi più piccoli.

Questa è una delle prime forme di progettazione software.
