namespace HerancaProdutosEletronicos.ProdutosEletronicos;

internal class ProdutoEletronico
{
    public string Modelo { get; set; }
    public double Preco { get; set; }
    public virtual string ExibirInformacoes()
    {
        return $"Modelo {Modelo}, Preço {Preco:C}";
    }
}
