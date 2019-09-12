using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;


    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;

        total = 0;
        double min = 1000;
        int indice = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            double desv = Math.Pow(notas[i] - promedio, 2);
            if (desv < min)
            {
                min = desv;
                indice = i;
            }
            total += desv;
        }
        double desviacion = Math.Sqrt(total / notas.Length);

        double totala1 = desviacion+promedio;
        double totala2 = promedio-desviacion;
              
      
        for (int i = 0; i < notas.Length; i++)
        {
            if (totala2 < notas[i]  && notas[i]< totala1)
            {

                salida++;

            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
       
        /*for (int i = 0; i < salida.Length; i++)
        {
            if (notas[i])
            {
                salida[i] = nombres[i];
            }
        }*/


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
       

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;

        total = 0;
        double min = 1000;
        int indice = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            double desv = Math.Pow(notas[i] - promedio, 2);
            if (desv < min)
            {
                min = desv;
                indice = i;
            }
            total += desv;
        }
        double desviacion = Math.Sqrt(total / notas.Length);

        
        double totala1 = desviacion + promedio;
        double totala2 = promedio - desviacion;
        for (int i = 0; i < notas.Length; i++)
        {
            if (totala2 < notas[i] && notas[i] < totala1)
            {

                salida.Add(nombres[i]);

            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        for  (int i =0; i < nombres.Length ; i++)
        {
            int contador = 0;

            for (int j = 0; j < nombres[i].Length; j++)
            {
                
                string nombre = nombres[i];              
                
                if (nombre[j] == 'A' )
                {
                    contador++ ;
                  
                }
                
                if (contador > 2)
                {
                    break;
                }
            }
            if (contador > 1)
            {
                salida.Add(nombres[i]);
              
            }


            
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


