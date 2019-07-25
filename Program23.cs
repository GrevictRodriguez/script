using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese w,t,c°");
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());

            double c = cGrados * (Math.PI / 180);

            double e = Math.PI - c;
            double d = Math.Asin((Math.Sin(e) * t )/ w);
            double a = Math.PI - e - d;

            double x = t * Math.Sin(a) / Math.Sin(d);
           

          

            Console.WriteLine("el lado x vale:" + x);
        }
    }
}
