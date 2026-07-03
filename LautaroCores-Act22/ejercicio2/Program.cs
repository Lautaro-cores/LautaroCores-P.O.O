using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*Actividad 2: Posicionamiento de elementos en consola
Problema:
Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
 Implementar propiedades y un constructor que cargue valores.
 Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
nombre en pantalla y Console.CursorVisible para ocultar el cursor.
 Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
consola.*/

    internal class ElementoPantalla
    {
        private string nombre;
        private int posX;
        private int posY;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int PosX { get { return posX; } set { posX = value; } }
        public int PosY { get { return posY; } set { posY = value; } }

        public ElementoPantalla(string nombre, int posX, int posY)
        {
            this.Nombre = nombre;
            this.PosX = posX;
            this.PosY = posY;
        }

        public void Mostrar()
        {
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Nombre);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];

            elementos[0] = new ElementoPantalla("Elemento 1", 10, 5);
            elementos[1] = new ElementoPantalla("Elemento 2", 25, 14);
            elementos[2] = new ElementoPantalla("Elemento 3", 67, 25);
            elementos[3] = new ElementoPantalla("Elemento 4", 43, 22);

            foreach (var elemento in elementos)
            {
                elemento.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
