namespace Models;

public class OrderItem
{
    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "";
    public decimal Prezzo { get; set; }
    public int Quantita { get; set; }
}
