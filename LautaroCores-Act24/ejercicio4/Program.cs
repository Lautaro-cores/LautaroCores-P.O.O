using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ejercicio4
{
    class Ticket
    {
        private string patente;
        private int horasEstadia;

        public string Patente { get { return patente; } }
        public int HorasEstadia { get { return horasEstadia; } }

        public Ticket(string pat, int hs)
        {
            patente = pat;
            horasEstadia = hs;
        }
    }


    class GestionEstacionamiento
    {
        List<Ticket> Lista = new List<Ticket>();

        public void RegistrarIngreso()
        {
            Console.WriteLine("Ingrese la patente del auto");
            string patente = Console.ReadLine();
            Console.WriteLine($"Ingrese la cantidad de horas de {patente}");
            int horas = int.Parse(Console.ReadLine());
            Ticket documento = new Ticket(patente, horas);
            Lista.Add(documento);
        }

        public void ProcesarSalida()
        {
            if (Lista.Count != 0)
            {
                Ticket DocumentoN1 = Lista[0];
                Console.WriteLine($"Patente del auto: {DocumentoN1.Patente}, Cantidad de Horas: {DocumentoN1.HorasEstadia}");
                Thread.Sleep(1000);
                Console.WriteLine($"Salida del auto terminada");
                Lista.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay autos para salir");
            }

        }

        public void MostrarAutosEstacionados() 
        {

            foreach (Ticket auto in Lista)
            {
                Console.WriteLine($"Patente del auto: {auto.Patente}, Cantidad de Horas: {auto.HorasEstadia}");
            }
            Console.WriteLine($"Cantidad de auto estacionados: {Lista.Count}");

        }

        static void Main(string[] args)
        {
            GestionEstacionamiento estacionamiento = new GestionEstacionamiento();
            estacionamiento.RegistrarIngreso();
            estacionamiento.RegistrarIngreso();
            estacionamiento.ProcesarSalida();
            estacionamiento.MostrarAutosEstacionados();
            Console.ReadKey();
        }
    }
}
