using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Números pares entre 0 e ? ");
            int limite = Int32.Parse(Console.ReadLine());

            for (int num = 0; num < limite; num += 2)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
