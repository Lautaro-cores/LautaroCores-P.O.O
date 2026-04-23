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
            //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.

            int num1, num2, num3, resultado;
            string linea;
            Console.WriteLine("Ingrese el primer numero");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer numero");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 == num2)
            {

                if (num2 == num3)
                {

                    resultado = (num1 + num2);
                    Console.WriteLine("La suma de los dos primeros numeros es: " + resultado);
                    resultado = resultado * num3;
                    Console.WriteLine("El resultado de multiplicar la suma por el tercer numero es: " + resultado);

                }
                else
                {
                    Console.WriteLine("el segundo numero y el tercer numero no son iguales");
                }
            }
            else
            {
                Console.WriteLine("el primer numero y el segundo numero no son iguales");
            }

            Console.ReadKey();
        }
    }
}

