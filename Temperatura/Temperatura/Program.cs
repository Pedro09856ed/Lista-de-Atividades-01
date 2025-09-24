using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha a conversão:");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit + "°F");
        }
        else if (opcao == 2)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperatura em Celsius: " + celsius + "°C");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}