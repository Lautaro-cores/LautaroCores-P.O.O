using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            int dia, mes;
            string linea;
            Console.WriteLine("Ingrese el dia");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.WriteLine("Ingrese el mes");
            linea = Console.ReadLine();
            mes = int.Parse(linea);

            if (dia <= 31 && mes <= 12)
            {

                if (dia == 25 && mes == 12)
                {
                    Console.WriteLine("Feliz Navidad");
                }
                else
                {
                    Console.WriteLine("es un dia normal");
                }



            } else {
                Console.WriteLine("Fecha no valida");

            }
            Console.ReadKey();
        }
    }
}