using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES_RECURSIVIDAD
{
    class FACTORIAL
    {
        public FACTORIAL() { }
      //  FACTORIAL() { }

        public int Factorial(int numero) // LA LLAMADA DEL METODO RECURSIVAMENTE 
        {
            if (numero == 0) // si n es igual a 0 , la condicion establece que regrese n = 1 
            {
                return 1;
            }
            return numero * Factorial(numero - 1);
        }
    }
}
