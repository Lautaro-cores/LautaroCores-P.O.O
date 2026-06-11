using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*3. Crear una clase base Vehículo que contenga atributos marca y
velocidadMaxima.
Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
una debe tener un constructor que reciba los valores de los atributos base
mediante la palabra clave base, y un atributo propio (cantidadPuertas en
Auto, cilindrada en Moto).
Crear un objeto de cada clase y mostrar todos sus datos por consola.*/

    internal class Vehiculo
    {
        private string marca;
        private int velocidadMaxima;

        public string Marca { get { return marca; } set { marca = value; } }
        public int VelocidadMaxima { get { return velocidadMaxima; } set { velocidadMaxima = value; } }
     
    }

    internal class Auto : Vehiculo
    {
        private int cantidadPuertas;
        public int CantidadPuertas { get { return cantidadPuertas; } set { cantidadPuertas = value; } }
    
    }

    internal class Moto : Vehiculo
    {
        private int cilindrada;
        public int Cilindrada { get { return cilindrada; } set { cilindrada = value; } }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Marca = "Toyota";
            auto.VelocidadMaxima = 180;
            auto.CantidadPuertas = 4;

            Moto moto = new Moto();
            moto.Marca = "Honda";
            moto.VelocidadMaxima = 160;
            moto.Cilindrada = 250;

            Console.WriteLine($"Auto  Marca: {auto.Marca}, Velocidad maxima: {auto.VelocidadMaxima}, Cantidad de puertas: {auto.CantidadPuertas}");
            Console.WriteLine($"Moto  Marca: {moto.Marca}, Velocidad maxima: {moto.VelocidadMaxima}, Cilindrada: {moto.Cilindrada}");
            Console.ReadKey();
        }
    }
}
