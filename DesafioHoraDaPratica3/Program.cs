//DESAFIO 1
var alunos      = new Dictionary<string, List<double>>();
double soma     = 0;
double media    = 0;

//forma 1 de adicionar no dictionary
alunos.Add("Vinicius", new List<double> {8, 7, 6});
alunos.Add("Leticia", new List<double> {8.4, 7.3, 6.7});

//forma 2 de adicionar no dictionary
alunos["João"]  = new List<double> { 8.5, 9.0, 7.5 };
alunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

foreach (var aluno in alunos)
{
    for(int i = 0; i < aluno.Value.Count; i++)
    {
        soma += aluno.Value[i];
    }
    media = soma / aluno.Value.Count;
    Console.WriteLine($"A média do aluno(a) {aluno.Key} é: {media}");
}
//********************************************************************************************

//DESAFIO 2
//MINHA VERSÃO *******************************************************************************
var produtos = new Dictionary<string, int>();
string nomeProduto = "Mouse";

produtos["Mouse"]   = 50;
produtos["Teclado"] = 42;
produtos["Monitor"] = 13;

//Console.Write("Digite o nome do produto em estoque para ver a quantidade: ");
//nomeProduto = Console.ReadLine()!;

Console.WriteLine($"O produto {nomeProduto} possui estoque de {produtos[nomeProduto]}");
//********************************************************************************************

//VERSÃO DO PROFESSOR ************************************************************************
Dictionary<string, int> estoque = new Dictionary<string, int>
{
    { "camisetas", 50 },
    { "calças", 30 },
    { "tênis", 20 }
};

string produto = "camisetas";

if (estoque.ContainsKey(produto))
{
    Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]} unidades.");
}
else
{
    Console.WriteLine("Produto não encontrado no estoque.");
}
//********************************************************************************************

//DESAFIO 3
//MINHA VERSÃO *******************************************************************************
var perguntasRespostas = new Dictionary<string, string>();

perguntasRespostas["Quanto é 1 + 1?"] = "2";
perguntasRespostas["Quanto é 2 + 2?"] = "4";
perguntasRespostas["O que é clara e salgada, cabe em um olho e pesa uma tonelada?"] = "lágrima";

foreach( var pergunta in perguntasRespostas)
{
    Console.Write($"{pergunta.Key}: ");
    string resposta = Console.ReadLine()!;
    if (resposta.ToLower() == pergunta.Value.ToLower()) //torna os caracteres minúsculos nas strings com .ToLower() pra comparar igualmente
    {
        Console.WriteLine("Resposta certa!");
    }
    else
    {
        Console.WriteLine("Resposta ERADA!");
    }
}
//********************************************************************************************

//VERSÃO DO PROFESSOR ************************************************************************
Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    { "Qual é a capital do Brasil?", "Brasília" },
    { "Quanto é 7 vezes 8?", "56" },
    { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
    // Adicione mais perguntas e respostas conforme necessário
};

int pontuacao = 0;

foreach (var pergunta in perguntasERespostas)
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Sua resposta: ");
    string respostaUsuario = Console.ReadLine();

    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Correto!\n");
        pontuacao++;
    }
    else
    {
        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");
//********************************************************************************************

//DESAFIO 4
var usuarios = new Dictionary<string, string>
{
    { "user1", "senha123" },    //a forma que as aulas tem usado para adicionar os keys e values nos dictionary
    { "user2", "abc456" }
};

usuarios["user3"] = "senha789"; //particularmente prefiro dessa forma, acho melhor pra visualizar
usuarios["user4"] = "abc321";

string nomeUsuario = "user1";
string senha = "senha123";

if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
    Console.WriteLine("Login bem-sucedido!");
else
    Console.WriteLine("Nome de usuário ou senha incorretos.");

//********************************************************************************************