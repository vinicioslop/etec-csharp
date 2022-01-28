namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string nome, sobrenome;

            Console.WriteLine("Olá, Usuário");
            Console.WriteLine();

            Console.Write("Digite seu primeiro Nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu Sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Nome completo: {nome} {sobrenome}");
            Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
        }
    }
}