using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese z y c°");
            double z = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());


            double c = cGrados * (Math.PI / 180.0);

            double a = Math.PI / 2 - c;
            double aGrados = a * 180 / Math.PI;

            double t = z/ Math.Sin(c);
            double y = z /Math.Tan(c);
           


            Console.WriteLine("la hipotenusa es:" + t);
            Console.WriteLine("El lado y es:" + y);
            Console.WriteLine("el angulo a es: " + aGrados);
        }
    }
}
