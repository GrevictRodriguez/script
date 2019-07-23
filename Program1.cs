using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese T y a°");
            double T = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());


            double a = aGrados * (Math.PI / 180.0);

            double c = a-(Math.PI/2);
            

           double z = T * Math.Sin(c);
           double y = T * Math.Cos(c);
             
            Console.WriteLine("El lado z es:" + z);
           Console.WriteLine("El lado y es:" + y);
           Console.WriteLine("el angulo c es: " + c);
        }

    }
}
