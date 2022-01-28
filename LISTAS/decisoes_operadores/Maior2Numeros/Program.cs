using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Bem vindo ao calculo de Maior.\n");

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2)
            {
                Console.WriteLine($"\n{n1} é maior que {n2}");
            }
            else
            {
                Console.WriteLine($"\n{n2} é maior que {n1}");
            }
        }
    }
}
