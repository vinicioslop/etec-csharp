using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tabuada do Número: ");
            int numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            
            for(int i=1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
        }
    }
}
