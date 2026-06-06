using System;

// ====================================
// RIPASSO GENERALE C# - TOP-DOWN
// ====================================
const int MAX_ELEMENTS = 10;  // Numero massimo di elementi caricabili

int[] data = LoadArray(MAX_ELEMENTS);
PrintArray(data);

PrintStatistics(data);

RunSearch(data);

// =======================
// METODI
// =======================
int[] LoadArray(int dataLimit)
{
    int[] numbers = new int[dataLimit];

    for (int index = 0; index < numbers.Length; index++)
    {
        Console.Write($"Inserisci il numero {index + 1}: ");

        numbers[index] = ReadInteger();
    }

    return numbers;
}

void PrintArray(int[] data)
{
    Console.WriteLine("\nNumeri acquisiti:");

    foreach (int number in data)
    {
        Console.Write(number + " ");
    }

    Console.WriteLine();
}

void PrintStatistics(int[] data)
{
    Console.WriteLine($"\nMedia  : {CalculateAverage(data)}");
    Console.WriteLine($"Minimo : {CalculateMinimum(data)}");
    Console.WriteLine($"Massimo: {CalculateMaximum(data)}");
}

void RunSearch(int[] data)
{
    Console.Write("\nNumero da cercare: ");

    int valueToSearch = ReadInteger();

    bool found = ContainsValue(data, valueToSearch);

    Console.WriteLine(
        found
            ? "Valore presente."
            : "Valore NON trovato!"
    );
}

int ReadInteger()
{
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Valore NON valido! Riprova: ");
    }

    return number;
}

double CalculateAverage(int[] data)
{
    int total = 0;

    foreach (int number in data)
    {
        total += number;
    }

    return (double) total / data.Length;
}

int CalculateMinimum(int[] data)
{
    int minimum = data[0];

    foreach (int number in data)
    {
        if (number < minimum)
        {
            minimum = number;
        }
    }

    return minimum;
}

int CalculateMaximum(int[] data)
{
    int maximum = data[0];

    foreach (int number in data)
    {
        if (number > maximum)
        {
            maximum = number;
        }
    }

    return maximum;
}

bool ContainsValue(int[] data, int value)
{
    foreach (int number in data)
    {
        if (number == value)
        {
            return true;
        }
    }

    return false;
}
