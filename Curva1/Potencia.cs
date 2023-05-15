using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curva1
{
    internal class Potencia
    {
        public static int PotenciaRecursiva(int x, int n)
        {
            // Primeiro caso o caso base
            if (n == 0)
            {
                return 1;
            }
            // Hora da recursão: calcula x elevado a n-1 e multiplica por x
            else
            {
                return x * PotenciaRecursiva(x, n - 1);
            }
        }
    }
}
