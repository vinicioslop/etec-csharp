using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double n1, n2;

            Console.WriteLine("Cálculo da soma entre dois números.\n");

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número.: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nA soma de {n1} + {n2} é igual a: {n1+n2}\n");
        }
    }
}
