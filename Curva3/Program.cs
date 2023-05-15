using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================== INVERTER ==================");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + " do array: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Inverter.InverterArray (array, 0, array.Length - 1);
            Console.WriteLine("Array invertido: " + string.Join(", ", array));

            Console.ReadLine();
        }
    }
}
