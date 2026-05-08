/*
"Calcolatrice" (mini)

Creare una pseudo-calcolatrice che:
- prende due numeri
- prende un operatore
- esegue il calcolo
- stampa il risultato sulla console..
- ..e ti faccia sentire Leonardo da Vinci!

---

Cosa ho imparato davvero da questo esercizio?
spoiler: dare ragione a Massimo Troisi quando si chiedeva se 9x9 facesse 81. E' VERO!!!

Concetto chiave #1 — Metodi/Funzioni
Non mettere tutta la logica nel main() - RIUSA IL CODICE!

Separare..
- Somma()
- Differenza()
- Prodotto()
- Divisione()

..dalla Funzione centrale:
Calcola(numero1, numero2, operatore)

"Ogni metodo DEVE fare una cosa sola."
Non è obbligatorio ma una buona prassi di codice pulito => singola responsabilità.

---

## Spunti..no #1  — Separatori decimali e CultureInfo
Il separatore decimale dipende dalla "culture" del sistema (CultureInfo).

Esempio: forzare il parsing con il punto come separatore:

using System.Globalization;
double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

---

## Spunti..no #2  — NaN (Not a Number)

In C#, `NaN` significa "Not a Number", cioè un valore numerico che in realtà NON rappresenta un numero valido.

Si usa quando un’operazione matematica non ha senso, ad esempio:
- divisione per zero (tipo nel nostro contesto)
- operazioni non definite

Esempio:
double x = 0.0 / 0.0; // risultato: NaN

Attenzione:
`NaN` è un caso particolare, perché NON è uguale nemmeno a se stesso!

Esempio:
double x = double.NaN;

x == double.NaN      // false
double.IsNaN(x)      // true

per verificare un NaN bisogna usare sempre `double.IsNaN()`

In pratica:
NaN = "questo risultato non è un numero valido, anche se il tipo è double"

---

## Spunti..no #3  — Stile di scrittura e formattazione
Riguarda lo stile K&R (classico del C) e stile "Microsoft" (di un certo Allman) per l'indentazione dei blocchi di codice.
- a casa tua fai come ti pare, il compilatore non si offende.
- nei team si segue SEMPRE lo standard del progetto! (C# usa stile Allman, ovviamente!)

---

## Spunti..no #4 - "double" vs "decimal"
Entrambi servono per numeri con la virgola, ma NON sono uguali!

double:
- default in C#
- veloce  
- usa rappresentazione binaria  
- MA può introdurre piccoli errori (es: 0.1 + 0.2 ≠ 0.3 esatto)

decimal:
- più preciso  
- pensato per calcoli finanziari  
- MA è più lento

## Quando usare cosa
double  => default per quasi tutto      => scientifico
decimal => soldi, prezzi, contabilità   => economico

## Esempio
double  x = 0.1  + 0.2;   // 0.30000000000000004
decimal y = 0.1m + 0.2m;  // 0.3

---

## Challenge: "Perché inserendo ad esempio 4.6 (usando il punto) il risultato è sbagliato?"

Inserisci il primo numero: 4.6
Inserisci il secondo numero: 5
Inserisci operatore [+ - * /]: +
Risultato: 51

Come si può rendere il programma indipendente dal separatore decimale?
(risposta a pag, 46 sul prossimo numero de: "La Settimana Enigmistica"!)

---

Errori comuni:
- fidarsi dell’input dall'utente (TRUST NO ONE)
- mettere tutto nel main()
- dimenticare il default nello switch (veniale ma va bacchettata questa prassi!)
- dimenticare il bollilatte sul fuoco!
- non controllare la divisione per zero
- trova l'intruso
*/


// ===================================
// Sezione di INPUT dati e validazione
// ===================================
Console.Write("Inserisci il primo numero: ");
if (!double.TryParse(Console.ReadLine(), out double n1))
{
    Console.WriteLine("Errore: il primo valore non è valido.");
    return;
}

Console.Write("Inserisci il secondo numero: ");
if (!double.TryParse(Console.ReadLine(), out double n2))
{
    Console.WriteLine("Errore: il secondo valore non è valido.");
    return;
}

Console.Write("Inserisci operatore [+ - * /]: ");
string? inputOperatore = Console.ReadLine();

// prendo il primo carattere ma solo se esiste!
char op = string.IsNullOrEmpty(inputOperatore) ? '\0' : inputOperatore[0]; // "operatore ternario" per capire questa sintassi. ("\0" => è sia il TAPPO di fine-stringa che un alias per "null")

// è uno dei quattro possibili caratteri ammessi?
if ("+-*/".IndexOf(op) == -1)
{
    Console.WriteLine("Operatore non valido.");
    return;
}


// =============================
// Sezione principale di CALCOLO
// =============================
double risultato = Calcola(n1, n2, op);


// =============================
// Sezione di STAMPA dell'output
// =============================
Console.WriteLine(
    risultato == -1
        ? "Risultato: impossibile!"
        : $"Risultato: {risultato}"
);


// =============================
// Operazioni basilari INTERNE
// =============================
double _somma(double a, double b)        => a + b;
double _differenza(double a, double b)   => a - b;
double _prodotto(double a, double b)     => a * b;
double _divisione(double a, double b)    => a / b;


// ==========================
// API esposte
// ==========================
double Calcola(double numero1, double numero2, char operatore)
{
    switch (operatore)
    {
        case '+':
            return _somma(numero1, numero2);

        case '-':
            return _differenza(numero1, numero2);

        case '*':
            return _prodotto(numero1, numero2);

        case '/':
            if (numero2 == 0)
            {
                Console.WriteLine("Errore: divisione per zero.");
                return -1; // uso un valore "speciale" per gestire i casi d'errore
            }

            double quoziente = _divisione(numero1, numero2);

            // nota: resto più sensato sugli interi (ho preferito fare un cosidetto "cast", forzatura, esplicita di tipo!)
            int q = (int)(numero1 / numero2);
            int r = (int)numero1 % (int)numero2;

            Console.WriteLine($"Quoziente (intero): {q}");
            Console.WriteLine($"Resto: {r}");

            return quoziente;

        default: // non assumere che il chiamante abbia già validato l’operatore!
            Console.WriteLine("Operatore non valido.");
            return -1; // valore sentinella per indicare errore
    }
}

/* Per chi non vuole attendere il prossimo numero della rivista enigmistica:
    - Il problema è legato alla cultura del sistema.
    - Una soluzione semplice per evitare di impelagarsi con la CultureInfo è normalizzare l’input sostituendo "." con "," prima del parsing! :-)
        input = input.Replace('.', ',');
        if (!double.TryParse(input, out double n1)) { ... errore... }

    P.S.: Questa soluzione è offerta da CSADC: "Centro Studi in Affari Diversamente Complicati"
*/
