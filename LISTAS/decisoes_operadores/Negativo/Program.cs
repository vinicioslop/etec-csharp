using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao verificador de números negativos.");

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero < 0)
                Console.WriteLine($"O {numero} é negativo!");
        }
    }
}
