// Random é uma classe da biblioteca padrão do .NET usada para gerar valores pseudoaleatórios.
Random aleatorio = new Random();

// Next(1, 101) gera um número inteiro entre 1 e 100.
// Next(min, max): min é inclusivo (é considerado) e max é exclusivo (não é considerado).
// Next() é um método da classe Random que retorna um número inteiro pseudoaleatório.
int numeroSecreto = aleatorio.Next(1, 101); 

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    // Na primeira tentativa, usei switch, porém os valores dos cases precisam ser CONSTANTES e não VARIÁVEIS.
    // Como numeroSecreto é uma variável, usamos if para comparar seu valor com a variável chute.
    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número!");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }
} while(true);


Console.WriteLine("O jogo acabou. Você acertou o número secreto!");