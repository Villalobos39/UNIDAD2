using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CLASES_RECURSIVIDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timeEjecucion = Stopwatch.StartNew();
            
            int numero; // factoria numero 0 = 1
            Console.Write("\n\t *** FACTORIAL DE UN NUMERO POR METODOS *** ");
            Console.Write("\n\t INGRESE NUMERO  :");
            numero = int.Parse(Console.ReadLine());

            FACTORIAL facror = new FACTORIAL();// objeto de la clases
            Console.Write("\n\t EL RESULTADO FACTORIA DE {0} ES : {1} \n\t TIEMPO DE EJECUCION {2}  ", numero,facror.Factorial(numero), timeEjecucion.Elapsed);
            Console.ReadKey();
        }
    }
}
