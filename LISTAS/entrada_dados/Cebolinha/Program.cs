namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string fraseDigitada, fraseConvertida;

            Console.WriteLine("Bem vindo ao Conversor em Cebolinha!");
            Console.WriteLine("Consiste em pegar a frase digitada e exibi-la");
            Console.WriteLine("como se tivesse sido dita pelo Cebolinha.");
            Console.WriteLine();

            Console.Write("Digite a frase escolhida: ");
            fraseDigitada = Console.ReadLine();
            Console.WriteLine();

            fraseConvertida = fraseDigitada.Replace("R", "L").Replace("r", "l");

            Console.WriteLine($"Frase digitada: \n{fraseConvertida}");
        }
    }
}
