using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class empresaVentas
    {
        /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
vectores paralelos, ordenar los datos de mayor a menor según las ventas,
imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
el que menos vendió de los 5 empleados.*/

        private string[] empleado;

        private int[] ventas;

        public void cargaValores()
        {
            empleado = new string[5];
            ventas = new int[5];
            Console.WriteLine("ingrese el nombre de 5 empleados");
            for (int i = 0; i < empleado.Length; i++)
            {
                Console.Write("");
                empleado[i] = Console.ReadLine(); ;
            }
            string linea;

            for (int i = 0; i < empleado.Length; i++)
            {
                Console.WriteLine("ingrese las ventas de " + empleado[i]);
                Console.Write("");
                linea = Console.ReadLine();
                ventas[i] = int.Parse(linea);
            }
        }



        public void ordenarVentas()
        {
            int aux;
            string aux2;
            for (int i = 0; i < empleado.Length; i++)
            {
                for (int j = 0; j < ventas.Length - 1 - i; j++)
                {
                    if (ventas[j] < ventas[j + 1])
                    {
                        aux = ventas[j];
                        ventas[j] = ventas[j + 1];
                        ventas[j + 1] = aux;
                        aux2 = empleado[j];
                        empleado[j] = empleado[j + 1];
                        empleado[j + 1] = aux2;
                    }
                }
            }
            Console.WriteLine("empleado ordenados por ventas");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine(empleado[i] + ": " + ventas[i]);
            }

        }

        public void menorVentas()
        {

            int baja = ventas[0];
            for (int i = 0; i < empleado.Length; i++)
            {
                if (baja > ventas[i])
                {
                    baja = ventas[i];
                }
            }
            Console.WriteLine("los empleados con la menores ventas son :");
            for (int i = 0; i < empleado.Length; i++)
            {
                if (baja == ventas[i])
                {

                    Console.WriteLine(empleado[i] + ": " + ventas[i]);
                }
            }


        }
        static void Main(string[] args)
        {
            empresaVentas empleados = new empresaVentas();
            empleados.cargaValores();
            empleados.ordenarVentas();
            empleados.menorVentas();
            Console.ReadKey();
        }
    }
}