using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su salario y si es independiente coloque 1 y si es dependiente 2");
            double salario = double.Parse(Console.ReadLine());
            double contrato = double.Parse(Console.ReadLine());
            double vase = salario * 0.4;

           if(vase < 828.116)
            {
                vase = 828.116;
            }

            if (contrato == 1)
            {
                Console.WriteLine("ingrese el numero entre 1 y 5 equivalente a la clase de riesgo");
                double riesgo = double.Parse(Console.ReadLine());
                double deducciones = vase * 0.16 + vase * 0.125;                            
                double salarior = salario - deducciones;

                if (riesgo == 1)
                {
                    salarior = salario -deducciones - vase * 0.00522;
                }
                if (riesgo == 2)
                {
                    salarior = salario -deducciones - vase * 0.0144;
                }
                if (riesgo == 3)
                {
                    salarior = salario - deducciones - vase * 0.02436;
                }
                if (riesgo == 4)
                {
                    salarior = salario - deducciones - vase * 0.04350;
                }
                if (riesgo == 5)
                {
                    salarior = salario - deducciones - vase * 0.06960;
                }

                double salarioa = salarior * 12;
                Console.WriteLine("su salario real mensual es : " + salarior);
                Console.WriteLine("su salario real anual es : " + salarioa);


            }

            else if( contrato==2)
            {

                double deducciones =  vase * 0.04 + vase * 0.04;
                double salarior = salario - deducciones;
                double salarioa = salarior * 12 + salario;

                Console.WriteLine("su salario real mensual es : " + salarior);
                Console.WriteLine("su salario real anual es : " + salarioa);


            }

        }
    }
}
