using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class ordenarVector
    {
        /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
(el orden lo pueden elegir ustedes).*/

        private int[] vector;

        public void cargaValores()
        {
            string linea;
            Console.WriteLine("cuantos elementos va a ser el vector");
            linea = Console.ReadLine();
            vector = new int[int.Parse(linea)];


            Console.WriteLine("ingrese los valores para el vector");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }

        }

        public void ordenarValores()
        {
            int aux;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1 - i; j++)
                {
                    if (vector[j] < vector[j+1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static void Main(string[] args)
        {
            ordenarVector vector = new ordenarVector();
            vector.cargaValores();
            vector.ordenarValores();
            Console.ReadKey();
        }
    }
}
