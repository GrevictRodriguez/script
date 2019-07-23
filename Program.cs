using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("ingrese Y y Z");
            double Y = double.Parse(Console.ReadLine());
            double Z = double.Parse(Console.ReadLine());

            


            double t = Math.Sqrt((Y * Y) + (Z * Z));
            double c = Math.Asin((Z / t))*(180/Math.PI);
            double a = 90-c;

           
            

            Console.WriteLine("la hipotenusa es:" + t);
            Console.WriteLine("el angulo c es:" + c);
            Console.WriteLine("el angulo a es: " + a);




        }
    }
}
