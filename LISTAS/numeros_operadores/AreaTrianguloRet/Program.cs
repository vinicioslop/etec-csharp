using System;

namespace AreaTrianguloTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double baseTriangulo = 0;
            double alturaTriangulo = 0;
            double areaTriangulo = 0;
            
            Console.WriteLine("Bem vindo ao cálculo da área de um triangulo retângulo.\n");

            Console.Write("Digite o valor da base..: ");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da altura: ");
            alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            areaTriangulo = (baseTriangulo*alturaTriangulo)/2;

            Console.WriteLine($"Área do triângulo retângulo: {areaTriangulo}");
        }
    }
}
