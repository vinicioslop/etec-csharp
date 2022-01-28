using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2, delta;

            Console.WriteLine("Bem vindo ao cálculo de Bharkara.\n");

            Console.Write("Informe o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("\nNão é uma equação de segundo grau!");
                return;
            }

            delta = (b * b) - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine($"\nComo delta = {delta} é menor que 0, a equação não possui raízes reais!");
                return;
            }

            x1 = ((-b + Math.Sqrt(delta))/(2 * a));
            x2 = ((-b - Math.Sqrt(delta))/(2 * a));

            Console.WriteLine($"\nx1 = {x1:N2} e x2 = {x2:N2}");
        }
    }
}
