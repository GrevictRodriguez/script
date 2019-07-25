using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese w,d°,x");
            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            
            double d = dGrados * (Math.PI / 180);

            double y =(Math.Cos(d)*w)-x;


            Console.WriteLine("el lado y vale:" + y);
        }
    }
}
