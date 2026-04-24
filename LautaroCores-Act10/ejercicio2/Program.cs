using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.*/
    internal class matrizCambiar
    {
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
            for (int i = 0; i < mat.GetLength(0) ; i++)
            {

                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    Console.WriteLine("");
                    linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);

                }
            }
        }

        public void intercambiar()
        {
            int aux = 0;

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                aux = mat[0, i];
                mat[0, i] = mat[1, i];
                mat[1, i] = aux;
            }
        }

        public void imprimir()
        {

            for (int i = 0; i < mat.GetLength(0) ; i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < mat.GetLength(0) ; i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + "");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            matrizCambiar mt = new matrizCambiar();
            mt.cargarValores();
            mt.intercambiar();
            mt.imprimir();
            Console.ReadKey();
        }
    }
}