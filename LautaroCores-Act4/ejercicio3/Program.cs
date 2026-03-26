using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Realizar un programa que acumule(sume) valores ingresados por teclado hasta
            //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int numero, total;
            string linea;
            total = 0;

            do
            {
                Console.WriteLine("ingrese un numero para sumar:");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

                if (numero != 9999)
                {
                    total = total + numero;
                }
            }
            while (numero != 9999);
            Console.WriteLine("total de la suma: " + total);
            if (total == 0)
            {
                Console.WriteLine("el valor es igual a 0");
            }
            else
            {
                if (total > 0)
                {
                    Console.WriteLine("el valor es mayor a 0");
                }
                else
                {
                    Console.WriteLine("el valor es menor a 0");
                }
            }
            Console.ReadKey();
        }
    }
}

