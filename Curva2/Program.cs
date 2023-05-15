using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================== SOMA ==================");
            double[] array = new double[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " do array: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            double soma = Array.SomaArray(array, array.Length - 1);
            Console.WriteLine("Soma do array: " + soma);

            Console.ReadLine();
        }
    }
}
