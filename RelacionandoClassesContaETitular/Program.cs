Titular titular1 = new() {Nome = "Vinicius",Sobrenome = "Nery"};

Conta conta1 = new Conta();

conta1.AdicionaTitularAConta(titular1.Nome, titular1.Sobrenome);
conta1.Agencia = 7;
conta1.Numero = 78764;
conta1.Saldo = 6983.67;
conta1.Limite = 20000.00;

conta1.ExibeDetalhesDaConta();