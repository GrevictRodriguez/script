using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeListas
{
    class Program
    {
        static void Main()
        {
            int[] A = { 0, 3, 6, 6, 9, 12, 12, 18, 15 };
            int[] E = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            int[] B = { 0, 2, 2, 4, 6, 6, 8, 10, 12, 14, 18, 16};
            List<int> union = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                union.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                union.Add(B[i]);
            }
            union.Sort();
            for (int i = 0; i < union.Count - 1; i++)
            {
                if (union[i] == union[i + 1])
                {
                    union.RemoveAt(i);
                    i = 0;
                }
            }
            Console.Write("\n Esta es la union: ");

            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i] + ",");
            }


            List<int> interseccion = new List<int>();
            for (int i = 0; i < A.Length ; i++)
            {
                for (int j = 0; j < B.Length ; j++)
                {
                    if (A[i]==B[j])
                    {
                        interseccion.Add(A[i]);

                    }
                }
            }
            interseccion.Sort();
            for(int i = 0; i < interseccion.Count - 1; i++)
            {
                if (interseccion[i] == interseccion[i + 1])
                {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }
            Console.Write("\n Esta es la interseccion: ");
            for (int i = 0; i < interseccion.Count; i++)
            {
                Console.Write( ""+interseccion[i] + ",");
            }


            List<int> enteros = new List<int>();
            for (int i = 0; i < E.Length; i++)
            {
                enteros.Add(E[i]);
            }
            enteros.Sort();
            for (int i = 0; i < enteros.Count-1; i++)
            {
                if (enteros[i] ==0|| enteros[i] == 2|| enteros[i] == 3 || enteros[i] == 4 || enteros[i] == 6 || enteros[i] == 8|| enteros[i] ==9|| enteros[i] == 10 || enteros[i] == 12|| enteros[i] ==15|| enteros[i] == 14|| enteros[i] == 16|| enteros[i] ==18 )
                {
                    enteros.RemoveAt(i);
                    i = 0;                
                }
            }
            Console.Write("\n los complementos son: ");
           for (int i = 0; i < enteros.Count; i++)
            {
                Console.Write("" + enteros[i] + ",");
            }
        }

    }
}
