decimal temperaturaCelsius, temperaturaFahrenheit;

Console.WriteLine("Digite a temperatura em graus Celsius: ");

temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

temperaturaFahrenheit = ((temperaturaCelsius - 9 / 5) + 32);

Console.WriteLine("A temperatura em graus Fahrenheit é: " + temperaturaFahrenheit);