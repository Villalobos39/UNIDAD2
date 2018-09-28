using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RECURSIVIDAD_FACTORIA
{
    class Program
    {
        public static int Factorial(int numero) // LA LLAMADA DEL METODO RECURSIVAMENTE 
        {
            if (numero==0) // si n es igual a 0 , la condicion establece que regrese n = 1 
            {
                return 1;
            }
            return numero * Factorial(numero - 1);
        }
        static void Main(string[] args)
        {
            Stopwatch timeEjecucion = Stopwatch.StartNew();
            int numero; // factoria numero 0 = 1
            Console.Write("\n\t *** FACTORIAL DE UN NUMERO POR METODOS *** ");
            Console.Write("\n\t INGRESE NUMERO  :");
            numero = int.Parse(Console.ReadLine());         
             Console.Write("\n\t EL RESULTADO FACTORIA DE {0} ES : {1} \n\t TIEMPO DE EJECUCION {2}  ", numero, Factorial(numero) , timeEjecucion.Elapsed);
            Console.ReadKey();
        }
    }
}
