﻿using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Bem vindo a doação de sangue.\n");

            Console.Write("Qual a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade >= 18 && idade <= 67)
                Console.WriteLine("Você pode ser doador de sangue.");
            else
                Console.WriteLine("Você não pode ser doador de sangue.");
        }
    }
}
