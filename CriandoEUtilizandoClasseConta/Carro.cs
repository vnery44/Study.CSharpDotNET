//PARTE 4
class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano 
    { 
        get => Ano ; 
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            { 
                Ano = value;
            }    
        } 
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade = 0;
    public string DescricaoDetalhada => $"Informações do carro: {this.Fabricante} {this.Modelo} {this.Ano}";

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {this.Fabricante} {this.Modelo}, {this.QuantidadePortas} portas, {this.Ano}");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidade < 100)
        {
            Velocidade = Velocidade + 5;
        }
    }

    public void Frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade = Velocidade - 5;
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}
