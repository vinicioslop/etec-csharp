using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aperte uma tecla para iniciar a contagem!");
            Console.ReadKey();
            Console.WriteLine("3...");

            Console.WriteLine("Mais uma vez");
            Console.ReadKey();
            Console.WriteLine("2...");

            Console.WriteLine("De novo, prometo que é a última vez");
            Console.ReadKey();
            Console.WriteLine("1...");
            Console.WriteLine("0. Disse que era á última");
        }
    }
}
