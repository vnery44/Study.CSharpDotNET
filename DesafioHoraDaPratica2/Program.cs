//DESAFIO 1
//MINHA SOLUÇÃO *************************************************************

Console.Write("\nDigite o primeiro numero: ");
string primeiroNumero = Console.ReadLine()!;
float numericoA = float.Parse(primeiroNumero);

Console.Write("\nDigite o segundo numero: ");
string segundoNumero = Console.ReadLine()!;
float numericoB = float.Parse(segundoNumero);

void QuatroOperacoesBasicas()
{
    float adicaoAB = numericoA + numericoB;
    float subtracaoAB = numericoA - numericoB;
    float divisaoAB = numericoA / numericoB;
    float multiplicaAB = numericoA * numericoB;

    Console.WriteLine($"\nadição de A e B é: {adicaoAB}");
    Console.WriteLine($"subtração de A e B é: {subtracaoAB}");
    Console.WriteLine($"divisão de A e B é: {divisaoAB}");
    Console.WriteLine($"multiplicação de A e B é: {multiplicaAB}");
}

QuatroOperacoesBasicas();
//***************************************************************************

//SOLUÇÃO DO PROFESSOR ******************************************************
void ExibirQuatroOperacoes()
{

    float a = 4;
    float b = 8;

    float soma = a + b;
    float subtracao = a - b;
    float divisao = a / b;
    float multiplicacao = a * b;

    Console.WriteLine($"a + b = {soma}");
    Console.WriteLine($"a - b = {subtracao}");
    Console.WriteLine($"a / b = {divisao}");
    Console.WriteLine($"a * b = {multiplicacao}");
}

ExibirQuatroOperacoes();
//***************************************************************************

//DESAFIO 2
//MINHA SOLUÇÃO *************************************************************

List<string> bandasFavoritas = new List<string> ();

bandasFavoritas.Add("Slipknot");
bandasFavoritas.Add("Bring Me The Horizon");
bandasFavoritas.Add("Metallica");
bandasFavoritas.Add("Bad Omens");
bandasFavoritas.Add("A Day To Remember");
//SOLUÇÃO DO PROFESSOR FOI IDENTICA
//***************************************************************************

//DESAFIO 3
//MINHA SOLUÇÃO *************************************************************

for (int i = 0; i < bandasFavoritas.Count; i++)
{
    Console.WriteLine($"Banda: {bandasFavoritas[i]}");
}
//SOLUÇÃO DO PROFESSOR FOI IDENTICA
//***************************************************************************

//DESAFIO 4
//MINHA SOLUÇÃO *************************************************************

List<int> elementosInteiros = new List<int> ();
int somaDosElementos = 0;

elementosInteiros.Add(5);
elementosInteiros.Add(7);
elementosInteiros.Add(10);
elementosInteiros.Add(17);

foreach (int elemento in elementosInteiros)
{
    somaDosElementos += elemento;
}

Console.WriteLine($"A soma dos elementos inteiros é: {somaDosElementos}");
//***************************************************************************

//SOLUÇÃO DO PROFESSOR ******************************************************

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 }; 
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma}");

//***************************************************************************
