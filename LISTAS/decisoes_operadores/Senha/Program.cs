using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaArmazenada, senhaDigitada;

            senhaArmazenada = "1234abcd";

            Console.Write("Olá, usuário. Por favor, digite sua senha: ");
            senhaDigitada = Console.ReadLine();

            if(senhaDigitada == senhaArmazenada)
                Console.WriteLine("Acesso permitido");
            else
                Console.WriteLine("Acesso negado");
        }
    }
}
