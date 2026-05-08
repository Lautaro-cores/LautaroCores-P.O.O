using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class logistica
    {
        /*1. Sistema de Logística: Envíos por Sucursal
Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
cantidad diferente de paquetes por día dependiendo de su demanda.
● Definir un vector de tipo string para los nombres de las 3 sucursales.
● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
represente el peso (en kg) de cada paquete enviado.
● Métodos:
1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
paquetes se enviaron hoy para definir el tamaño de su fila.
2. Cargar el peso de cada paquete.
3. Imprimir el peso de todos los paquetes organizados por sucursal.
4. Calcular e informar el peso total despachado por cada sucursal.
5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
pertenece.*/
        private string[] sucursal;
        private int[][] pesos;


        private void CargaValores()
        {
            sucursal = new string[3];
            pesos = new int[3][];

            Console.WriteLine("ingrese los nombres de las sucursales: ");
            for (int i = 0; i < sucursal.Length; i++) {
                Console.Write("");
                string linea = Console.ReadLine();
                sucursal[i] = linea;
            }
            for (int i = 0; i < pesos.Length; i++) {
                Console.WriteLine("ingrese la cantidad de paquetes que envio " + sucursal[i]);
                 string linea = Console.ReadLine();
                pesos[i] = new int[int.Parse(linea)];
               
            }
          
        }

        private void CargaPeso()
        {

            for (int i = 0; i < sucursal.Length; i++)
            {
                Console.WriteLine("ingrese los pesos de los paquetes enviados por " + sucursal[i]);
                for (int j = 0; j < pesos[i].Length; j++)
                {
                    string linea = Console.ReadLine();
                    pesos[i][j] = int.Parse(linea);
                    while (int.Parse(linea) < 1000)
                    {
                        Console.WriteLine("ingrese el peso del paquete en kilos");
                        linea = Console.ReadLine();
                        pesos[i][j] = int.Parse(linea);
                    }


                }
            }
        }

        private void ImprimirPesos()
        {
            Console.WriteLine("el peso de todos los paquetes son");
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.WriteLine (sucursal[i] + ":");
                for (int j = 0; j < pesos[i].Length; j++)
                {
                    Console.WriteLine(pesos[i][j]);
                }
            }

        }

        private void CalcularPesos()
        {
            for (int i = 0; i < pesos.Length; i++)
            {
                int aux = 0;
                Console.Write("el peso total de los paquetes de " + sucursal[i]);
                for (int j = 0; j < pesos[i].Length; j++)
                {
                    
                    aux = aux + pesos[i][j];
                    
                }
                Console.WriteLine(": " + aux);
            }

        }

        private void PesoMayor()
        {
            int aux = 0;
            int mayor = pesos[0][0];
            for (int i = 0; i < pesos.Length; i++)
            {
           
                for (int j = 0; j < pesos[i].Length; j++)
                {

                   if(pesos[i][j] > mayor)
                    {
                        mayor= pesos[i][j];
                        aux = i;
                    }

                }
               
            }
            Console.WriteLine("el paquete mas pesado de la empresa es de " + sucursal[aux] + " con " + mayor );

        }

        static void Main(string[] args)
        {
            logistica empresa = new logistica();
            empresa.CargaValores();
            empresa.CargaPeso();
            empresa.ImprimirPesos();
            empresa.CalcularPesos();
            empresa.PesoMayor();
            Console.ReadKey();

        }
    }
}
