using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio1
{
    partial class ReservaHotel
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;

        public string NombreCliente 
        { 
            get 
            { 
                return nombreCliente; 
            }
            set 
            { 
                nombreCliente = value; 
            } 
        }
        public int CantidadNoches
        {
            get
            {
                return cantidadNoches;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("La cantidad de noches tiene que ser mayor a cero.");
                    CantidadNoches = int.Parse(Console.ReadLine());
                }
                else
                {
                    cantidadNoches = value;
                }
            }
        }
        public string TipoHabitacion 
        {
            get 
            { 
                return tipoHabitacion;
            } 
            set 
            {
                if (value == "simple" || value == "doble" || value == "suite")
                    tipoHabitacion = value;
                else
                    tipoHabitacion = "simple"; 
            } 
        }

        public ReservaHotel()
        {
            Console.WriteLine("Ingrese el nombre del cliente: ");
            NombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de noches: ");
            CantidadNoches = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de habitación (Simple, Doble, Suite): ");
            TipoHabitacion = Console.ReadLine();
        }
    }
}
