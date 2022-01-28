using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, media = 0, menor = 0, maior = 0;

            Console.Write("Informe a quantidade número para calcular: ");
            int quantidade = Int32.Parse(Console.ReadLine());

            double[] notas = new double[quantidade];

            Console.WriteLine();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Informe a Nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            soma = RetornaSoma(notas, quantidade);
            media = RetornaMedia(notas, quantidade);
            menor = RetornaMenor(notas, quantidade);
            maior = RetornaMaior(notas, quantidade);

            Console.WriteLine($"\nSoma.: {soma:N1}");
            Console.WriteLine($"Média: {media:N1}");
            Console.WriteLine($"Menor: {menor:N1}");
            Console.WriteLine($"Maior: {maior:N1}");
        }

        static double RetornaMedia(double[] notas, int quantidade)
        {
            double media = 0.0;

            media = RetornaSoma(notas, quantidade) / quantidade;

            return media;
        }

        static double RetornaSoma(double[] notas, int quantidade)
        {
            double soma = 0.0;

            for (int i = 0; i < quantidade; i++)
            {
                soma += notas[i];
            }

            return soma;
        }

        static double RetornaMenor(double[] notas, int quantidade)
        {
            double menor = notas[0];

            for (int i = 1; i < quantidade; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            return menor;
        }

        static double RetornaMaior(double[] notas, int quantidade)
        {
            double maior = notas[0];

            for (int i = 1; i < quantidade; i++)
            {
                if (notas[i] > maior)
                {
                    maior = notas[i];
                }
            }

            return maior;
        }
    }
}
