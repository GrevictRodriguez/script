using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de SMMLV que recibe:");
            double a = double.Parse(Console.ReadLine());


            if (a<2)
            {
                Console.WriteLine("Usted debe pagar la tarifa A");
            }
            if (2.1 <= a && a <= 4) 
            {
                Console.WriteLine("Usted debe pagar la tarifa B");
            }
            if (a>4.1)
            {
                Console.WriteLine("Usted debe pagar la tarifa C");
            }
        }
    }
}
