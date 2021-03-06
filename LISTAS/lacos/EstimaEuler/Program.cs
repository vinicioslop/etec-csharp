using System;

namespace EstimaEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            double euler = 0;

            Console.WriteLine("-- Estimador de Euler --");

            Console.Write("Quantas iterações (<=33)? ");
            double iteracoes = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < interacoes; i++)
            {
                euler += 1/retornaFat(i);
            }

            Console.WriteLine($"Estimativa: {euler:N10}");
        }

        static double retornaFat(int valor)
        {
            double fat = 1;

            if (valor > 0)
            {
                for (int i = 2; i <= valor; i++)
                {
                    fat *= i;
                }
            }

            return fat;
        }
    }
}
