using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LautaroCores_Act13
{
    internal class Empleado
    {

        /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. En el constructor cargar los atributos y luego en otro
método imprimir sus datos y por último uno que imprima un mensaje si debe
pagar impuestos (si el sueldo supera a 3000)*/

        private string nombre;
        private int sueldo;
        private Empleado()
        {

            Console.WriteLine("ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el sueldo");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        private void Imprimir()
        {
            Console.WriteLine("informacion del empleado");
            Console.WriteLine(nombre);
            Console.WriteLine(sueldo);
        }

        private void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("el empleado " + nombre + " debe pagar impuestos");
            }
        }



        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Imprimir();
            empleado.Impuestos();
            Console.ReadKey();

        }
    }
}
