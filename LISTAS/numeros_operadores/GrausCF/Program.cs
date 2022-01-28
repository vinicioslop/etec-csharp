using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int graus;
            double fahren;

            Console.WriteLine("Bem vindo ao conversor de Graus Celsius para Fahrenheit!\n");

            Console.Write("Digite a temperatura em graus: ");
            graus = Convert.ToInt32(Console.ReadLine());

            fahren = (graus * 1.8) + 32;

            Console.WriteLine($"{graus}°C equivalem a {fahren}°F\n");
        }
    }
}
