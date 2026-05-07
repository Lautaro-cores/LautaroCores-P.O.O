using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class mediaTemp
    {

        /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
dato las temperaturas medias mensuales de dichos paises.
Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
memoria.
a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
mismas.
c. Calcular la temperatura media trimestral de cada país.
d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
e. Imprimir el nombre del país con la temperatura media trimestral mayor.
        */

        private string[] nombrePais;
        private int[,] temperaturas;
        private int[] tempmedia;

        public void cargarValores()
        {
            nombrePais = new string[4];
            temperaturas = new int[4, 3];
            tempmedia = new int[4];
            for (int i = 0; i < nombrePais.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del pais: ");
                Console.WriteLine("");
                string linea = Console.ReadLine();
                nombrePais[i] = linea;

                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {

                    Console.WriteLine("ingrese las temperaturas mensuales de "+ nombrePais[i]);
                    linea = Console.ReadLine();
                    temperaturas[i, j] = int.Parse(linea);

                }
            }
        }

        public void imprimir()
        {
            for (int i = 0; i < nombrePais.Length; i++)
            {
               Console.WriteLine("pais: " + nombrePais[i]);

                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    Console.WriteLine("temperatura: " + temperaturas[i,j]);
                  
                }
            }

        }

        public void calcular()
        {
            int aux = 0;
            int promedio =0;
            for (int i = 0; i < nombrePais.Length; i++)
            {
                Console.WriteLine("pais: " + nombrePais[i]);

                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                   
                   aux = aux + temperaturas[i, j];
                }

                promedio = aux / temperaturas.GetLength(1);
                tempmedia[i] = promedio;
                Console.WriteLine("temperatura media:" + promedio);
            }


        }

        public void tempMayor()
        {
            string nombre = nombrePais[0];
            int temp = tempmedia[0];

            for(int i = 0;i < nombrePais.Length; i++)
            {
                if (tempmedia[i] > temp)
                {
                    temp = tempmedia[i];
                    nombre = nombrePais[i];
                }

            }
            Console.WriteLine("el pais con mayor media: " + nombre + " con " + temp + "de media");
        }

        static void Main(string[] args)
        {
            mediaTemp paises = new mediaTemp();
            paises.cargarValores();
            paises.imprimir();
            paises.calcular();
            paises.tempMayor();
            Console.ReadKey();
        }
    }
}
