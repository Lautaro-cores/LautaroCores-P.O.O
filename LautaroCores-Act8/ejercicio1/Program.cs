using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class vectorparalelo
    {
        /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
del vector.*/

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
        public void vectorMenor()
        {
            int cont = 0;
            int menor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (menor > vector[i])
                {
                    menor = vector[i];
                }
                else if (menor == vector[i])
                {
                    cont++;
                }
            }
            if (cont == vector.Length)
            {
                Console.WriteLine("el elemento menor es se repite");
            }
            else
            {
                Console.WriteLine("el elemento menor es: " + menor);
            }
        }


        static void Main(string[] args)
        {
            vectorparalelo vector = new vectorparalelo();
            vector.cargaValores();
            vector.vectorMenor();
            Console.ReadKey();
        
        }
    }
}
