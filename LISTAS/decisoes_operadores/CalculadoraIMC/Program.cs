using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;
            
            Console.WriteLine("--Calculadora de IMC --");

            Console.Write("Digite seu peso em kg...: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em m..: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é {imc:N2} kg / m².");
            Console.Write("Diagnóstico: ");

            if(imc < 17.00)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc < 18.50)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25.00)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30.00)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc < 35.00)
            {
                Console.WriteLine("Obesidade I");
            }
            else if (imc < 40.00)
            {
                Console.WriteLine("Obesidade II (severa)");
            }
            else
            {
                Console.WriteLine("Obesidade III (mórbida)");
            }
        }
    }
}
