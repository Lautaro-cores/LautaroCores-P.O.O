using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

            int num, multi, resul;
            string linea;

            Console.Write("ingrese un valor del 1 al 10: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num <= 10 && num >= 1)
            {
                for (int i = 1; i < 13; i++)
                {
                    multi = i;
                    resul = num * multi;
                    Console.WriteLine(resul);

                }
            }
            else
            {
                Console.WriteLine("ingrese un numero valido");
            }
        }
    }
}