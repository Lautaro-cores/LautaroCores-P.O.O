using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class vectores
    {
        /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
El valor acumulado de todos los elementos del vector.
El valor acumulado de los elementos del vector que sean mayores a 36.
Cantidad de valores mayores a 50.*/

        private float[] vector;

        public void ingresarValor()
        {
            vector = new float[8];
            string linea;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("ingrese valor para el vector");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);

            }
            
        }

        public void informeVector()
        {
            float suma = 0;
            for(int i = 0; i < 8; i++)
            {
               suma = suma + vector[i];
            }

            float suma36 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (vector[i] > 36) {
                    suma36 = suma36 + vector[i];
                } 
            }

            float valores50 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (vector[i] > 50)
                {
                    valores50 = valores50 + 1;
                }
            }

            Console.WriteLine("la suma de todos los valores: " + suma);
            Console.WriteLine("la suma de los valores mayores a 36: " + suma36);
            Console.WriteLine("la cantidad de valores mayores a 50: " + valores50);
        }


        static void Main(string[] args)
        {
          vectores vectores = new vectores();
            vectores.ingresarValor();
            vectores.informeVector();
            Console.ReadKey();
        }
    }
}
