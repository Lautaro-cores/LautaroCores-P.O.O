using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class matrizIrregular
    {

        /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
(crearla sin la intervención del operador)
Realizar la carga por teclado e imprimir posteriormente.*/

        private int[][] matriz;

        public void cargaValores()
        {
            matriz = new int[5][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[i+1];
            }

            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine("ingrese valor para la fila" + i);
                for (int j = 0; j < matriz[i].Length; j++)
                {

                    Console.WriteLine("");
                    string linea = Console.ReadLine();
                    matriz [i] [j] = int.Parse(linea);

                }
            }

        }

        public void imprimir()
        {
            Console.WriteLine("");
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length ; j++)
                {
                    Console.Write(matriz [i][j] + "");
                }
                Console.WriteLine();
            }

        }


        static void Main(string[] args)
        {
            matrizIrregular mat = new matrizIrregular();
            mat.cargaValores();
            mat.imprimir();
            Console.ReadKey();
        }
    }
}
