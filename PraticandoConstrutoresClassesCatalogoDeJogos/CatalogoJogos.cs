class CatalogoJogos
{
    private List<Jogo> Jogos { get; set; }
    public bool CatalogoVazio => Jogos.Count == 0;
    public CatalogoJogos()
    {
        Jogos = new List<Jogo>();
    }
    public void AdicionarJogo(Jogo jogo)
    {
        Jogo novoJogo = new Jogo(jogo.Nome, jogo.Genero, jogo.AnoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{jogo.Nome}\" adicionado ao catálogo.");
    }
    /*// Método para adicionar um jogo ao catálogo
    public void AdicionarJogo(string nome, string genero, int anoLancamento) //<<<método de resposta do professor, achei que faz mais sentido da forma como fiz acima
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }*/
    public void ListarJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio.");
        }
        else
        {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }
}