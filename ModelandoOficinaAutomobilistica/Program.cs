using ModelandoOficinaAutomobilistica.Modelos;

Veiculo carro1 = new Veiculo("Chevrolet", "Onix", 2021, "FAT5L35");
Cliente cliente1 = new Cliente("Vinicius", "666 UM TAPA NA OREIA");
Mecanico mecanico1 = new Mecanico("Nelsinho", "Funileiro");
Oficina oficinaDoNelsinho = new();

oficinaDoNelsinho.AgendarServico(carro1, cliente1, mecanico1, "25/09/2030");
oficinaDoNelsinho.RealizarServico(carro1, mecanico1);