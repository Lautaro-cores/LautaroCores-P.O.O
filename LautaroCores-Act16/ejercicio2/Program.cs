using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    /*2. Plantear una clase Producto y otra clase Inventario.
La clase Producto debe tener como atributos privados el nombre, precio y
stock. Definir propiedades para acceder a estos atributos, asegurando que el
stock no pueda ser negativo y el precio sea mayor a cero.
La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
método para mostrar todos los productos ordenados de menor a mayor en
base al precio, además, mostrar el producto más caro y más barato del
inventario.*/

    internal class Producto
    {
        private string nombre;
        private double precio;
        private int stock;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
                else
                    Console.WriteLine("El precio debe ser mayor a cero.");
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value >= 0)
                    stock = value;
                else
                    Console.WriteLine("El stock no puede ser negativo.");
            }
        }
    }

    internal class Inventario
    {
        private Producto[] productos;

        public Inventario()
        {
            productos = new Producto[3];
            productos[0] = new Producto();
            productos[0].Nombre = "Teclado";
            productos[0].Precio = 5500;
            productos[0].Stock = 10;

            productos[1] = new Producto();
            productos[1].Nombre = "Monitor";
            productos[1].Precio = 85000;
            productos[1].Stock = 3;

            productos[2] = new Producto();
            productos[2].Nombre = "Mouse";
            productos[2].Precio = 3200;
            productos[2].Stock = 15;
        }

        public void MostrarProductos()
        {
            for (int i = 0; i < productos.Length - 1; i++)
            {
                for (int j = 0; j < productos.Length - 1 - i; j++)
                {
                    if (productos[j].Precio > productos[j + 1].Precio)
                    {
                        Producto temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }
           
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"Producto: {productos[i].Nombre}, Precio: {productos[i].Precio}, Stock: {productos[i].Stock}");
            }

            Console.WriteLine($"Producto mas barato: {productos[0].Nombre}, Precio: {productos[0].Precio}");
            Console.WriteLine($"Producto mas caro: {productos[productos.Length - 1].Nombre}, Precio: {productos[productos.Length - 1].Precio}");

        }

        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            inventario.MostrarProductos();

            Console.ReadKey();
        }
    }
}
