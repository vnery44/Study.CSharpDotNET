using Alura.Filmes;

Filme filme1 = new("Odisséia", 172, new List<string> { "Matt Damon", "Anne Hathaway", "Tom Holland", "Zendaya" });
Filme filme2 = new("Interestelar", 169, new List<string> { "Matthew McConaughey", "Anne Hathaway" });
Filme filme3 = new("Bastardos Inglórios", 153, new List<string> { "Brad Pitt", "Christoph Waltz" });
Filme filme4 = new ("O Poderoso Chefão", 175, new List<string> { "Marlon Brando", "Al Pacino", "James Caan" });
Filme filme5 = new ("Batman: O Cavaleiro das Trevas", 152, new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" });

List<Filme> filmesFavoritos = new();

filmesFavoritos.Add(filme1);
filmesFavoritos.Add(filme2);
filmesFavoritos.Add(filme3);
filmesFavoritos.Add(filme4);
filmesFavoritos.Add(filme5);

foreach (Filme fil in filmesFavoritos)
{
    Console.WriteLine($"Filme: {fil.Titulo}");
    Console.WriteLine($"Duracao: {fil.Duracao}");
    fil.ListarElenco();
    Console.WriteLine();
}