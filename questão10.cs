using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor em reais: ");
        double valorReais = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de câmbio (reais por dólar): ");
        double taxaCambio = Convert.ToDouble(Console.ReadLine());

        double valorDolares = valorReais / taxaCambio;

        Console.WriteLine($"O valor convertido em dólares é: {valorDolares:F2}");
    }
}
