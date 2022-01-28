namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string resposta = "- E sabe o que eu penso de você?\n";
            string opiniao;
            
            Console.WriteLine("Usuário, qual sua opinião sobre mim? Estou curioso.");
            Console.WriteLine();

            Console.Write("Digite sua opinião: ");
            opiniao = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{resposta}{opiniao.Remove(10)}... NÃO, PERA.\nTô nervoso");
        }
    }
}
