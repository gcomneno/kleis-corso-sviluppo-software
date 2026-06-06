// Chiedo all'utente i tre lati del triangolo
int[] lati = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write($"Inserisci il lato {i + 1}: ");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out lati[i]))
    {
        Console.WriteLine($"Errore: il lato {i + 1} non è valido.");
        return 0;
    }
}

// Nessuno mi vieta di usare direttamente lati[x] ma rendo il codice più leggibile usando le sottostanti variabili "di comodo"!
int lato1 = lati[0];
int lato2 = lati[1];
int lato3 = lati[2];

Console.WriteLine();
Console.WriteLine($"Hai inserito i lati: {lato1}, {lato2}, {lato3}");
Console.WriteLine();

// Verifico la corretta dei valori: lati > 0
if (lato1 <= 0 || lato2 <= 0 || lato3 <= 0)
{
    Console.WriteLine("Errore: i lati devono essere tutti maggiori di zero.");
    return 0;
}

// Disuguaglianza triangolare
if (lato1 + lato2 <= lato3 ||
    lato1 + lato3 <= lato2 ||
    lato2 + lato3 <= lato1)
{
    Console.WriteLine("Errore: non è un triangolo.");
    return 0;
}

// Classificazione del triangolo
switch ((lato1 == lato2, lato1 == lato3, lato2 == lato3))
{
    case (true, true, true):
        Console.WriteLine($"Triangolo EQUILATERO.");
        break;

    case (true, false, false):
    case (false, true, false):
    case (false, false, true):
        Console.WriteLine($"Triangolo ISOSCELE.");
        break;

    default:
        Console.WriteLine($"Triangolo OSCENO.. ehm.. per forza SCALENO.");
        break;
}

return 0;
