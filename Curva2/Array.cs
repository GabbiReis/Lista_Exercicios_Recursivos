using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva2
{
    internal class Array
    {
        public static double SomaArray(double[] array, int indice)
        {
            //  // Primeiro caso o caso base
            if (indice == 0)
            {
                return array[indice];
            }
            // Hora da recursão: soma o valor atual com a chamada recursiva da função para o índice anterior
            else
            {
                return array[indice] + SomaArray(array, indice - 1);
            }
        }
    }
}
