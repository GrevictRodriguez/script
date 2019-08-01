using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese numero de votos por el partido 1, partido 2, votos en blanco,anulados, poblacion, porcentaje de la poblacion que es mayor de edad:");
            double votosP1 = double.Parse(Console.ReadLine());
            double votosP2 = double.Parse(Console.ReadLine());
            double votosB = double.Parse(Console.ReadLine());
            double votosA = double.Parse(Console.ReadLine());
            double poblacion = double.Parse(Console.ReadLine());
            double porcentajeMayor = double.Parse(Console.ReadLine());

            bool a = votosA <= (votosP1 + votosP2 * 0.3); 
            bool b = (votosA + votosB) > votosA;
            bool c = (poblacion *(porcentajeMayor/100)) < 2*(votosA + votosB + votosP1 + votosP2); //esto se puede cambiar de lado como una ecuacion normal

            if ((a || b) && c)
            {
                Console.WriteLine("\n la elecciones fueron exitosas");

                 if (votosP1 < votosP2)
                {
                    Console.WriteLine("el partido 2 gano, felicitaciones");

                }
                else
                {
                    Console.WriteLine("el partido 1 gano, felicitaciones");
                }
                 
                
            }
            else
            {
                Console.WriteLine("las votaciones se deben repetir");
            }
                    

            
        }
    }
}
