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
            //1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            //$500, realizar un programa que lea los sueldos que cobra cada empleado e
            //informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            //de $300.Además el programa deberá informar el importe que gasta la empresa
            //en sueldos al personal.

            int empleados, sueldo, contadorEmpleado,contador100, contador500, total;
            string linea;

            contadorEmpleado = 0;
            contador100 = 0;
            contador500 = 0;
            total = 0;

            Console.WriteLine("ingrese la cantidad de empleados");
            linea = Console.ReadLine();
            empleados = int.Parse(linea);

            while (empleados > contadorEmpleado)
            {
                Console.WriteLine("ingrese el sueldo entre 100 y 500");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);

                if (sueldo > 100 && sueldo < 300) {
                        contador100 = contador100 + 1;
                }
                else 
                {
                    if (sueldo > 300 && sueldo <500 )
                    contador500 = contador500 + 1;
                }
                total = total + sueldo;
                contadorEmpleado = contadorEmpleado + 1;
            }
            Console.WriteLine("la cantididad de empleados de sueldo entre 100 y 300 es :" + contador100);
            Console.WriteLine("la cantididad de empleados de sueldo mayor a 300 :" + contador100);
            Console.WriteLine("el importe total de la empresa es:" + total);
            Console.ReadKey();
        }
    }
}
