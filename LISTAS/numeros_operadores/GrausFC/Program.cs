using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double fahren, graus;

            Console.WriteLine("Bem vindo ao conversor de Fahrenheit Celsius para Graus!\n");

            Console.Write("Digite a temperatura em Fahrenheit: ");
            fahren = Convert.ToDouble(Console.ReadLine());

            graus = (fahren - 32) / 1.8;

            Console.WriteLine($"{fahren}°F equivalem a {graus.ToString("N2")}°C\n");
        }
    }
}
