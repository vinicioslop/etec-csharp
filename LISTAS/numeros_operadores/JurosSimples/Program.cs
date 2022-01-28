using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double capital, taxaJuros, tempo, juros;

            decimal montante;

            Console.WriteLine("Bem vindo a calculadora de Juros simples!");
            Console.WriteLine("Entre com os dados na ordem que forem solicitados.\n");

            Console.Write("Digite o valor de capital: ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros...: ");
            taxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o tempo em meses..: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            juros = capital * (taxaJuros / 100) * tempo;
            montante = Convert.ToDecimal(capital + juros);

            Console.WriteLine("Juros simples (j)\n");
            Console.WriteLine($"Capital [c] (R$).......: {capital:C2}");
            Console.WriteLine($"Taxa de juros [i] (%)..: {taxaJuros}");
            Console.WriteLine($"Tempo [t] (meses)......: {tempo}\n");
            Console.WriteLine($"Juros (R$).....: {juros:C2}");
            Console.WriteLine($"Montante (R$)..: {montante:C2}");
        }
    }
}
