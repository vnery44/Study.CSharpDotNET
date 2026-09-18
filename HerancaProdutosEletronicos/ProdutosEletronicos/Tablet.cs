namespace HerancaProdutosEletronicos.ProdutosEletronicos;

internal class Tablet : ProdutoEletronico
{
    public string TipoTela { get; set; }
    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Tela: {TipoTela}";
    }
}
