using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double altura, peso, imc;
            
            Console.WriteLine("Bem vindo ao cálculo de IMC.\n");

            Console.Write("Altura (m)..: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Peso (kg)...: ");
            peso = Convert.ToDouble(Console.ReadLine());

            imc = peso / (Math.Pow(altura, 2));

            Console.Write($"\nIMC........: {imc.ToString("N1")} kg/m²");
        }
    }
}
