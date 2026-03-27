using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/

            int cant, lado1, lado2, lado3, equi, isos, esca;
            string linea;

            equi = 0;
            isos = 0;
            esca = 0;

            Console.WriteLine("ingrese una cantidad de triangulos");
            linea = Console.ReadLine();
            cant = int.Parse(linea);

            for (int i = 0; i < cant; i++)
            {

                Console.Write("ingrese un lado del triangulo: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.Write("ingrese un lado del triangulo: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.Write("ingrese un lado del triangulo: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2 && lado2 == lado3)
                {
                    equi++;
                    Console.WriteLine("este triangulo es equilatero");
                }
                else
                {
                    if ((lado1 == lado2 && lado2 != lado3) || (lado1 != lado2 && lado2 == lado3))
                    {
                        isos++;
                        Console.WriteLine("este triangulo es isoceles");
                    }
                    else
                    { 
                        esca++;
                        Console.WriteLine("este triangulo es escaleno");

                    }
                }
            }
            Console.WriteLine("cantidad de equilateros: " + equi);
            Console.WriteLine("cantidad de isoseles: " + isos);
            Console.WriteLine("cantidad de escalenos: " + esca);
            if (equi < isos && equi < esca)
            {
                Console.WriteLine("equilatero es el que tiene menos triangulos");
            }
            else
            {
                if (isos < esca && isos < equi)
                {
                    Console.WriteLine("isoceles es el que tiene menos triangulos");
                }
                else
                {
                    Console.WriteLine("escaleno es el que tiene menos triangulos");
                }
            }
        }
    }
}