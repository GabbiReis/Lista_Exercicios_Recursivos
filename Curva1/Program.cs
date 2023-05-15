using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Potencia potencia = new Potencia();
            int x = 0;
            int n = 0;

            Console.WriteLine("========== POTÊNCIA ==========");
            Console.Write("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());


            int resultado = Potencia.PotenciaRecursiva(x, n);
            Console.WriteLine("O resultado de " + x + " elevado a " + n + " é: " + resultado);

            Console.ReadLine();
        }
    }
}
