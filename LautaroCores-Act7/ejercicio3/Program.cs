using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Puntuaciones
    {
        /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
un videojuego. El programa debe:
 Mostrar la puntuación más alta y la más baja.
 Calcular el promedio de puntuación.
 Contar cuántas veces superó los 500 puntos.*/

        private int[] puntuacion;

        public void cargaPuntuacion()
        {
            string linea;
            puntuacion = new int[6];

            Console.WriteLine("ingrese la puntuacion de las 6 partidas");

            for (int i = 0; i < puntuacion.Length; i++)
            {
                Console.WriteLine("");
                linea = Console.ReadLine();
                puntuacion[i] = int.Parse(linea);
            }
        }

        public void puntuacionAltaBaja()
        {
            int alta = 0;
            for (int i = 0; i < puntuacion.Length; i++)
            {
                if (alta < puntuacion[i])
                {
                    alta = puntuacion[i];
                }
            }

            int baja = puntuacion[0];
            for (int i = 0; i < puntuacion.Length; i++)
            { 
                if (baja > puntuacion[i])
                {
                    baja = puntuacion[i];
                }
            } 

            Console.WriteLine("puntuacion mas alta: " + alta);
            Console.WriteLine("puntuacion mas baja: " + baja);
        }

        public void promedioPuntuacion()
        {
            int suma = 0;
            for (int i = 0; i < puntuacion.Length; i++)
            {
                suma = suma + puntuacion[i];
            }
            int promedio = 0;

            promedio = suma / puntuacion.Length;
            Console.WriteLine("el promedio de la puntacion:" + promedio);
        }

        public void puntacion500()
        {
            int suma500 = 0;
            for (int i = 0; i < puntuacion.Length; i++)
            {
               if (puntuacion[i] > 500)
                {
                    suma500 = suma500 + 1;
                }

            }
            Console.WriteLine("veces que se supero los 500 puntos: " + suma500);
        }

        static void Main(string[] args)
        {
            Puntuaciones puntos = new Puntuaciones();
            puntos.cargaPuntuacion();
            puntos.puntuacionAltaBaja();
            puntos.promedioPuntuacion();
            puntos.puntacion500();
            Console.ReadKey();
                }
    }
}
