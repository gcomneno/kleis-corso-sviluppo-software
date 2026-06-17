using Models;

namespace Services;

public class OrderService
{
    public void ElaboraOrdine(OrderItem[] items)
    {
        decimal totaleLordo = 0;
        decimal totaleSconti = 0;
        decimal totaleNetto = 0;

        Console.WriteLine("RIEPILOGO ORDINE");
        Console.WriteLine("----------------");

        foreach (var item in items)
        {
            if (!IsValid(item))
                continue;

            decimal lordo = OrderCalculator.CalcolaLordo(item);
            decimal sconto = OrderCalculator.CalcolaScontoCategoria(item, lordo);
            decimal netto = lordo - sconto;

            totaleLordo += lordo;
            totaleSconti += sconto;
            totaleNetto += netto;

            Stampa(item, lordo, sconto, netto);
        }

        decimal scontoOrdine = OrderCalculator.CalcolaScontoOrdine(totaleSconti, totaleNetto);
        decimal spedizione = OrderCalculator.CalcolaSpedizione(totaleNetto);

        decimal totaleFinale = totaleNetto - scontoOrdine + spedizione;

        Console.WriteLine("\n----------------------");
        Console.WriteLine($"Totale lordo: {totaleLordo}");
        Console.WriteLine($"Sconti categoria: {totaleSconti}");
        Console.WriteLine($"Sconto ordine: {scontoOrdine}");
        Console.WriteLine($"Spedizione: {spedizione}");
        Console.WriteLine($"Totale finale: {totaleFinale}");
    }

    private bool IsValid(OrderItem item)
    {
        return !string.IsNullOrWhiteSpace(item.Nome)
            && !string.IsNullOrWhiteSpace(item.Categoria)
            && item.Prezzo > 0
            && item.Quantita > 0;
    }

    private void Stampa(OrderItem item, decimal lordo, decimal sconto, decimal netto)
    {
        Console.WriteLine($"\n{item.Nome}");
        Console.WriteLine($"Categoria: {item.Categoria}");
        Console.WriteLine($"Quantita: {item.Quantita}");
        Console.WriteLine($"Prezzo unitario: {item.Prezzo}");
        Console.WriteLine($"Importo lordo riga: {lordo}");
        Console.WriteLine($"Sconto categoria: {sconto}");
        Console.WriteLine($"Importo netto riga: {netto}");
    }
}
