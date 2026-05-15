using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class CineAsientos
    {
        /*2. Gestión de Complejo de Cine
Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
● Definir una matriz irregular de 4 filas para representar los asientos.
● Métodos:
1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
intervención del operador).
2. Crear un método de &quot;Venta de Entradas&quot; que permita cargar la edad del
espectador en un asiento específico (fila y columna).
3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
en cada asiento.
4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
5. Informar cuál es el promedio de edad de los espectadores de todo el
complejo.*/

        private int[][] asientos;

        private void CargarMatriz()
        {
            asientos = new int[4][];
            asientos[0] = new int[10];
            asientos[1] = new int[15];
            asientos[2] = new int[8];
            asientos[3] = new int[12];
        }

        private void VentaEntradas()
        {
     
            int edad = 0;

            for (int i = 0; i < asientos.Length; i++)
            {
                
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    Console.WriteLine("ingrese su edad");
                    string linea = Console.ReadLine();
                    edad = int.Parse(linea);

                    asientos[i][j] = edad;
                }
            }
          
   
        }

        private void MapaAsientos()
        {
            for (int i = 0; i < asientos.Length; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    Console.Write(" [ "  + asientos[i][j] + " ] ");
                }
            }
            Console.WriteLine("");
        }

        private void CalcularMenores()
        {
            
            for (int i = 0; i < asientos.Length; i++)
            {
                int menores = 0;

                for (int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][j] < 18 && asientos[i][j] != 0) {
                    menores++;
                    } 
                }
                Console.WriteLine("en la sale " + i + " hay " + menores + " menores de edad");
            }
            
        }

        private void PromedioEdad ()
        {
            int aux = 0;
            int aux2 = 0;
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][j] != 0)
                    {
                        aux += asientos[i][j];
                        aux2++;
                    }
                }
            }
            int promedio = aux / aux2;
            Console.WriteLine("el promedio de edad en todo el cine es de " + promedio);
        }

        static void Main(string[] args)
        {
            CineAsientos cine = new CineAsientos();
            cine.CargarMatriz();
            cine.VentaEntradas();
            cine.MapaAsientos();
            cine.CalcularMenores();
            cine.PromedioEdad();
            Console.ReadKey();
        }
    }
}
