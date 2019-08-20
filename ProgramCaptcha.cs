using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCaptcha
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int a = 0, b = 0, sumau = 0, i = 0;


            a = aleatorio.Next(1, 11);
            b = aleatorio.Next(1, 11);

            Console.WriteLine("Sume a y b");
            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);
            int suma = a + b;
            Console.WriteLine("La suma da=");
            sumau = int.Parse(Console.ReadLine());

            while (sumau!=suma)
            {
                Console.WriteLine("Error en la digitacion");
                Console.WriteLine("\nVuelva a digitar la suma");
                a = aleatorio.Next(1, 11);
                b = aleatorio.Next(1, 11);

                Console.WriteLine("Sume a y b");
                Console.WriteLine("A= " + a);
                Console.WriteLine("B= " + b);
                 suma = a + b;
                Console.WriteLine("La suma da=");
                sumau = int.Parse(Console.ReadLine());

                i++;
                if (i >= 2)
                {
                    Console.WriteLine("Intentelo mas tarde");
                    break;
                }
            }
           
            if(i<3)
            {
                Console.WriteLine("La suma de a y b es igual a " + sumau);
                Console.WriteLine("Bien hecho!!! ");
            }

        }
    }
}
