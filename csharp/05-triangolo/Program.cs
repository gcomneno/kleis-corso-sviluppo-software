/* LessonZ To Learn: 

  - Favorisci il riuso del codice con i metodi giusti al posto giusto.
  - Non fidarti mai dell'utente!! riesce a scrivere cose che noi programmatori nemmeno immaginiamo!!
  - Ho usato naming in camelCase per semplicità, ma lo standard C# è PascalCase!!
    (Nei progetti seri bisogna seguire sempre le convenzioni del linguaggio)
  - Operatore ternario => condizione ? valore_se_vero : valore_se_falso
    (Il "ternario" è utile per condizioni semplici con una sola azione; evitalo se logica complessa e/o codice lungo!!)
*/

// =========================================
// USER INPUT ("TRUST NO ONE", cit. XFILES!)
// =========================================
Console.WriteLine("Inserimento dati triangolo:");

int lato1 = readUserInput("Inserisci il primo lato: ");
int lato2 = readUserInput("Inserisci il secondo lato: ");
int lato3 = readUserInput("Inserisci il terzo lato: ");


// =======================
// MAIN LOGIC & OUTPUT
// =======================
Console.WriteLine(
    isTriangle(lato1, lato2, lato3)
        ? $"Il triangolo è: {getTriangleType(lato1, lato2, lato3)}"
        : "I valori inseriti NON formano un triangolo."
);


// =================================================
// I METODI ti evitano la duplicazione di codice :-)
// =================================================
int readUserInput(string messaggio)
{
    while (true)
    {
        Console.Write(messaggio);

        if (!int.TryParse(Console.ReadLine(), out int valore))
        {
            Console.WriteLine("Errore: valore non valido.");
            continue;
        }

        if (valore <= 0)
        {
            Console.WriteLine("Errore: il valore deve essere maggiore di zero.");
            continue;
        }

        return valore;
    }
}

bool isTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}

string getTriangleType(int a, int b, int c)
{
    if (a == b && b == c)
        return "equilatero";

    if (a == b || a == c || b == c)
        return "isoscele";

    return "scaleno.. e lavoro meno!";
}
