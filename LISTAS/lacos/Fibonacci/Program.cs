using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequência de Fibonacci");

            Console.Write("Quantos termos (>=2)? ");
            int limite = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < limite; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{i} ");
                    continue;
                }
                
                Console.Write($"{Fib(i)} ");
            }
        }

        static int Fib(int n)
        {
            int ant = 0, fib = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    fib = 1;
                    ant = 0;
                }
                else
                {
                    fib += ant;
                    ant = fib - ant;
                }
            }

            return fib;
        }
    }
}
