using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos patinhos foram passear? ");
            int qtPatinhos = Int32.Parse(Console.ReadLine());

            for (int i = qtPatinhos-1; i >= 0; i--)
            {
                Console.WriteLine("\nA mamãe patinha foi procurar");
                Console.WriteLine("Além das montanhas");
                Console.WriteLine("Na beira do mar");
                Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");

                if (i != 0 && i % 2 == 0)
                {
                    Console.WriteLine($"Mas só {i} patinhos voltaram de lá.");
                }
                else if(i % 2 != 0)
                {
                    Console.WriteLine($"Mas só {i} patinho voltou de lá.");
                }
                else
                {
                    Console.WriteLine($"Mas nenhum patinho voltou de lá.");
                }
            }

            Console.WriteLine("\nA mamãe patinha foi procurar");
            Console.WriteLine("Além das montanhas");
            Console.WriteLine("Na beira do mar");
            Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
            Console.WriteLine($"E os {qtPatinhos} patinhos voltaram de lá.");
        }
    }
}
