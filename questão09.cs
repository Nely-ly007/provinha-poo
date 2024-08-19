using System;

class Program
{
    static void Main()
    {
        double soma = 0;
        double numero;

        Console.WriteLine("Digite números para somar. Digite 0 para encerrar.");

        do
        {
            Console.Write("Digite um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero != 0)
            {
                soma += numero;
            }

        } while (numero != 0);

        Console.WriteLine($"A soma de todos os números digitados é: {soma}");
    }
}