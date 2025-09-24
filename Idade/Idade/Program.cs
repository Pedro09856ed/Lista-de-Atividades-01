using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha a faixa etária para classificação:");
        Console.WriteLine("1 - Criança");
        Console.WriteLine("2 - Adolescente");
        Console.WriteLine("3 - Adulto");
        Console.WriteLine("4 - Idoso");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        switch (opcao)
        {
            case 1: 
                if (idade >= 0 && idade <= 12)
                {
                    Console.WriteLine("Você é uma criança.");
                }
                else
                {
                    Console.WriteLine("Idade incompatível com a faixa escolhida.");
                }
                break;

            case 2:
                if (idade >= 13 && idade <= 17)
                {
                    Console.WriteLine("Você é um adolescente.");
                }
                else
                {
                    Console.WriteLine("Idade incompatível com a faixa escolhida.");
                }
                break;

            case 3:
                if (idade >= 18 && idade <= 59)
                {
                    Console.WriteLine("Você é um adulto.");
                }
                else
                {
                    Console.WriteLine("Idade incompatível com a faixa escolhida.");
                }
                break;

            case 4:
                if (idade >= 60)
                {
                    Console.WriteLine("Você é um idoso.");
                }
                else
                {
                    Console.WriteLine("Idade incompatível com a faixa escolhida.");
                }
                break;

            default:
                Console.WriteLine("Opção inválida. Escolha entre 1 e 4.");
                break;
        }
        Console.WriteLine("Programa finalizado.");
    }
}
