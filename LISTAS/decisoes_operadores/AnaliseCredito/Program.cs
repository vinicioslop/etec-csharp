using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal emprestimo, rendaMensal, parcelas, credito;

            Console.WriteLine("Bem vindo a Analise de Crédito.\n");

            Console.Write("Informe o valor do empréstimo....: ");
            emprestimo = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a Quantidade de parcelas.: ");
            parcelas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a Renda Mensal do Cliente: ");
            rendaMensal = Convert.ToDecimal(Console.ReadLine());;

            credito = emprestimo / parcelas;

            if(credito > (rendaMensal * (decimal)0.3))
            {
                Console.WriteLine("\nEmpréstimo negado");
            }
            else
            {
                Console.WriteLine("\nEmpréstimo aprovado");
            }
        }
    }
}
