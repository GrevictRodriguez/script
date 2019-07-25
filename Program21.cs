using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese b°,d°,y");
            double bGrados = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double b = bGrados * (Math.PI / 180);
            double d = dGrados * (Math.PI / 180);

            double a = Math.PI - (Math.PI / 2) - d - b ;
            double z = y / Math.Tan(a);
          

            Console.WriteLine("el lado z vale:" + z);
        }
    }
}
