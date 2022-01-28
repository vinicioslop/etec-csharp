using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Máximo Divisor Comum (método iterativo)\n");

            Console.Write("Digite o 1º número (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2º número (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            int mdc = retornaMdc(a, b);

            Console.WriteLine($"\nMDC(a, b) = {mdc}");
        }

        static int retornaMdc(int a, int b)
        {
            int r = -1;

            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }
    }
}
