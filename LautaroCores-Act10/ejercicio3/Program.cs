using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class matrizVertices
    {

        /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)*/
        private int[,] mat;

        public void cargarValores()
        {
            int aux1 = 0;
            int aux2 = 0;

            Console.WriteLine("ingrese el numero de filas");
            string linea = Console.ReadLine();
            aux1 = int.Parse(linea);

            Console.WriteLine("ingrese el numero de columnas");
            linea = Console.ReadLine();
            aux2 = int.Parse(linea);

            mat = new int[aux1, aux2];
            Console.WriteLine("ingrese valores para la matriz: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    Console.WriteLine("");
                    linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);

                }
            }
        }



        public void imprimir()
        {
            Console.Write("los vertices de la matriz son:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "");
                }
                Console.WriteLine();
            }


            Console.WriteLine(mat[0,0]);
            Console.WriteLine(mat[0,mat.GetLength(1) - 1]);
            Console.WriteLine(mat[mat.GetLength (0)- 1, 0]);
            Console.WriteLine(mat[mat.GetLength(0)-1, mat.GetLength(1)-1]);
        }

        static void Main(string[] args)
        {
            matrizVertices mt = new matrizVertices();
            mt.cargarValores();
            mt.imprimir();
            Console.ReadKey();
        }
    }
}
