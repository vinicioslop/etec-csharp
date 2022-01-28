using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double salario;
            decimal fgts;
            
            Console.WriteLine("Bem vindo ao cálculo de IMC!\n");

            Console.Write("Salário (R$)..: ");
            salario = Convert.ToDouble(Console.ReadLine());

            fgts = Convert.ToDecimal(salario * 0.08);

            Console.WriteLine($"\nFGTS: {fgts.ToString("C")}");
        }
    }
}
