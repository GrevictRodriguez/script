using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordenadasConArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] CoordsX = { 0, 2, 3, 5 };
            double[] CoordsY = { 0, 1, 5, 6 };
            double[] pendiente = new double[3];
            double[] intercepto = new double[3];
            double maximo = 0;
            int i = 0, j = 1, numero = 1;
            while (j <= 3)
            {
                double m = ((CoordsX[j] - CoordsX[i]) / (CoordsY[j] - CoordsY[i]));
                pendiente[i] = m;
                i++;
                j++;
                Console.WriteLine("\nlas pendiente de " + i + " son " + m);
            }
            i = 0;
            while (i < 3)
            {
                double b = CoordsY[i] - (pendiente[i] * CoordsX[i]);
                intercepto[i] = b;
                i++;
                Console.WriteLine("\nlos interceptos son " + b);
            }

            if (pendiente[1] == pendiente[0] && pendiente[2] == pendiente[1] && intercepto[2] == intercepto[1] && intercepto[1] == intercepto[0])
            {
                Console.WriteLine("\n Las pendientes son iguales por lo tanto estan en una misma recta");
            }
            else Console.WriteLine("No estan en la misma recta");
            i = 0;
            j = 1;
            while (i <= 2)
            {
                double d = Math.Sqrt((Math.Pow(CoordsX[j] - CoordsX[i], 2) + Math.Pow((CoordsY[j] - CoordsY[i]), 2)));
                if (d > maximo) {
                    maximo = d;
                    numero += i;
                }
                i++;
                j++;
            }
            Console.WriteLine("\nLa distancia del mayor segmento es " + maximo+"y es el segmento numero "+numero);



        }
    }
}
