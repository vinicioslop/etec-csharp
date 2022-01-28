using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Início: ");
            int inicio = Int32.Parse(Console.ReadLine());

            Console.Write("Fim...: ");
            int fim = Int32.Parse(Console.ReadLine());

            if(fim < inicio)
            {
                throw new Exception("Lógica inválida! O valor limite é maior que o valor inicial.");
            }

            for(int i=inicio; i <= fim; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
