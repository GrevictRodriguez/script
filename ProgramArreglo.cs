using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numero = { "s", "l", "m", "k", "m" };
            int[] notas = { 1, 2, 1, 5, 4 };
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("ordena los datos "+notas[i]+" en la posicion "+numero[i]);

            }


            for (int j = 0; j < notas.Length-1; j++)
            { 
                for (int i = 0; i < notas.Length-1; i++)
                {
                    if (notas[i] < notas[i + 1])
                    {
                        int nota1 = notas[i];
                        notas[i] = notas[i + 1];
                        notas[i + 1] = nota1;
                        string numero1 = numero[i];
                         numero[i] = numero[i+1];
                        numero[i + 1] = numero1;



                    }
                }
            }
            for (int i = 0; i < notas.Length; i++) { 
                Console.WriteLine("ordenando las notas quedaria " + notas[i]+" en la posicion "+numero[i]);              

            }

            /* for (int j = i + 1; j < notas.length; j++)
             {
                 int nota = notas[i];
                 notas[i] = notas[j];
                 notas[j] = notas[] */
        }
    }
}
