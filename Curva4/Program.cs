using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            int numero = 23;
            string binario = Converter.DecimalParaBinario(numero);

            Console.WriteLine("========== CONVERTER ==========");
            Console.Write("Digite o valor do decimal pra converter em binário: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O número decimal " + numero + " em binário é: " + binario);


            Console.ReadLine();
        }
    }
}
