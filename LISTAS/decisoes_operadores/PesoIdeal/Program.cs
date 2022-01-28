using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            string sexo;

            Console.Write("Digite sua altura em m..........: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sexo [M]asculino / [F]eminino...: ");
            sexo = Console.ReadLine();

            sexo = sexo.ToUpper();

            Console.Write("\nSeu peso ideal é ");

            switch (sexo)
            {
                case "M":
                    var pesoIdealM = altura * 72.7 - 58.0;
                    Console.WriteLine($"{pesoIdealM:N1}");
                    break;
                case "F":
                    var pesoIdealF = altura * 62.1 - 44.7;
                    Console.WriteLine($"{pesoIdealF:N1}");
                    break;
            }
        }
    }
}
