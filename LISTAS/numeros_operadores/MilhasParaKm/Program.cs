using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double milhas;
            
            Console.WriteLine("Bem vindo ao conversor de milhas em kilometros!\n");

            Console.Write("Entre com a medida (em milhas): ");
            milhas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n{milhas} milha(s) equivale a {milhas * 1.609} Km.");
        }
    }
}
