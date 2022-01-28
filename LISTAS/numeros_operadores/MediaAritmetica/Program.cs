using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double n1, n2, n3, media;
            
            Console.WriteLine("Média Aritmética de 3 números.\n");

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número.: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o terceito número: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = (n1+n2+n3)/3;

            Console.WriteLine($"\nMédia: {media.ToString("N1")}");
        }
    }
}
