namespace HerancaProdutosEletronicos.ProdutosEletronicos;

internal class SmartPhone : ProdutoEletronico
{
    public string SistemaOperacional { get; set; }
    public override string ExibirInformacoes()
    {
        return $"{base.ExibirInformacoes()}, Sistema Operacional: {SistemaOperacional}";
    }
}
