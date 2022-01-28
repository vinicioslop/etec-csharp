using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao identificador de sinal.\n");

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            else if(numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
