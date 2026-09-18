class Conta
{
    private Titular titular = new Titular();
    public int Agencia {  get; set; }
    public int Numero { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public void AdicionaTitularAConta(string nome, string sobrenome)
    {
        titular.Nome = nome;
        titular.Sobrenome = sobrenome;
    }

    public void ExibeDetalhesDaConta()
    {
        Console.WriteLine($"Detalhamento da conta:\n");
        Console.WriteLine($"Titular: {titular.Nome} {titular.Sobrenome}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Numero da conta: {Numero}");
        Console.WriteLine($"Saldo da Conta: {Saldo}");
        Console.WriteLine($"Limite disponível: {Limite}");
    }
}