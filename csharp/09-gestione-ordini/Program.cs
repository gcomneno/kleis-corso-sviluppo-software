using System;

class Program
{
    static void Main()
    {
        string[] nomiProdotti =
        {
            "T-Shirt tecnica",
            "Borraccia",
            "Proteine whey",
            "Pantaloncini"
        };

        string[] categorie =
        {
            "ABBIGLIAMENTO",
            "ACCESSORI",
            "INTEGRATORI",
            "ABBIGLIAMENTO"
        };

        double[] prezzi =
        {
            24.9,
            9.9,
            39.5,
            29.9
        };

        int[] quantita =
        {
            2,
            1,
            1,
            1
        };

        double totaleLordo = 0;
        double totaleScontiCategoria = 0;
        double totaleNetto = 0;

        Console.WriteLine("RIEPILOGO ORDINE");
        Console.WriteLine("----------------");

        for (int i = 0; i < nomiProdotti.Length; i++)
        {
            double lordo = prezzi[i] * quantita[i];
            double sconto = CalcolaSconto(categorie[i], lordo);
            double netto = lordo - sconto;

            totaleLordo += lordo;
            totaleScontiCategoria += sconto;
            totaleNetto += netto;

            Console.WriteLine();
            Console.WriteLine(nomiProdotti[i]);
            Console.WriteLine($"Categoria: {categorie[i]}");
            Console.WriteLine($"Quantita: {quantita[i]}");
            Console.WriteLine($"Prezzo unitario: {Format(prezzi[i])} euro");
            Console.WriteLine($"Importo lordo riga: {Format(lordo)} euro");
            Console.WriteLine($"Sconto categoria: {Format(sconto)} euro");
            Console.WriteLine($"Importo netto riga: {Format(netto)} euro");
        }

        double scontoOrdine = CalcolaScontoOrdine(totaleScontiCategoria, totaleNetto);
        double spedizione = CalcolaSpedizione(totaleNetto);

        double totaleFinale = totaleNetto - scontoOrdine + spedizione;

        Console.WriteLine();
        Console.WriteLine("----------------------");
        Console.WriteLine($"Totale lordo: {Format(totaleLordo)} euro");
        Console.WriteLine($"Sconti categoria: {Format(totaleScontiCategoria)} euro");
        Console.WriteLine($"Sconto ordine: {Format(scontoOrdine)} euro");
        Console.WriteLine($"Spedizione: {Format(spedizione)} euro");
        Console.WriteLine($"Totale finale: {Format(totaleFinale)} euro");
    }

    static double CalcolaSconto(string categoria, double lordo)
    {
        switch (categoria)
        {
            case "ABBIGLIAMENTO":
                return lordo * 0.10;
            case "ACCESSORI":
                return lordo * 0.05;
            case "INTEGRATORI":
                return 0;
            default:
                return 0;
        }
    }

    static double CalcolaScontoOrdine(double scontiCategoria, double totaleNetto)
    {
        if (scontiCategoria >= 150)
            return totaleNetto * 0.08;

        return 0;
    }

    static double CalcolaSpedizione(double totaleNetto)
    {
        return totaleNetto >= 100 ? 0 : 0;
    }

    static string Format(double value)
    {
        return value.ToString();
    }
}