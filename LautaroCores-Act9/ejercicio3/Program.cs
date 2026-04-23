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
        /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
carrera de 100 metros. El programa debe cargar los datos en dos vectores
paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
promedio.*/

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
            int mejor = tiempos[0];
            for (int i = 0; i < atleta.Length; i++)
            {
                if (mejor > tiempos[i])
                {
                    mejor = tiempos[i];
                }
            }
            Console.WriteLine("el atleta con el mejor tiempo es :");
            for (int i = 0; i < atleta.Length; i++)
            {
                if (mejor == tiempos[i])
                {

                    Console.WriteLine(atleta[i] + ": " + tiempos[i]);
                }
            }
            int peor = tiempos[0];
            for (int i = 0; i < atleta.Length; i++)
            {
                if (peor < tiempos[i])
                {
                    peor = tiempos[i];
                }
            }
            Console.WriteLine("el atleta con el peor tiempo es :");
            for (int i = 0; i < atleta.Length; i++)
            {
                if (peor == tiempos[i])
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
