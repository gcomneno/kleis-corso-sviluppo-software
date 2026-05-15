/*
Lessons Learned — Codice Fiscale e ambiguità dell’anno

Il codice fiscale italiano usa solo le ultime 2 cifre dell’anno di nascita.

Esempi:
1926 -> 26
2026 -> 26
2126 -> 26

Questo significa che il codice fiscale NON contiene il secolo completo.

Da solo, quindi, il codice fiscale è ambiguo:
non può distinguere automaticamente persone nate a 100 anni di distanza.

Il sistema reale risolve il problema usando:
- anagrafe
- database centrali
- documenti
- storicità del soggetto

In alcuni casi interviene anche la cosiddetta "omocodia":
alcuni numeri vengono sostituiti con lettere per evitare collisioni.

Curiosità nerd:
questo problema ricorda il famoso Millennium Bug (Y2K):
pochi caratteri usati per rappresentare l’anno -> ambiguità futura.

Morale informatica:
un identificatore apparentemente intelligente può diventare ambiguo
se progettato con troppo poche informazioni.
*/

// ======================================
// GENERATORE CODICE FISCALE (ver.sempl.)
// ======================================

Console.Write("Nome: ");
string nome = Console.ReadLine()!.ToUpper();

Console.Write("Cognome: ");
string cognome = Console.ReadLine()!.ToUpper();

Console.Write("Sesso (M/F): ");
char sesso = Convert.ToChar(Console.ReadLine()!.ToUpper());

Console.Write("Giorno di nascita: ");
int giorno = int.Parse(Console.ReadLine()!);

Console.Write("Mese di nascita (1-12): ");
int mese = int.Parse(Console.ReadLine()!);

Console.Write("Anno di nascita: ");
int anno = int.Parse(Console.ReadLine()!);

string codiceComune = "A562";

string codiceFiscale =
    getSurnameCode(cognome) +
    getNameCode(nome) +
    getYearCode(anno) +
    getMonthCode(mese) +
    getDayCode(giorno, sesso) +
    codiceComune;

Console.WriteLine($"Codice fiscale generato: {codiceFiscale}");


// =======================
// METODI
// =======================

string getSurnameCode(string cognome)
{
    cognome = cognome.Replace(" ", "");

    return cognome.Length >= 3
        ? cognome.Substring(0, 3)
        : cognome.PadRight(3, 'X');
}

string getNameCode(string nome)
{
    nome = nome.Replace(" ", "");

    return nome.Length >= 3
        ? nome.Substring(0, 3)
        : nome.PadRight(3, 'X');
}

string getYearCode(int anno)
{
    // ATTENZIONE:
    // vengono usate solo le ultime 2 cifre dell'anno!
    return (anno % 100).ToString("D2");
}

char getMonthCode(int mese)
{
    string mesi = "ABCDEHLMPRST";

    return mesi[mese - 1];
}

string getDayCode(int giorno, char sesso)
{
    if (sesso == 'F')
        giorno += 40;

    return giorno.ToString("D2");
}
