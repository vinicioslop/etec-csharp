using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media;
            bool valido = true;
            string resultado;

            Console.WriteLine("-- Média --\n");
            Console.WriteLine("Digite as suas notas abaixo.");

            Console.Write("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            if(n1 < 0 || n1 > 10)
                valido = false;

            if(n2 < 0 || n2 > 10)
                valido = false;

            if(n3 < 0 || n3 > 10)
                valido = false;

            if(n4 < 0 || n4 > 10)
                valido = false;

            if(valido)
            {
                media = (n1 + n2 + n3 + n4) / 4;
                
                if(media < 5.0)
                {
                    resultado = "Reprovado";
                }
                else if (media <= 6.0)
                {
                    resultado = "Em recuperação";
                }
                else
                {
                    resultado = "Aprovado";
                }

                Console.WriteLine($"\nVocê ficou com média {media:N1}. Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("\nDigite somente notas entre 0 e 10.");
            }
        }
    }
}
