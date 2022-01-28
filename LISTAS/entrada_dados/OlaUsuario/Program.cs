namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string nomeUsuario;

            Console.WriteLine("Bem-vindo ao meu novo programa.");
            Console.WriteLine();

            Console.Write("Digite seu nome: ");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Olá, {nomeUsuario}!");
        }
    }
}
