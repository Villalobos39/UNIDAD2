using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace n_FACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeEjecucion = Stopwatch.StartNew();
            int numero, factorial = 1; // factoria numero 0 = 1
            Console.Write("\n\t *** FACTORIAL DE UN NUMERO POR UN CICLO *** "); 
            Console.Write("\n\t INGRESE NUMERO  :"); 
            numero = int.Parse(Console.ReadLine());
            for (int contar = 1; contar <= numero; contar++)
            { // factorial = 1*1=1 factorial =1*2=2 factorial =2*3=6 factorial=6*4=24 factorial=24*5=120 .....
                factorial = factorial * contar;
            }
            Console.Write("\n\t EL RESULTADO FACTORIA DE {0} ES : {1} \n\t TIEMPO DE EJECUCION {2}  ", numero, factorial, timeEjecucion.Elapsed);
            Console.ReadKey();
        }
    }
}
