using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class sumaVectores
    {
        /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
tercer vector del mismo tamaño. Sumar componente a componente.*/

        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void cargaValores()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            string linea;
            Console.WriteLine("ingrese valor para el primer vector: ");
            for (int i = 0; i < vector1.Length; i++) {
                Console.Write("");
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);

             }
            Console.WriteLine("ingrese valor para el segundo vector: ");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write("");
                linea = Console.ReadLine();
                vector2[i] = int.Parse(linea);

            }
        }

        public void sumaVector()
        {
            vector3 = new int[4];
            for (int i = 0; i < vector3.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
            Console.WriteLine("la suma de lo vectores es: ");
            for (int i = 0; i < vector3.Length; i++)
            { 
                Console.Write(vector3[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            sumaVectores suma = new sumaVectores();
            suma.cargaValores();
            suma.sumaVector();
            Console.ReadKey();
        }
    }
}
