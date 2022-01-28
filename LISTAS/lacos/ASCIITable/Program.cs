using System;
using System.Text;

namespace ASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII Table\n");

            Console.Write("Informe um caractere qualquer: ");
            string entradaTexto = Console.ReadLine();

            var hex = retornaHext(entradaTexto);
            var oct = retornaOctal(entradaTexto);
            var dec = retornaDecimal(entradaTexto);

            Console.WriteLine("\nDec    Char    Oct     Hex");
            Console.WriteLine("---    ----    ---     ---\n");

            Console.Write($"{dec}     {entradaTexto}       {oct}     {hex}");
        }

        static int retornaDecimal(string entradaTexto)
        {            
            char caractere = Convert.ToChar(entradaTexto);
            
            var dec = Convert.ToInt32(caractere);

            return dec;
        }
        static string retornaOctal(string entradaTexto)
        {                        
            var oct = Convert.ToString(retornaDecimal(entradaTexto), 8);

            return oct;
        }
        static string retornaHext(string entradaTexto)
        {
            var caractere = Convert.ToChar(entradaTexto);
            
            var hexByte = Convert.ToByte(caractere);

            var hex = hexByte.ToString("x2");

            return hex;
        }
    }
}
