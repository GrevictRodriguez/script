using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaL1
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, i = 0,j=0;
            string continuar = "s";
            while (continuar == "s")
            {
                dado1 = aleatorio.Next(9, 13);              
                Console.WriteLine("Dado= " + dado1);
                Console.WriteLine("Total= " + total);

                if (total > 99  )
                {
                    Console.WriteLine("Ha ganado, felicitaciones");
                    break;
                }
               
                               
              if (dado1%2 != 0 && i >3)
                    {
                    Console.WriteLine("Numero impar");
                     Console.WriteLine("(ELIMINADO)");
                     break;
                        
                    }
                 
              

                else
                {
                    total += dado1;
                    Console.WriteLine("Total= " + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                    if (dado1 == 12) j = 1;
                    else j = 0;
                   
                }
                if (j == 1 && dado1 == 10) Console.WriteLine("ha ganado");
                i += 1;

            }
            
            Console.WriteLine("Su total fue " + total + " puntos");
            Console.WriteLine("Gracias por participar");


        }

    }
}
