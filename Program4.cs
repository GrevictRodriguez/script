using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
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
            //double porcentajeMayor = double.Parse(Console.ReadLine());
            double votosTotales = votosA + votosB + votosP1 + votosP2;

            bool a = votosTotales > poblacion;
            bool b = votosP1 - votosP2 < votosTotales* 0.1;
            bool c = votosTotales < poblacion * 0.3;

            if ((a || b) && c)
            {
                Console.WriteLine("Las elecciones se deben repetir");

            }
            else
            {
                if (votosP1 > votosP2)
                {
                    Console.WriteLine("el partido uno ha ganado, felicitaciones");

                }
                if (votosP1 == votosP2)
                {
                    Console.WriteLine("las votaciones estan igualadas, se deben repetir");

                }
                if (votosP1 < votosP2)
                {
                    Console.WriteLine("el partido dos ha ganado, felicitaciones");

                }


            }
        }
    }
}
