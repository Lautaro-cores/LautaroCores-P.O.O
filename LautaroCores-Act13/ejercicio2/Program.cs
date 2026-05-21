using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Operaciones
    {
        /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
 constructor, calcular su suma, resta, multiplicación y división, cada una en un
 método, imprimir dichos resultados.*/
        private int num1;
        private int num2;

        private Operaciones() {
            Console.WriteLine("ingrese el primer valor");
            string linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo valor");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }

        private void Suma()
        {
            int suma = num1 + num2;
            Console.WriteLine("suma de los valores: " + suma);
        }

        private void Resta()
        {
            int resta = num1 - num2;
            Console.WriteLine("resta de los valores: " + resta);
        }

        private void Multiplicacion()
        {
            int multi = num1 * num2;
            Console.WriteLine("multiplicacion de los valores: " + multi);
        }
        
        private void Division()
        {
            int div = num1 / num2;
            Console.WriteLine("division de los valores: " +  div);
        }





        static void Main(string[] args)
        {
            Operaciones valores = new Operaciones();
            valores.Suma();
            valores.Resta();
            valores.Multiplicacion();
            valores.Division();
            Console.ReadKey();
        }
    }
}
