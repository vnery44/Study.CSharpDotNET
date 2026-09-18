//PARTE 2
ContaBancaria conta1 = new ContaBancaria();

conta1.titular = "Vinicius Nery";
conta1.saldo = 55783.61;

Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Saldo: {conta1.saldo}");

ContaBancaria conta2 = new ContaBancaria();

conta2.numeroIndicador = 2;
conta2.titular = "Leticia Lucena";
conta2.saldo = 909159.90;
conta2.senha = "AmoMuitoOVinicius9090##";

conta2.ExibeInformacoesDaConta();
