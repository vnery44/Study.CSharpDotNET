namespace HerancaProdutosEletronicos.ProdutosEletronicos;

internal class Laptop : ProdutoEletronico
{
    public string Processador {  get; set; }
    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Processador: {Processador}";
    }
}
