namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string textoDigitado, textoExibido;

            Console.WriteLine("Boa noite Usuário!");
            Console.WriteLine();

            Console.Write("Digite um texto qualquer: ");
            textoDigitado = Console.ReadLine();
            Console.WriteLine();

            textoExibido = textoDigitado.ToUpper();

            Console.WriteLine($"Foi digitado: {textoDigitado}, e grito: {textoExibido}");
        }
    }
}