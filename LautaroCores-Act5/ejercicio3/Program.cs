using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.
             */

            int num, neg, pos, mul,sum;
            string linea;

            neg = 0;
            pos = 0;
            mul = 0;
            sum = 0;
            for (int i = 0; i < 10; i++)
            {

                Console.Write("ingrese un numero: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                if (num < 0)
                {
                    neg++;
                }
                else
                {
                    if (num > 0)
                    {
                        pos++;

                    }
                }
                if(num % 15 == 0)
                {
                    mul++;
                }
                if(num % 2  == 0)
                {
                    sum = num + sum;
                }
            }
            Console.WriteLine("cantidad de numeros negativos: " + neg);
            Console.WriteLine("cantidad de numeros positivos: " + pos);
            Console.WriteLine("cantidad de multiplos de 15: " + mul);
            Console.WriteLine("valor sumado de los pares: " + sum);
            Console.ReadKey();
        }
    }
}