using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerador, denominador;
            double resultado;

            Console.WriteLine("Bem vindo ao calculo de Divisao.\n");

            Console.Write("Digite o numerador..: ");
            numerador = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o denominador: ");
            denominador = Convert.ToInt32(Console.ReadLine());

            if (denominador == 0)
            {
                Console.WriteLine("\nNão é possível dividir por 0.");
            }
            else
            {
                resultado = numerador / denominador;

                Console.WriteLine($"\n{numerador} dividido {denominador} é {resultado}");
            }
        }
    }
}
