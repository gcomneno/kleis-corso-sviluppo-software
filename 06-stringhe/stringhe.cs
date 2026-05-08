Console.Write("Inserisci una frase: ");
string? input = Console.ReadLine();
if (input == null)
    return -1;

// LENGTH
Console.WriteLine($"Lunghezza della stringa: {input.Length}");

// TO UPPER
Console.WriteLine($"Maiuscolo: {input.ToUpper()}");

// TO LOWER
Console.WriteLine($"Minuscolo: {input.ToLower()}");

// CONCAT
string nuovaFrase = string.Concat(input, " - elaborata");
Console.WriteLine($"Concat: {nuovaFrase}");

// INDEXOF
int posizione = input.IndexOf("a");

if (posizione != -1)
{
    Console.WriteLine($"La lettera 'a' è presente alla posizione: {posizione}");
}
else
{
    Console.WriteLine("La lettera 'a' non è presente.");
}

// SUBSTRING (primi 3 caratteri, se possibile)
if (input.Length >= 3)
{
    string primiTre = input.Substring(0, 3);
    Console.WriteLine($"Primi 3 caratteri: {primiTre}");
}
else
{
    Console.WriteLine("Stringa troppo corta per Substring.");
}

return 0;
