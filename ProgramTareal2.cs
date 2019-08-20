using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaL2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, i = 0, j = 0,vidas=3;
            double a = 0;
            string continuar = "s";
            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                
                int suma =vidas - j;
                Console.WriteLine("Dado= " + dado1);
                Console.WriteLine("Total Anterior= " +total );

                if (dado1 == 6) a += 1;

                if (a == 1 && dado1 == 6) vidas ++;
                if (vidas > 3) vidas = 3;
                if (dado1 == 1) { j += 1; i = 10; }
                else i = 0;

                if (suma<=0)
                {
                    Console.WriteLine("Total= " + total);
                  
                    Console.WriteLine("(Perdio todas las vidas)");
                    break;
                }

                else
                {

                        total += dado1 - i;
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
                


            }
                       
            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por participar");
        }
    }
}
