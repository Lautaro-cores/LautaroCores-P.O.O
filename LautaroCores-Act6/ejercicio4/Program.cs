using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class calculadora
    {
        private int num1, num2,suma,resta,multi,division;
        private string linea;

        public void cargarNum()
        {
            Console.Write("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1= int.Parse(linea);
            Console.Write("ingrese el segundo numero: ");
            linea = Console.ReadLine(); 
            num2= int.Parse(linea);
            calcularSuma(num1, num2);
            calcularResta(num1, num2);
            calcularMultiplicacion(num1, num2);
            calcularDivision(num1, num2);
        }
        public void calcularSuma(int n1, int n2)
        {
            suma= n1 + n2;
            Console.WriteLine("la suma de los numero es: " + suma);
        }
        public void calcularResta(int n1, int n2)
        {
            resta= n1 - n2;
            Console.WriteLine("la resta de los numero es: " + resta);
        }
        public void calcularMultiplicacion(int n1, int n2) 
        { 
            multi = n1 * n2;
            Console.WriteLine("la multiplicacion de los numero es: " + multi);
        }
        public void calcularDivision(int n1, int n2) 
        { 
            division = n1 / n2;
            Console.WriteLine("la division de los numero es: " + division);
        }
        static void Main(string[] args)
        {
            calculadora num = new calculadora();
            num.cargarNum();
        }
    }
}
