using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class empleado
    {
        private int sueldo;
        private string nombre, linea;

        public void cargarValores()
        {
            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese su sueldo: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void imprimirDatos()
        {
            Console.WriteLine("nombre del empleado: " + nombre);
            Console.WriteLine("sueldo del empleado: " + sueldo);
            calcularImpuestos(sueldo);

        }
        
        public void calcularImpuestos(int n)
        {
            if (n > 3000)
            {
                Console.WriteLine("el empleado debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            empleado empleado = new empleado();
            empleado.cargarValores();
            empleado.imprimirDatos();
            Console.ReadKey();
        }
    }
}
