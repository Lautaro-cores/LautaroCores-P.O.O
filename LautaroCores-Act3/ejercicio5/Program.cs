using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5.  Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 

            int num1, num2;
            string linea;
            Console.WriteLine("Ingrese el primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 != 0 && num1 != 0)
            {

                if (num1 > 0 && num2 > 0)
                {
                    Console.WriteLine("El punto se encuentra en el primer cuadrante");
                }
                else if (num1 < 0 && num2 > 0)
                {
                    Console.WriteLine("El punto se encuentra en el segundo cuadrante");
                }


            }
            Console.ReadKey();
        }
    }
}
