Estoque estoqueNorte = new();

Produto produto1 = new();
Produto produto2 = new();
Produto produto3 = new();

produto1.Nome = "Doritos";
produto1.Marca = "Elma Chips";

produto2.Nome = "Coca-Cola Zero";
produto2.Marca = "Coca-Cola";

produto3.Nome = "Chocolate Trento";
produto3.Marca = "Peccin SA";

estoqueNorte.AdicionarProduto(produto1);
estoqueNorte.AdicionarProduto(produto2);
estoqueNorte.AdicionarProduto(produto3);

estoqueNorte.ExibeProdutosEmEstoque();