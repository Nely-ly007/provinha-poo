using System;

class Program
{
    static void OrdenarNomes(string[] nomes)
    {
        int n = nomes.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(nomes[j], nomes[j + 1]) > 0)
                {
                    string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Quantos nomes você deseja inserir? ");
        int quantidade;

        if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade > 0)
        {
            string[] nomes = new string[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            OrdenarNomes(nomes);
            
            Console.WriteLine("\nLista de nomes ordenada:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
        }
    }
}