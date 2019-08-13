using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseWhileandBreaks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, i = 0, j = 0;
            double a = 0;            
            string continuar = "s";
            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                int suma = dado1 + dado2;
                               
                Console.WriteLine("Dado= " + dado1);
                Console.WriteLine("Dado= " + dado2);
                Console.WriteLine("Total= " + suma);


                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Total= " + total);

                    Console.WriteLine("(ELIMINADO)");
                    break;
                }

                else
                {
                    total += suma;
                    Console.WriteLine("Total= " + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                    if (suma > 6) a += 1;



                }
                if (dado1 == dado2) j += 1;
                if (j > 2)
                {

                    Console.WriteLine("Ha ganado, felicitaciones");
                    break;
                }

                if (total > 99) {
                    Console.WriteLine("Ha ganado, felicitaciones");
                    break;
                }

               
                i += 1;
                

            }
            double eventos = (a / i) * 100;


            Console.WriteLine("Su porcentaje de turnos con sumas mayores a 6 fue " + eventos);
            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por participar");


        }
    }
}
