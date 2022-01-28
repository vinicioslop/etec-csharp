using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double distancia, tempo, velocidadeMedia;
            
            Console.WriteLine("Bem vindo ao cálculo de velocidade média.\n");

            Console.Write("Distância percorrida (m): ");
            distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tempo gasto (s).........: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            velocidadeMedia = distancia / tempo;

            Console.WriteLine($"\nVelocidade média........: {velocidadeMedia.ToString("N1")} m/s");
        }
    }
}
