using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Actividad 1: Sistema de control de vuelos
Problema:
Una aerolínea administra los vuelos programados mediante un sistema orientado a
objetos.
Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
destino y duración en horas. Luego definir una clase derivada VueloInternacional que
herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
desde consola y luego:
 Mostrar los vuelos registrados y el país de destino.
 Informar cuál es el vuelo con mayor duración.
 Mostrar el orden de ejecución de los constructores.*/
namespace ejercicio1
{
    internal class Vuelo
    {
        private int numeroVuelo;
        private string destino;
        private int duracion;

        public int NumeroVuelo {  get { return numeroVuelo; } set { numeroVuelo = value; }}
        public string Destino { get { return destino; } set{ destino = value; } }
        public int Duracion { get { return duracion; } set { duracion = value; } }

        public Vuelo(int num, string dest, int dur) 
        {
            NumeroVuelo = num;
            Destino = dest;
            Duracion = dur;
            Console.WriteLine("Constructor Vuelo echo");
        }

    }

    internal class VueloInternacional : Vuelo
    {
            private string paisDestino;
            public string PaisDestino { get { return paisDestino; } set { paisDestino = value; } }
            public VueloInternacional(int num,string pais,string dest,int dur) : base(num,dest, dur) 
            {
            PaisDestino = pais;
            Console.WriteLine("Constructor VueloInternacional echo");
            }


        static void Main(string[] args)
        {
            List<VueloInternacional> vuelos = new List<VueloInternacional>();
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

                VueloInternacional vuelo = new VueloInternacional(NumeroVuelo,PaisDestino,Destino,Duracion);
                vuelos.Add(vuelo);

            }
            int mayorDuracion = 0;
            string destino = "";
            foreach (var i in vuelos)
            {
                  if (i.Duracion > mayorDuracion)
                {
                    mayorDuracion = i.Duracion;
                    destino = i.Destino;
                }
            }
            Console.WriteLine($"El vuelo con la mayor duracion es de {mayorDuracion} horas con destino a {destino}");
            
            foreach (var vuelo in vuelos)
            {
                Console.WriteLine($"Numero de vuelo :{vuelo.NumeroVuelo}, Destino : {vuelo.paisDestino},{vuelo.Destino}, Duracion : {vuelo.Duracion}h");
            }

            Console.ReadKey();
    }
}
}

