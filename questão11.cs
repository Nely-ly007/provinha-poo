using System;

class Program
{
    static long CalcularFatorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("O fatorial não está definido para números negativos.");
        }
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * CalcularFatorial(n - 1);
    }

    static void Main()
    {
        try
        {
            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            long fatorial = CalcularFatorial(numero);

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        }
    }
}