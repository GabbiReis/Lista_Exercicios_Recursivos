using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva4
{
    internal class Converter
    {
        public static string DecimalParaBinario(int numero)
        {
            //base: quando o número for igual a 0, retorna uma string vazia
            if (numero == 0)
            {
                return "";
            }
            // Hora da recursão: calcula o resto da divisão por 2 e chama a função recursivamente para a divisão inteira por 2
            else
            {
                int resto = numero % 2;
                return DecimalParaBinario(numero / 2) + resto.ToString();
            }
        }

    }
}
