namespace InterfacesPagavel.Modelos;

internal class Produto : IPagavel
{
    public string Nome { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public decimal CalcularPagamento() 
    {
        return PrecoUnitario * Quantidade;
    }
}
