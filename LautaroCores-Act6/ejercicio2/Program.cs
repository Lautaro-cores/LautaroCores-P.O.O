using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class cuadrado
    {
        private int num, perimetro, superficie;
        private string linea;

        public void cargarValor()
        {
            Console.Write("cargar un lado del cuadrado: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            calcularPerimetro(num);
            calcularSuperficie(num);
        }

        public void calcularPerimetro(int n)
        {
            perimetro = n * 4;
            Console.WriteLine("el perimetro del cuadrado es " + perimetro);
        }
        public void calcularSuperficie(int n)
        {
            superficie = n * num;
            Console.WriteLine("la superficie del cuadrado es " + superficie);
        }

        static void Main(string[] args)
        {
            cuadrado cuadrado = new cuadrado();
            cuadrado.cargarValor();
            Console.ReadKey();
        }
    }
}
