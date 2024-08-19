using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo para gerar a sequência de Fibonacci: ");
        int n;

        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n <= 0)
            {
                Console.WriteLine("Por favor, insira um número maior que zero.");
                return;
            }

            int a = 0;
            int b = 1;

            Console.Write("Sequência de Fibonacci: ");
            while (a <= n)
            {
                Console.Write(a + " ");
                int proximo = a + b;
                a = b;
                b = proximo;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        }
    }
}