using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double lado1, lado2, lado3, semi, area;
            
            Console.WriteLine("Digite os lados do triângulo desejado.\n");

            Console.Write("Lado 1..: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 2..: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 3..: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            semi = (lado1 + lado2 + lado3) / 2;
            area = Math.Sqrt((semi*(semi - lado1)*(semi - lado2)*(semi - lado3)));

            Console.WriteLine($"\nSemiperímetro..: {semi:N2}");
            Console.WriteLine($"Área...........: {area:N2}");
        }
    }
}
