using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    class Program
    {


        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0;
            string continuar = "s";



            dado1 = aleatorio.Next(1, 11);
            dado2 = aleatorio.Next(1, 11);
            int suma = dado1 + dado2;
            Console.WriteLine("Carta 1= " + dado1);
            Console.WriteLine("Carta 2= " + dado2);

            total = suma;
            Console.WriteLine("Total =" + total);
            Console.WriteLine("Desea continuar (s/n): ");
            continuar = Console.ReadLine();



            while (total <= 21 && continuar == "s")
            {
                dado1 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 1= " + dado1);
                total += dado1;

                if (total <= 21)
                {
                    Console.WriteLine("Total =" + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("(Perdio)");
                    Console.WriteLine("Total =" + total);
                }
            }
            Console.WriteLine("Su total fue " + total + " puntos ");
            Console.WriteLine("Gracias por jugar");


        }
    }
}

