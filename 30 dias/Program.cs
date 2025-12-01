using System;
class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;


        while (continuar)
        {
            Console.WriteLine("Verificador de Número Primo");
            Console.Write("Digite um número inteiro: ");


            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Entrada inválida. Tente novamente.\n");
                continue;
            }


            if (EhPrimo(numero))
                Console.WriteLine($"{numero} É um número primo!");
            else
                Console.WriteLine($"{numero} NÃO é um número primo.");


            Console.Write("\nDeseja verificar outro número? (s/n): ");
            continuar = Console.ReadLine().ToLower() == "s";


            Console.Clear();
        }


        Console.WriteLine("Encerrando o programa. Até mais!");
    }


    static bool EhPrimo(int n)
    {
        if (n <= 1)
            return false;


        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }


        return true;
    }
}