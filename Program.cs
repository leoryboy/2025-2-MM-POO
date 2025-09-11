Televisao tv = new Televisao(55f);

Console.WriteLine($" TV de {tv.Tamanho} polegadas criada!");

// Liga a TV
tv.Ligar();
Console.WriteLine($"TV ligada no canal {tv.Canal} com volume {tv.Volume}");

// Testando controle de volume
tv.AumentarVolume();
tv.AumentarVolume();
Console.WriteLine($" Volume após aumentar: {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($" Volume após diminuir: {tv.Volume}");

tv.AtivarMudo();
tv.AumentarVolume(); // não deve aumentar
Console.WriteLine($" Volume com mudo ativado: {tv.Volume}");

tv.DesativarMudo();
tv.AumentarVolume();
Console.WriteLine($" Volume após tirar mudo: {tv.Volume}");

// Testando controle de canais
tv.IrParaCanal(100);
Console.WriteLine($" Canal atual: {tv.Canal}");

tv.AvancarCanal();
Console.WriteLine($" Canal avançado: {tv.Canal}");

tv.VoltarCanal();
Console.WriteLine($" Canal voltado: {tv.Canal}");

// Desliga a TV
tv.Desligar();
Console.WriteLine(" TV desligada.");
