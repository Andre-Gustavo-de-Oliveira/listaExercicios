Console.WriteLine("Calculadora de Salário de Vendedores");

Console.Write("Digite o salário base: ");

double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o total de vendas: ");

double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o percentual de comissão (%): ");

double percentualComissao = Convert.ToDouble(Console.ReadLine());

double salarioTotal = salarioBase + (totalVendas * percentualComissao / 100);

Console.WriteLine($"O salário total é: R$ {salarioTotal:F2}");