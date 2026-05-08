using System;

// Queste due variabili conterranno il numero minimo e il numero massimo trovati.
// Per ora le inizializziamo a 0, ma il loro vero valore verrà deciso dal primo numero valido inserito.
int minimo = 0;
int massimo = 0;

// Usiamo un ciclo for perché sappiamo già quante volte vogliamo ripetere l'operazione:
// esattamente 5 volte, una per ciascun numero richiesto all'utente.
for (int i = 1; i <= 5; i++)
{
    int numero;

    // Questo ciclo infinito while(true) serve per insistere finché l'utente non inserisce
    // un numero intero valido. In pratica: niente scorciatoie, niente "ciao", niente "7.5" :-)
    while (true)
    {
        Console.Write($"Inserisci il numero {i}: ");

        // Console.ReadLine legge il testo digitato da tastiera.
        // Il valore restituito è una stringa (oppure null), non un intero.
        string? input = Console.ReadLine();

        // Usiamo TryParse perché l'input arriva dall'utente e potrebbe essere sbagliato.
        // Se la conversione riesce:
        // - TryParse restituisce true
        // - il numero convertito viene salvato nella variabile 'numero'
        //
        // Se fallisce:
        // - restituisce false
        // - non lancia eccezioni (a differenza della Convert.ToInt32)
        if (int.TryParse(input, out numero))
        {
            // Input valido: possiamo uscire dal while e continuare il programma!!
            break;
        }

        Console.WriteLine("Errore: devi inserire un numero intero valido. Riprova!");
    }

    // Il primo numero valido è un caso speciale:
    // non abbiamo ancora un minimo e un massimo "veri",
    // quindi usiamo questo primo valore per inizializzare entrambi.
    if (i == 1)
    {
        minimo = numero;
        massimo = numero;
    }
    else
    {
        // Se il numero corrente è più piccolo del minimo attuale,
        // aggiorniamo il minimo.
        if (numero < minimo)
        {
            minimo = numero;
        }

        // Se il numero corrente è più grande del massimo attuale,
        // aggiorniamo il massimo.
        if (numero > massimo)
        {
            massimo = numero;
        }
    }
}

// Alla fine del ciclo abbiamo confrontato tutti e 5 i numeri.
// Ora possiamo stampare il risultato finale.
Console.WriteLine();
Console.WriteLine($"Il numero minimo è: {minimo}");
Console.WriteLine($"Il numero massimo è: {massimo}");
Console.WriteLine($"La loro somma è: {minimo + massimo}");
