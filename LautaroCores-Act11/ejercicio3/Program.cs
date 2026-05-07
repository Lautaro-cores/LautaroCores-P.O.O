using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class faltasEmpleados
    {

        private string[] nombres;
        private int[][] faltas;

        public void cargaValores()
        {
         nombres = new string[3];
         faltas = new int[3][];

            for (int i = 0; i < faltas.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del empleado: ");
                string linea = Console.ReadLine();
                nombres[i] = linea;

                Console.WriteLine("cuantos dias falto " + nombres[i]);
                linea = Console.ReadLine();
                faltas[i] = new int[int.Parse(linea)];

                Console.WriteLine("ingrese las fechas que falto");
                for (int j = 0; j < faltas[i].Length; j++)
                {

                    Console.WriteLine("");
                    linea = Console.ReadLine();
                    faltas[i][j] = int.Parse(linea);

                }
            }


        }

        public void imprimir()
        {
            Console.WriteLine("cantidad de faltas de los empleados:");
            for (int i = 0;i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]+ ": " + faltas[i].Length);
            }

        }

        public void inasistencia()
        {
            string nombre = nombres[0];
            int menor = faltas[0].Length;
            for (int i = 0; i < faltas.Length; i++)
            {
             
                    if (faltas[i].Length < menor)
                    { 
                    nombre = nombres[i];
                    menor = faltas[i].Length;
                    }
             
            }
            Console.WriteLine("el empleado con menos faltas es: " + nombre + " con " + menor + " faltas");
        }

        static void Main(string[] args)
        {
            faltasEmpleados empleados = new faltasEmpleados();
            empleados.cargaValores();
            empleados.imprimir();
            empleados.inasistencia();
            Console.ReadKey();
        }
    }
}
