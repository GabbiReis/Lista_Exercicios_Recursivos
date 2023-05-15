using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva3
{
    internal class Inverter
    {
        public static void InverterArray(int[] array, int inicio, int fim)
        {
            //base: quando o início for maior ou igual ao fim, a recursão termina
            if (inicio >= fim)
            {
                return;
            }
            //Hora da recursão: troca os elementos de posição e chama a função recursivamente para os índices adjacentes
            else
            {
                int temp = array[inicio];
                array[inicio] = array[fim];
                array[fim] = temp;
                InverterArray(array, inicio + 1, fim - 1);
            }
        }

    }
}
