using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura = 0, altura = 0;
            bool valido = false;

            Console.WriteLine("Tamanho do Retângulo:");

            do
            {
                Console.Write("Largura..: ");
                largura = Int32.Parse(Console.ReadLine());

                Console.Write("Altura...: ");
                altura = Int32.Parse(Console.ReadLine());

                if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
                {
                    Console.WriteLine("\nDados inserido são inválidos!");
                    Console.WriteLine("Valores precisam estar entre 1 e 10.\n");
                }
                else
                {
                    valido = true;
                }
            } while (!valido);

            Console.WriteLine();
            
            for (int x = 0; x < altura; x++)
            {
                for (int y = 0; y < largura; y++)
                {
                    if (x == 0 || x == (altura - 1))
                    {
                        Console.Write("*");
                    }
                    else if (y == 0 || y == (largura - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
