using Models;

namespace Services;

public static class OrderCalculator
{
    public static decimal CalcolaLordo(OrderItem item)
    {
        return item.Prezzo * item.Quantita;
    }

    public static decimal CalcolaScontoCategoria(OrderItem item, decimal lordo)
    {
        return item.Categoria switch
        {
            "ABBIGLIAMENTO" => lordo * 0.10m,
            "ACCESSORI" => lordo * 0.05m,
            "INTEGRATORI" => 0m,
            _ => 0m
        };
    }

    public static decimal CalcolaScontoOrdine(decimal totaleSconti, decimal totaleNetto)
    {
        return totaleSconti >= 150m ? totaleNetto * 0.08m : 0m;
    }

    public static decimal CalcolaSpedizione(decimal totaleNetto)
    {
        return totaleNetto >= 100m ? 0m : 7.90m;
    }
}
