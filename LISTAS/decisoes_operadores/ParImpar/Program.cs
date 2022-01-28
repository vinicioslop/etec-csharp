using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{numero} é ");

            if(numero % 2 == 0)
                Console.WriteLine("par");
            else
                Console.WriteLine("ímpar");
        }
    }
}
