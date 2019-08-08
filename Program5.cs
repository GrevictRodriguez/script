using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su salario y si es independiente coloque 1 y si es dependiente 2");
            double salario = double.Parse(Console.ReadLine());
            double contrato = double.Parse(Console.ReadLine());
            double vase = salario * 0.4;

            if (vase < 828.116) vase = 828116;
           

           switch(contrato)
            {
                case 1:
                Console.WriteLine("ingrese el numero entre 1 y 5 equivalente a la clase de riesgo");
                int riesgo = int.Parse(Console.ReadLine());
                double deducciones = vase * 0.16 + vase * 0.125;
                double salarior = salario - deducciones;


                switch (riesgo)
                {
                    case 1:
                        salarior = salario - deducciones - vase * 0.00522;
                        break;
                    case 2:
                        salarior = salario - deducciones - vase * 0.0144;
                        break;
                    case 3:
                        salarior = salario - deducciones - vase * 0.02436;
                        break;
                    case 4:
                        salarior = salario - deducciones - vase * 0.04350;
                        break;
                    case 5:
                        salarior = salario - deducciones - vase * 0.06960;
                        break;
                }
                double salarioa = salarior * 12;
                Console.WriteLine("su salario real mensual es : " + salarior);
                Console.WriteLine("su salario real anual es : " + salarioa);


                    break;
                case 2:

                double deducciones1 = vase * 0.04 + vase * 0.04;
                double salarior1 = salario - deducciones1;
                double salarioa1 = salarior1 * 12 + salario;

                Console.WriteLine("su salario real mensual es : " + salarior1);
                Console.WriteLine("su salario real anual es : " + salarioa1);
                    break;


            }
        }
}
