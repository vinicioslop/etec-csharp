namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string frase, fraseCensurada;

            Console.WriteLine("Olá, Usuário!");
            Console.WriteLine();

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine();

            fraseCensurada = frase.Replace("chato", "#@$%*!&")
                .Replace("chata", "#@$%*!&")
                .Replace("bobo", "#@$%*!&")
                .Replace("boba", "#@$%*!&")
                .Replace("feio", "#@$%*!&")
                .Replace("feia", "#@$%*!&")
                .Replace("boboca", "#@$%*!&")
                .Replace("bocó", "#@$%*!&")
                .Replace("tonto", "#@$%*!&")
                .Replace("tonta", "#@$%*!&")
                .Replace("palerma", "#@$%*!&")
                .Replace("paspalho", "#@$%*!&")
                .Replace("paspalha", "#@$%*!&")
                .Replace("tantã", "#@$%*!&")
                .Replace("panaca", "#@$%*!&")
                .Replace("pentelho", "#@$%*!&")
                .Replace("pentelha", "#@$%*!&")
                .Replace("burro", "#@$%*!&")
                .Replace("burra", "#@$%*!&")
                .Replace("besta", "#@$%*!&");

            Console.WriteLine($"Frase \"consertada\": \n{fraseCensurada}");
        }
    }
}
