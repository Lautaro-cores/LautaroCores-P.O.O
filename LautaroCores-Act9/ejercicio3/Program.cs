using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{

        internal class altletasTiempos
        {
            /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
    realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
    vectores paralelos, ordenar los datos de mayor a menor según las ventas,
    imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
    el que menos vendió de los 5 empleados.*/

            private string[] atleta;

            private int[] tiempos;

            public void cargaValores()
            {
                atleta = new string[5];
                tiempos = new int[5];
                Console.WriteLine("ingrese el nombre de 5 atletas");
                for (int i = 0; i < atleta.Length; i++)
                {
                    Console.Write("");
                    atleta[i] = Console.ReadLine(); ;
                }
                string linea;

                for (int i = 0; i < atleta.Length; i++)
                {
                    Console.WriteLine("ingrese el tiempo de " + atleta[i]);
                    Console.Write("");
                    linea = Console.ReadLine();
                    tiempos[i] = int.Parse(linea);
                }
            }
        public void promedioTiempo() {
        int suma = 0;
        for (int i = 0;i < tiempos.Length; i++)
            {
                suma = suma + tiempos[i];
            }
        int promedio = suma / tiempos.Length;
            Console.WriteLine("el promedio de timepos es "+ promedio);
        
        for (int i = 0; i<tiempos.Length ; i++)
            {
                if (tiempos[i] > promedio)
                {
                    Console.WriteLine("el atleta " + atleta[i] + " supero el promdio de tiempo"); 
                }

            }
        }
        public void tiemposMejores()
        {
            int alta = tiempos[0];
            for (int i = 0; i < atleta.Length; i++)
            {
                if (alta < tiempos[i])
                {
                    alta = tiempos[i];
                }
            }
            Console.WriteLine("el atleta con el mejor tiempo es :");
            for (int i = 0; i < atleta.Length; i++)
            {
                if (alta == tiempos[i])
                {

                    Console.WriteLine(atleta[i] + ": " + tiempos[i]);
                }
            }
            int baja = tiempos[0];
            for (int i = 0; i < atleta.Length; i++)
            {
                if (baja > tiempos[i])
                {
                    baja = tiempos[i];
                }
            }
            Console.WriteLine("el atleta con el peor tiempo es :");
            for (int i = 0; i < atleta.Length; i++)
            {
                if (baja == tiempos[i])
                {

                    Console.WriteLine(atleta[i] + ": " + tiempos[i]);
                }
            }

        }


        static void Main(string[] args)
        {   
            altletasTiempos atleta = new altletasTiempos();
            atleta.cargaValores();
            atleta.tiemposMejores();
            atleta.promedioTiempo();
            Console.ReadKey();
        }
    }
}
