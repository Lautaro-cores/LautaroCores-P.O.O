using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4docentes
{
    internal class evaluacionDocentes
    {
        /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
sus nombres y puntajes promedio obtenidos (de 1 a 10).
Cargar sus datos en vectores paralelos, mostrar docente con calificación más
alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
desaprobaron (tomando como base que se aprueba con una nota mayor o igual
a 6)*/

        private string[] docente;
        private int[] puntaje;

        public void cargaValores()
        {
            docente = new string[6];
            puntaje = new int[6];
            Console.WriteLine("ingrese el nombre de los 6 docentes");
            for (int i = 0; i < docente.Length; i++)
            {
                Console.Write("");
                docente[i] = Console.ReadLine(); ;
            }
            string linea;

            for (int i = 0; i < docente.Length; i++)
            {
                Console.WriteLine("ingrese el puntaje de " + docente[i]);
                Console.Write("");
                linea = Console.ReadLine();
                puntaje[i] = int.Parse(linea);
                while (puntaje[i] < 1 || puntaje[i] > 10)
                {
                    Console.WriteLine("ingrese un puntaje valido entre 1 y 10 ");
                    Console.Write("");
                    linea = Console.ReadLine();
                    puntaje[i] = int.Parse(linea);
                }
            }
        }

        public void mejorPeor()
        {
            int alta = puntaje[0];
            for (int i = 0; i < docente.Length; i++)
            {
                if (alta < puntaje[i])
                {
                    alta = puntaje[i];
                }
            }
            Console.WriteLine("los docentes con la mayor calificacion son :");
            for (int i = 0; i < docente.Length; i++)
            {
                if (alta == puntaje[i])
                {
                    Console.WriteLine(docente[i] + ": " + puntaje[i]);
                }
            }

            int baja = puntaje[0];
            for (int i = 0; i < docente.Length; i++)
            {
                if (baja > puntaje[i])
                {
                    baja = puntaje[i];
                }
            }
            Console.WriteLine("los docentes con la menor calificacion son :");
            for (int i = 0; i < docente.Length; i++)
            {
                if (baja == puntaje[i])
                {
                    Console.WriteLine(docente[i] + ": " + puntaje[i]);
                }
            }
        }

        public void ordenarPuntajes()
        {
            int aux;
            string aux2;
            for (int i = 0; i < docente.Length; i++)
            {
                for (int j = 0; j < puntaje.Length - 1 - i; j++)
                {
                    if (puntaje[j] < puntaje[j + 1])
                    {
                        aux = puntaje[j];
                        puntaje[j] = puntaje[j + 1];
                        puntaje[j + 1] = aux;
                        aux2 = docente[j];
                        docente[j] = docente[j + 1];
                        docente[j + 1] = aux2;
                    }
                }
            }
            Console.WriteLine("docentes ordenados por calificacion");
            for (int i = 0; i < puntaje.Length; i++)
            {
                Console.WriteLine(docente[i] + ": " + puntaje[i]);
            }
        }

        public void aprobadosDesaprobados()
        {
            int aprobados = 0;
            int desaprobados = 0;
            for (int i = 0; i < docente.Length; i++)
            {
                if (puntaje[i] >= 6)
                {
                    aprobados = aprobados + 1;
                }
                else
                {
                    desaprobados = desaprobados + 1;
                }
            }
            Console.WriteLine("cantidad de docentes aprobados: " + aprobados);
            Console.WriteLine("cantidad de docentes desaprobados: " + desaprobados);
        }

        static void Main(string[] args)
        {
            evaluacionDocentes docentes = new evaluacionDocentes();
            docentes.cargaValores();
            docentes.mejorPeor();
            docentes.ordenarPuntajes();
            docentes.aprobadosDesaprobados();
            Console.ReadKey();
        }
    }
}