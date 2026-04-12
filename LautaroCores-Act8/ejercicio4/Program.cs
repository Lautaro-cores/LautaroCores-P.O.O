using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class paisesHabitantes
    {
        /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
ordenar con respecto*/

        private string[] paises;
         private string[] paises2;
        private int[] habitantes;

        public void cargaValores()
        {
            paises = new string[5];
            habitantes = new int[5];
            Console.WriteLine("ingrese el nombre de 5 paises");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("");
                paises[i] = Console.ReadLine(); ;
            }
            string linea;

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("ingrese los habitantes de "+ paises[i]);
                Console.Write("");
                linea = Console.ReadLine();
                habitantes[i] = int.Parse(linea);
            }
        }

        public void ordenarPais() 
        {
            paises2 = new string[5];
            string aux;
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < paises.Length - 1 - i; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        aux = paises2[j];
                        paises2[j] = paises2[j + 1];
                        paises2[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("paises ordenados alfabeticamente");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }

        }

        public void ordenarHabitantes()
        {
            int aux;
            string aux2;
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < habitantes.Length - 1 - i; j++)
                {
                    if (habitantes[j] < habitantes[j + 1])
                    {
                        aux = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = aux;
                        aux2 = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux2;
                    }
                }
            }
            Console.WriteLine("paises ordenados por habitantes");
            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.WriteLine(paises[i] + ": " +habitantes[i]);
            }

        }
            static void Main(string[] args)
        {
            paisesHabitantes paises = new paisesHabitantes();
            paises.cargaValores();
            paises.ordenarPais();
            paises.ordenarHabitantes();
            Console.ReadKey();
        }
    }
}
