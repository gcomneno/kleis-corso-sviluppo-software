const int MaxGrades = 10;

int[] grades = new int[MaxGrades];
int gradesCount = 0;
bool exitRequested = false;

while (!exitRequested)
{
    ShowMenu();

    int choice = ReadIntInRange("Scegli un'opzione: ", 0, 6);

    switch (choice)
    {
        case 1:
            gradesCount = InsertGrades(grades, gradesCount);
            break;

        case 2:
            DisplayGrades(grades, gradesCount);
            break;

        case 3:
            DisplayAverage(grades, gradesCount);
            break;

        case 4:
            DisplayMinAndMax(grades, gradesCount);
            break;

        case 5:
            DisplayPassingGradesCount(grades, gradesCount);
            break;

        case 6:
            SearchGrade(grades, gradesCount);
            break;

        case 0:
            exitRequested = true;
            Console.WriteLine("Programma terminato.");
            break;
    }

    if (!exitRequested)
    {
        Console.WriteLine();
        Console.WriteLine("Premi INVIO per tornare al menu...");
        Console.ReadLine();
    }
}

static void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine(" Gestione voti classe");
    Console.WriteLine("=================================");
    Console.WriteLine("1. Inserisci voti");
    Console.WriteLine("2. Visualizza tutti i voti");
    Console.WriteLine("3. Calcola media");
    Console.WriteLine("4. Visualizza voto massimo e minimo");
    Console.WriteLine("5. Conta voti sufficienti");
    Console.WriteLine("6. Cerca un voto");
    Console.WriteLine("0. Esci");
    Console.WriteLine("=================================");
}

static int InsertGrades(int[] grades, int gradesCount)
{
    while (gradesCount < grades.Length)
    {
        int grade = ReadIntInRange("Inserisci un voto da 0 a 10: ", 0, 10);

        grades[gradesCount] = grade;
        gradesCount++;

        Console.WriteLine($"Voto inserito. Voti presenti: {gradesCount}/{grades.Length}");

        if (gradesCount == grades.Length)
        {
            Console.WriteLine("Hai raggiunto il numero massimo di voti inseribili.");
            break;
        }

        Console.Write("Vuoi inserire un altro voto? (s/n): ");
        string? answer = Console.ReadLine();

        if (answer != "s" && answer != "S")
        {
            break;
        }
    }

    return gradesCount;
}

static void DisplayGrades(int[] grades, int gradesCount)
{
    if (!HasGrades(gradesCount))
    {
        return;
    }

    Console.WriteLine("Voti inseriti:");

    for (int i = 0; i < gradesCount; i++)
    {
        Console.WriteLine($"- Voto {i + 1}: {grades[i]}");
    }
}

static void DisplayAverage(int[] grades, int gradesCount)
{
    if (!HasGrades(gradesCount))
    {
        return;
    }

    double average = CalculateAverage(grades, gradesCount);

    Console.WriteLine($"Media voti: {average:F2}");
}

static void DisplayMinAndMax(int[] grades, int gradesCount)
{
    if (!HasGrades(gradesCount))
    {
        return;
    }

    int min = FindMinimum(grades, gradesCount);
    int max = FindMaximum(grades, gradesCount);

    Console.WriteLine($"Voto minimo: {min}");
    Console.WriteLine($"Voto massimo: {max}");
}

static void DisplayPassingGradesCount(int[] grades, int gradesCount)
{
    if (!HasGrades(gradesCount))
    {
        return;
    }

    int passingGradesCount = CountPassingGrades(grades, gradesCount);

    Console.WriteLine($"Voti sufficienti: {passingGradesCount}");
}

static void SearchGrade(int[] grades, int gradesCount)
{
    if (!HasGrades(gradesCount))
    {
        return;
    }

    int searchedGrade = ReadIntInRange("Inserisci il voto da cercare: ", 0, 10);
    bool found = ContainsGrade(grades, gradesCount, searchedGrade);

    if (found)
    {
        Console.WriteLine($"Il voto {searchedGrade} è presente.");
    }
    else
    {
        Console.WriteLine($"Il voto {searchedGrade} non è presente.");
    }
}

static double CalculateAverage(int[] grades, int gradesCount)
{
    int sum = 0;

    for (int i = 0; i < gradesCount; i++)
    {
        sum += grades[i];
    }

    return (double)sum / gradesCount;
}

static int FindMinimum(int[] grades, int gradesCount)
{
    int min = grades[0];

    for (int i = 1; i < gradesCount; i++)
    {
        if (grades[i] < min)
        {
            min = grades[i];
        }
    }

    return min;
}

static int FindMaximum(int[] grades, int gradesCount)
{
    int max = grades[0];

    for (int i = 1; i < gradesCount; i++)
    {
        if (grades[i] > max)
        {
            max = grades[i];
        }
    }

    return max;
}

static int CountPassingGrades(int[] grades, int gradesCount)
{
    int passingGradesCount = 0;

    for (int i = 0; i < gradesCount; i++)
    {
        if (grades[i] >= 6)
        {
            passingGradesCount++;
        }
    }

    return passingGradesCount;
}

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

static bool HasGrades(int gradesCount)
{
    if (gradesCount == 0)
    {
        Console.WriteLine("Non ci sono ancora voti inseriti.");
        return false;
    }

    return true;
}

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
