List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// for: recomendado quando precisamos acessar o índice/posição dos elementos ou controlar a iteração através de um índice numérico.
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // Verifica se o número é par, operador de módulo (%) verifica o resto da divisão
    {
        Console.WriteLine(numeros[i]);
    }
}

// foreach: recomendado quando só precisamos percorrer os elementos da coleção, sem precisar acessar o índice. É mais simples e legível.
foreach (int numero in numeros)
{
    if (numero % 2 == 0) // operador de módulo (%) verifica o resto da divisão
    {
        Console.WriteLine(numero);
    }

}