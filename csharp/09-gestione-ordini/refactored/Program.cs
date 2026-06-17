using Models;
using Services;

class Program
{
    static void Main()
    {
        var items = new[]
        {
            new OrderItem { Nome="T-Shirt tecnica", Categoria="ABBIGLIAMENTO", Prezzo=24.9m, Quantita=2 },
            new OrderItem { Nome="Borraccia", Categoria="ACCESSORI", Prezzo=9.9m, Quantita=1 },
            new OrderItem { Nome="Proteine whey", Categoria="INTEGRATORI", Prezzo=39.5m, Quantita=1 },
            new OrderItem { Nome="Pantaloncini", Categoria="ABBIGLIAMENTO", Prezzo=29.9m, Quantita=1 }
        };

        var service = new OrderService();
        service.ElaboraOrdine(items);
    }
}
