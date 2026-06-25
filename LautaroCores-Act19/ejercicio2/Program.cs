using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Crear una clase parcial Libro.
En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
cantidad de páginas sea mayor a 10. Valores cargados desde consola
En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
si el libro es corto (menos de 100 páginas) o largo.
Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.*/
namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro[] libros = new Libro[2];
            int mayorPaginas = 0;
            string libroMayorPaginas = "";
            for (int i = 0; i < 2; i++)
            {
                libros[i] = new Libro();
                if (libros[i].Paginas > mayorPaginas)
                {
                    mayorPaginas = libros[i].Paginas;
                    libroMayorPaginas = libros[i].Titulo;
                }
                libros[i].Resumen();
            }
            Console.WriteLine($"El libro más extenso es: {libroMayorPaginas} con {mayorPaginas} páginas.");
        }
    }
}
