Console.WriteLine("Para calcular a autonomia por KM Precisamos dos seguintes dados!");

Console.WriteLine("Km de partida, Km de chegada e quantos litros foram gastos!");

Console.WriteLine("Insira o Km de Partida!");

string strKmPartida = Console.ReadLine();

decimal kmPartida = Convert.ToDecimal(strKmPartida);

Console.WriteLine("Insira o Km de chegada!");

string strKmChegada = Console.ReadLine();

decimal kmChegada = Convert.ToDecimal(strKmChegada);

Console.WriteLine("Insira quantos litros foram gastos!");

string strConsumo = Console.ReadLine();

decimal consumo = Convert.ToDecimal(strConsumo);

decimal kmPercorrido = kmChegada - kmPartida;

decimal autonomia = kmPercorrido / consumo;

Console.WriteLine($"A autonomia do carro foi de: " + autonomia);
