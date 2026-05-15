using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class academiaGatronomia
    {
        /*3. Academia de Gastronomía: Recetario Dinámico
Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
● Definir un vector para los nombres de los alumnos.
● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
presentado.
● Métodos:
1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
de cada alumno.
2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
(promedio &gt;= 70) o &quot;Reprobado&quot;.
5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
valor máximo de la matriz).*/

        private int[][] puntuaciones;
        private string[] participantes;

        private void Inicializar()
        {
            participantes = new string[3];
            for (int i = 0; i < participantes.Length; i++) { 
            Console.WriteLine("ingrese el nombre del participante " + (i + 1) );
            string linea = Console.ReadLine();
            participantes[i] = linea;
        }
            puntuaciones = new int[3][];
            puntuaciones[0] = new int[2];
            puntuaciones[1] = new int[4];
            puntuaciones[2] = new int[3];
        }

        private void CargaPuntuaciones()
        {
            for (int i = 0; i < participantes.Length; i++)
            {
                for(int j = 0; j < puntuaciones[i].Length; j++)
                {
                    Console.WriteLine("ingrese la puntuacion del plato N° " + (j + 1) +" del participante " + participantes[i] );
                    string linea = Console.ReadLine();
                    puntuaciones[i][j] = int.Parse(linea);
                    while (puntuaciones[i][j] > 100 || puntuaciones[i][j] < 0) {
                        Console.WriteLine("ingrese una puntuacion del 0 al 100");
                        linea = Console.ReadLine();
                        puntuaciones[i][j] = int.Parse(linea);

                    }
                }

            }
        }
        
        private void ImprimirListado()
        {
            Console.WriteLine("Las puntuaciones de cada participante son:");
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine(participantes[i] + ":");
                for (int j = 0; j < puntuaciones[i].Length; j++)
                {
                    Console.WriteLine("Plato N°" + (j + 1) + " :" + puntuaciones[i][j]);
                }
            }
        }

        private void PromedioPuntuaciones()
        {
            for (int i = 0; i < participantes.Length; i++)
            {
                int aux = 0;
                int promedio = 0;
                for (int j = 0; j < puntuaciones[i].Length; j++)
                {
                    aux += puntuaciones[i][j];
                }
                promedio = aux/ puntuaciones[i].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine("el participante " + participantes[i] + " esta aprobado");
                }
                else
                {
                    Console.WriteLine("el participante " + participantes[i] + " esta reprobado");
                }
            }

        }

        private void MayorPuntaje()
        {
            int mayor = puntuaciones[0][0];
            int aux = 0;
            for (int i = 0; i < participantes.Length; i++)
            { 
                for (int j = 0; j < puntuaciones[i].Length; j++)
                {
                    if (puntuaciones[i][j] > mayor  )
                    {
                        mayor = puntuaciones[i][j];
                        aux = i;
                    }
                }
            }
            Console.WriteLine("el participante " + participantes[aux] + " obtuvo el puntaje mas alto en un plato con una puntuacion de " + mayor);

        }

        static void Main(string[] args)
        {
            academiaGatronomia masterchef = new academiaGatronomia();
            masterchef.Inicializar();
            masterchef.CargaPuntuaciones();
            masterchef.ImprimirListado();
            masterchef.PromedioPuntuaciones();
            masterchef.MayorPuntaje();
            Console.ReadKey();
        }
    }
}
