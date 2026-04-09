using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class ordenar
    {
        /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
ordenado de menor a mayor y de mayor a menor.*/
        private int[] vector;

        public void cargaValores()
        {
            vector = new int[10];
            string linea;
            Console.WriteLine("ingrese 10 valores para el vector");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
            Console.WriteLine("a");
        }

        public void menorMayor()
        {
            int menor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                int cont = 0;
                if (menor < vector[i])
                {
                    menor = vector[i];
                    cont++;
                    Console.Write(cont);

                }

                if (cont == vector.Length)
                {
                    Console.WriteLine("el vector esta ordenado de menor a mayor");
                }

            }
        }
        public void mayorMenor()
        {
            int mayor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                int cont = 0;
                if (mayor > vector[i])
                {
                    mayor = vector[i];
                    cont++;
                }

                if (cont == vector.Length)
                {
                    Console.WriteLine("el vector esta ordenado de menor a mayor");
                }

            }
        }

            static void Main(string[] args)
            {
                ordenar vector = new ordenar();
                vector.cargaValores();
                vector.menorMayor();
                vector.mayorMenor();
                Console.ReadKey();
            }
        } 
    }
