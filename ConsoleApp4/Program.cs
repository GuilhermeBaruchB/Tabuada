using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número para a tabuada: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira a quantidade de vezes desejada: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabuada do número {numero}:");

        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }

        Console.ReadKey();
    }
}
