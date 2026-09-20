//DESAFIO 1
int notaMedia = 6;

if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}

//DESAFIO 2
string nomeAluno = "Fausto Silva";

Console.WriteLine($"Olá, {nomeAluno}!");

//DESAFIO 3
string VerificarNumero(int numero)
{
    if (numero > 0)
    {
        return "Positivo";
    }
    else if (numero < 0)
    {
        return "Negativo";
    }
    else
    {
        return "Zero";
    }
}

// Exemplo de uso:
Console.WriteLine(VerificarNumero(10));
Console.WriteLine(VerificarNumero(-3));
Console.WriteLine(VerificarNumero(0));

//DESAFIO 4
List<string> marcas = new List<string>
{
    "Chevrolet",
    "Toyota",
    "Volkswagen",
    "Honda",
    "Ford"
};

Console.Write("Digite a posição da marca que deseja consultar: ");
int n = int.Parse(Console.ReadLine());

if (n >= 1 && n <= marcas.Count)
{
    Console.WriteLine($"A marca na posição {n} é: {marcas[n - 1]}"); //O -1 SERVINDO PARA O INDICE (PARA O USUARIO) COMEÇAR EM 1 E NÃO 0 
}
else
{
    Console.WriteLine("Posição inválida!");
}

