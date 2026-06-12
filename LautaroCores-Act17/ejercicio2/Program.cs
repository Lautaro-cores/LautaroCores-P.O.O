using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
/*2. Catálogo de Películas (Encapsulación, Validación y Composición)
Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del
catálogo.*/
{
    internal class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int DuracionMinutos { get { return duracionMinutos; } set { if (value > 0) { duracionMinutos = value; } } }
        public int Calificacion { get { return calificacion; } set { if (value > 0 && value <= 5) { calificacion = value; } else { calificacion = 1; } } }
    }
    internal class Catalogo
    {
            private Pelicula[] peliculas;

            public Catalogo()
            {
            peliculas = new Pelicula[3];
            peliculas[0].Titulo =

            }


        static void Main(string[] args)
        {
        }
    }
}
