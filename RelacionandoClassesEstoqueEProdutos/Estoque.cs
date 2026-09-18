class Estoque
{
    private List<Produto> produtos = new List<Produto>();
    //public string Nome { get; set; }
    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void ExibeProdutosEmEstoque()
    {
        Console.WriteLine("Lista de produtos neste estoque:\n");
        foreach (var prod in produtos) 
        {
            Console.WriteLine($"Produto: {prod.Nome}. Marca: {prod.Marca}.");
        }
    }
}