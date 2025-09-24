using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora de Par ou Ímpar ===");
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é PAR.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é ÍMPAR.");
        }
        Console.WriteLine("Programa finalizado.");
    }
}
