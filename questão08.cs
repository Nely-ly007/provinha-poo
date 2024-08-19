using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double maior = num1;
        double menor = num1;

        if (num2 > maior)
        {
            maior = num2;
        }
        if (num3 > maior)
        {
            maior = num3;
        }

        if (num2 < menor)
        {
            menor = num2;
        }
        if (num3 < menor)
        {
            menor = num3;
        }

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
    }
}
