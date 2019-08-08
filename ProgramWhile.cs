using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de datos:");
            int datos = int.Parse(Console.ReadLine());
            double total = 0;
            int contador = 0;
            int maximo = 0;
            int minimo = 100;
            string namema = "";
            string nameme = "";



            while (contador < datos)
            {
                Console.Write("Ingrese nombre y edad ");
                string nombre = Console.ReadLine();
                int edad = int.Parse(Console.ReadLine());               
                if (edad > maximo){
                    namema=nombre;
                    maximo = edad;                    
                }
                if (edad < minimo)
                {  nameme = nombre;
                    minimo = edad;                   
                }
                total += edad;
                contador += 1;
                
            }

            double promedio = total / contador;
            Console.WriteLine("Promedio:" + promedio);
            Console.WriteLine("Maximo:" + maximo + namema);

            Console.WriteLine("Minimo:" + minimo+nameme);

            



        }
    }
}
