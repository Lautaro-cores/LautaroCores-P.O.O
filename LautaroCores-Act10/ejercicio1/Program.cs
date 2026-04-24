using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
componentes por columna (es decir primero ingresar toda la primer
columna, luego la segunda columna y así sucesivamente)
Imprimir luego la matriz.*/
    internal class matriz
    {
        private int[,] mat;
        
        public void cargarValores()
        {
            mat = new int [2,5];
            Console.WriteLine("ingrese valores para la matriz: ");
            for (int i = 0; i < 5; i++) { 
            
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.WriteLine("");
                    string linea = Console.ReadLine();
                    mat[j,i] = int.Parse(linea);

                }
            }
        }

        public void imprimir()
        {

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    Console.Write(mat[i,j] + "");
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            matriz mt = new matriz();
            mt.cargarValores();
            mt.imprimir();
            Console.ReadKey();
        }
    }
}
