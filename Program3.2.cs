using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de SMMLV que recibe:");
            double a = double.Parse(Console.ReadLine());


            if (a < 2)
            {
                Console.WriteLine("Usted debe pagar la tarifa A y tiene que pagar  3.200 de cuota moderadora");
            }
            if (2.1 <= a && a <= 5)
            {
                Console.WriteLine("Usted debe pagar la tarifa B y tiene que pagar 12.700 de cuota moderadora");
            }
            if (a > 5.1)
            {
                Console.WriteLine("Usted debe pagar la tarifa C y tiene que pagar  33.500 de cuota moderadora ");
            }
        }
    }
}
