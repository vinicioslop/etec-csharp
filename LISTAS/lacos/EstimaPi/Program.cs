using System;

namespace EstimaPi
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0.0;
            double aux = 3;

            Console.WriteLine("-- Estimador do valor de pi pelo método de Leibniz --");

            Console.Write("Quantas iterações? ");
            int iteracoes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < iteracoes - 1; i++)
            {
                if (i % 2 == 0)
                {
                    pi += 1 / aux;
                    aux += 2;
                }
                else
                {
                    pi -= 1 / aux;
                    aux += 2;
                }
            }

            pi = pi - 1;
            pi = pi * 4;
            pi = pi*(-1);

            Console.WriteLine($"Estimativa: {pi:N6}");
        }
    }
}
