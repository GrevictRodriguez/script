using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();           
            int[] participantes = {0, 1, 2, 3, 4, 5};
            int[] puntos = { 0, 0, 0, 0, 0, 0 };
            int ganador = 0, jugador = 0, jugadores = 0, o = 0;
            

            Console.WriteLine("Vamos a jugar");
            Console.WriteLine("Ingrese el numero de jugadores (entre 2 y 5) : ");
            jugadores =int.Parse(Console.ReadLine());


            while (jugadores<2||jugadores>5)
            {
                Console.WriteLine("Error en la digitacion");
                Console.WriteLine("Vuelva a ingresar el numero de jugadores (entre 2 y 5)");
                jugadores =int.Parse(Console.ReadLine());
                o++;

                if (o >= 2)
                {
                    Console.WriteLine("Intentelo mas tarde");
                    break;
                }

            }
           for(jugador=1;jugador<=jugadores;jugador++)
            {
                Console.WriteLine("----------Juguemos-------- ");
                int dado1 = 0, dado2 = 0;
                string continuar = "s";
                while (continuar == "s")
                {
                    Console.WriteLine("\nBienvenido jugador:" + jugador);
                    dado1 = aleatorio.Next(1, 11);
                    dado2 = aleatorio.Next(1, 11);
                    int suma = dado1 + dado2;
                    Console.WriteLine("Carta 1= " + dado1);
                    Console.WriteLine("Carta 2= " + dado2);                   
                    Console.WriteLine("Total =" + suma);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();

                    while (suma <= 21 && continuar == "s")
                    {
                        dado1 = aleatorio.Next(1, 11);
                        Console.WriteLine("Carta 1= " + dado1);
                        suma = suma+ dado1;
                                               
                        Console.WriteLine("Total =" + suma);
                        Console.WriteLine("Desea continuar (s/n): ");                         
                       continuar = Console.ReadLine();

                        if (suma > 21)
                        {
                            Console.WriteLine("(Perdio)");
                            Console.WriteLine("Total =" +suma);
                            break;
                        }

                    }
                    puntos[jugador] = suma;

                    Console.WriteLine("Su total fue " + suma + " puntos ");                    
                }

            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i+1;j <= 5; j++)
                {
                    int punto = puntos[i];
                     puntos[i] = puntos[j];
                     puntos[j] = punto;
                    int participante = participantes[i];
                    participantes[i] = participantes[j];
                    participantes[j] = participante;

                }


            }    
            

            for (int i = 1; i <= 5; i++)
            {
                if (puntos[i] <= 21 && puntos[i] > 0)
                {
                    if(ganador == 0)
                    {
                        Console.WriteLine("el segundo puesto es del jugador " + participantes[i] + " con un total de " + puntos[i]);
                        ganador++;
                    }
                    else
                    {
                        Console.WriteLine("ha ganado el jugador " + participantes[i] + " con un total de " + puntos[i]);
                        break;
                    }
                }

            }
          
           Console.WriteLine("Gracias por jugar");

        }


    }
}
