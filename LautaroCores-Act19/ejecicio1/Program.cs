using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.*/
namespace ejecicio1
{
     class Program
    {
        static void Main(string[] args)
        {
            ReservaHotel[] hotel = new ReservaHotel[3];
            int mayorPago = 0;
            string clienteMayorPago = "";
            for (int i = 0; i < 3; i++)
            {
                hotel[i] = new ReservaHotel();

                int totalPagar = hotel[i].TotalPagar();

                if (totalPagar > mayorPago)
                {
                    mayorPago = totalPagar;
                    clienteMayorPago = hotel[i].NombreCliente;
                }
            }
            Console.WriteLine($"El cliente que pagará mas es: {clienteMayorPago} con un total de ${mayorPago}");
                }
            }

        }
