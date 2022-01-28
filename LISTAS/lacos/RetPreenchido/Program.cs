using System;

namespace RetPreenchido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamanho do retângulo:");

            Console.Write("Largura: ");
            int largura = Int32.Parse(Console.ReadLine());

            Console.Write("Altura.: ");
            int altura = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int x = 0; x < altura; x++)
            {
                for (int y = 0; y < largura; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
