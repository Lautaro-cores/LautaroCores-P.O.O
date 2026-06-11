using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.*/

    internal class Persona
    {
        private string nombre;
        private int edad;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }
    }

    internal class Empleado : Persona
    {
        private double sueldo;
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        public void ImprimirSueldo()
        {
            Console.WriteLine($"Sueldo: {sueldo}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Edad = 30;
            persona.Imprimir();

            Empleado empleado = new Empleado();
            empleado.Nombre = "Pedro";
            empleado.Edad = 28;
            empleado.Sueldo = 50000;
            empleado.Imprimir();
            empleado.ImprimirSueldo();
        }
    }
}