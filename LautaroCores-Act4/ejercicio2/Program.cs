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

            //2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
            //(No se ingresan valores por teclado)
            int numero, contador;
            string linea;
            numero = 0;
            contador = 0;

            while (contador < 25)
            {
                numero = numero + 11;
                contador++;
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
