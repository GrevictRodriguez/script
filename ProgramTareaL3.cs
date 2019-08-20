using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaL3
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0,dado2=0, total = 0, i = 0, j = 0, vidas = 3;
            string continuar = "s";
            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);

                int suma = vidas - j;
                Console.WriteLine("Dado= " + dado1);
                Console.WriteLine("Total Anterior= " + total);
                                         
               
                if ( i%2 != 0) j += 1;
                if (i % 3 == 0 && i > 1)
                {
                    dado2 = aleatorio.Next(1, 7);

                    Console.WriteLine("Dado2= " + dado2);
                    if (dado1 == dado2) j = 1;
                    if (j == 1)
                    {
                        vidas++;
                        break;
                    }
                    if (vidas > 3) vidas = 3;
                }
               

                if (suma <= 0)
                {
                    Console.WriteLine("Total= " + total);

                    Console.WriteLine("(Perdio todas las vidas)");
                    break;
                }

                else
                {

                    total += dado1 +dado2;
                    Console.WriteLine("Gran Total= " + total);
                    Console.WriteLine("vidas " + suma);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();

                }

                if (total > 99)
                {
                    Console.WriteLine("Ha ganado, felicitaciones");
                    break;
                }

                if (total < 0)
                {
                    Console.WriteLine("Ha perdido");
                    break;
                }

                i++;

            }

            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por participar");
        }


    
    }
}
