using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4.En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
 cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
 finalizar al ingresar un valor negativo en el número de cuenta.
 Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
 informe:
             a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
             que:
          Estado de la cuenta:
         ○ “Acreedor” si el saldo es &gt; 0.
         ○ “Deudor” si el saldo es &lt; 0.
         ○ “Nulo” si el saldo es = 0.
             b) La suma total de los saldos acreedores.
 */
            int numcuenta, saldo, total;
            string linea;
            total = 0;
            do
            {
                Console.WriteLine("ingrese su numero de cuenta");
                linea = Console.ReadLine();
                numcuenta = int.Parse(linea);
                if (numcuenta >= 0)
                {
                    Console.WriteLine("ingrese su saldo");
                    linea = Console.ReadLine();
                    saldo = int.Parse(linea);
                    
                    if (saldo > 0)
                    {
                        total = total + saldo;
                    }


                }

            }
            while (numcuenta >= 0);
            Console.WriteLine("la suma total de los acreedores es: " + total);

        }
    }
}