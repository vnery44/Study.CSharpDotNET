class Produto
{
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Preco 
    { 
        get => preco; 
        set
        {
            if(value < 0)
            {
                Console.WriteLine("O preço não pode ser negativo!");
            }
            else
            {
                preco = value;
            }
        } 
    }
    public int Estoque 
    { 
        get => estoque; 
        set
        {
            if (value < 0)
            {
                Console.WriteLine("O estoque não pode ser negativo!");
            }
            else 
            {
                estoque = value;
            }
        }
    }
    public string ExibeInfosDoProduto => $"Informações do produto: {this.Marca} {this.Nome} {this.Preco} {this.Estoque}";
}