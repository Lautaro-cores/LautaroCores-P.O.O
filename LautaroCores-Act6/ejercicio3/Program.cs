using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class empleado
    {
        /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
sus datos y por último uno que imprima un mensaje si debe pagar impuestos
(si el sueldo supera a 3000).*/
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
