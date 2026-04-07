Console.WriteLine("Para calcular as medidas de uma caixa retangular, precisamos das seguintes medidas:");
Console.WriteLine("Comprimento, largura e altura");

Console.WriteLine("Por gentileza insira o comprimento:");
string strComprimento = Console.ReadLine();

decimal comprimento = Convert.ToDecimal(strComprimento);

Console.WriteLine("Por gentileza insira a largura:");
string strLargura = Console.ReadLine();

decimal largura = Convert.ToDecimal(strLargura);

Console.WriteLine("Por gentileza insira a altura:");
string strAltura = Console.ReadLine();

decimal altura = Convert.ToDecimal(strAltura);

decimal volume = comprimento * largura * altura;

Console.WriteLine($"O Volume da caixa é, " + volume);

Console.ReadLine();
