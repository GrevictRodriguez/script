﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese b°,z,y");
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double b = bGrados * (Math.PI / 180);

            double x = (z * Math.Tan(b)) - y;

            Console.WriteLine("el lado x vale:" + y);

        }
    }
}
