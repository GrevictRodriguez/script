using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            Console.WriteLine("Vamos a jugar");
            Console.WriteLine("Ingrese el numero de jugadores (entre 2 y 5) : ");
            int jugadores = int.Parse(Console.ReadLine());
            int i = 0, jugador = 1;

            while (jugadores<2 || 5<jugadores)
            {
                Console.WriteLine("Error en la digitacion");
                Console.WriteLine("Vuelva a ingresar el numero de jugadores (entre 2 y 5)");
                jugadores = int.Parse(Console.ReadLine());
                i++;

                if (i >=2)
                {
                    Console.WriteLine("Intentelo mas tarde");
                    break;
                }

            }
            Console.WriteLine("----------Juguemos-------- " );
            while (jugador <= jugadores)
            {
                int dado1 = 0, dado2 = 0, total = 0;
                string continuar = "s";


                while (continuar == "s")
                {
                    Console.WriteLine("\nBienvenido jugador:" + jugador);

                    dado1 = aleatorio.Next(1, 11);
                    dado2 = aleatorio.Next(1, 11);
                    int suma = dado1 + dado2;
                    Console.WriteLine("Carta 1= " + dado1);
                    Console.WriteLine("Carta 2= " + dado2);

                    total = suma;
                    Console.WriteLine("Total =" + total);
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();



                    while (total <= 21 && continuar == "s")
                    {
                        dado1 = aleatorio.Next(1, 11);
                        Console.WriteLine("Carta 1= " + dado1);
                        total += dado1;

                        if (total <= 21)
                        {
                            Console.WriteLine("Total =" + total);
                            Console.WriteLine("Desea continuar (s/n): ");
                            continuar = Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("(Perdio)");
                            Console.WriteLine("Total =" + total);
                            break;
                        }
                        if (total == 21)
                        {
                            Console.WriteLine("Ha ganado, Felicitaciones");
                            break;
                        }
                    }

                    Console.WriteLine("Su total fue " + total + " puntos ");

                    jugador++;

                }
            }
            Console.WriteLine("Gracias por jugar");

        }
    }
}
