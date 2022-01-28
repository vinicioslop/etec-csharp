using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double metros = 0;

            Console.Write("Entre com a medida (em metros): ");
            metros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n--- Equivalência ---");
            Console.WriteLine($"{metros*100} cm");
            Console.WriteLine($"{metros} m");
            Console.WriteLine($"{metros/1000} Km");
        }
    }
}
