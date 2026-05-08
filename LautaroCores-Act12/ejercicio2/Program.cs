using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
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
        }


        static void Main(string[] args)
        {
        }
    }
}
