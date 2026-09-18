class Jogo
{
    public string Nome { get; }
    public string Genero { get; }
    public int AnoLancamento { get; }

    public Jogo(string nome, string genero, int anoLancamento)
    {
        Nome = nome;
        Genero = genero;
        AnoLancamento = anoLancamento;
    }
}