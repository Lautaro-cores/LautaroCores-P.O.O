using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Actividad 2: Administración de entregas logísticas
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
namespace ejercicio2
{
    class Paquete 
    {
        private int codigo;
        private int peso;
        private string destino;

        public int NumeroVuelo { get { return codigo; } set { codigo = value; } }
        public int Duracion { get { return peso; } set { peso = value; } }
        public string Destino { get { return destino; } set { destino = value; } }

        public Paquete()
        {

        }

    }


     class Despachador
    {
        List<Paquete> paquetes = new List<Paquete>();

        public void CargarPaquete() 
        {

        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero del vuelo");
                int NumeroVuelo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el pais del destino");
                string PaisDestino = Console.ReadLine();
                Console.WriteLine("Ingrese la ciudad del destino");
                string Destino = Console.ReadLine();
                Console.WriteLine("ingrese la duracion del vuelo");
                int Duracion = int.Parse(Console.ReadLine());

                VueloInternacional vuelo = new VueloInternacional(NumeroVuelo, PaisDestino, Destino, Duracion);
                vuelos.Add(vuelo);

            }

        }
    }
}
