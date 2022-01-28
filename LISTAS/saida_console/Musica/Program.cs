using System;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Título da Música Formatado
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" VMZ - Plutão ");
            Console.WriteLine();
            Console.ResetColor();

            // Primera estrofe
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Eu era pequenininho tipo um Plutão");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Até você vir do nada e me dar sua mão");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("E me fazer voar por onde eu jamais voei");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("E com o passar dos anos olha o que a gente fez");
            Console.ResetColor();

            // Quebra de linha para separar estrofes
            Console.WriteLine();

            // Segunda estrofe
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("É que eu era pequenininho tipo um Plutão");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Você veio do nada e me deu a mão");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Depois me fez voar por onde eu jamais voei");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("E com o passar dos anos olha o que a gente fez");
            Console.ResetColor();

            // Estilo dos 3 pontinhos
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" . ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" . ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" . ");

            Console.ResetColor();
        }
    }
}
