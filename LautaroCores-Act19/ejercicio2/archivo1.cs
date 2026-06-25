using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    partial class Libro
    {
        private string titulo;
        private string autor;
        private int paginas;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Paginas

        {
            get { return paginas; }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("La cantidad de páginas tiene que ser mayor a 10.");
                    paginas = int.Parse(Console.ReadLine());
                }
                else { paginas = value; }
            }
        }

        public Libro()
        {
            Console.WriteLine("Ingrese el título del libro:");
            Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro:");
            autor = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de páginas del libro:");
            Paginas = int.Parse(Console.ReadLine());
        }
    }
}
