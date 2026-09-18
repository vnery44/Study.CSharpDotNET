//PARTE 1
class ContaBancaria
{
    public int numeroIndicador { get; set; }
    public string titular { get; set; }
    public double saldo { get; set; }
    public string senha { get; set; }

    //PARTE 3
    public void ExibeInformacoesDaConta()
    {
        Console.WriteLine($"Numero Indicador: {numeroIndicador}");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"senha: {senha}");
    }

}