using System;

namespace EtecAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Bem-vindo a mais um dos programas básicos em C#.");
            Console.ResetColor();

            Console.WriteLine("Feito como atividade adicional em Técnico em Informática");
            Console.Write("pela ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Etec Adolpho Berezin!");
            Console.ResetColor();
        }
    }
}
