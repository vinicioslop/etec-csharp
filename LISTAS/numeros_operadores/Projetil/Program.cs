using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double velocidade, angulo, alcance, altura;

            const double g = 9.80665;
            const double pi = Math.PI;
            
            Console.WriteLine("-- Projétil --\n");
            
            Console.Write("Entre com a velocidade, em m/s..: ");
            velocidade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com o ângulo, em graus....: ");
            angulo = Convert.ToDouble(Console.ReadLine());

            alcance = ((Math.Pow(velocidade, 2))*(Math.Sin((angulo*2) * pi / 180)))/g;
            altura = (Math.Pow((velocidade * Math.Sin(angulo * pi / 180)), 2)/(2*g));

            Console.WriteLine($"\nAlcance........: {alcance.ToString("N2")}");
            Console.WriteLine($"Altura máxima..: {altura.ToString("N2")}");
        }
    }
}
