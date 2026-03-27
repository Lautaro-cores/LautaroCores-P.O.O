using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cuenta con la siguiente información:
● Las edades de 20 estudiantes del turno mañana.
● Las edades de 30 estudiantes del turno tarde.
● Las edades de 15 estudiantes del turno noche.
Las edades de cada estudiante deben ingresarse por teclado.
a) Obtener el promedio de las edades de cada turno (tres promedios)
b) Imprimir dichos promedios (promedio de cada turno)
c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
promedio de edades menor.*/

            int num,prom1,prom2,prom3,cont1,cont2,cont3;
            string linea;

            cont1 = 0;
            cont2= 0;
            cont3 = 0;

            for (int i = 0; i < 20; i++) { 
                Console.WriteLine("ingrese las edades del turno mañana");
                linea= Console.ReadLine();
                num = int.Parse(linea);
                cont1 = cont1 + num;
            }
            for (int i = 0; i < 30; i++) {
                Console.WriteLine("ingrese las edades del turno tarde");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                cont2 = cont2 + num;
            }
            for (int i = 0; i < 15; i++) {
                Console.WriteLine("ingrese las edades del turno noche");
                linea = Console.ReadLine();
                num = int.Parse(linea);
                cont3 = cont3 + num;
            }
            prom1 = cont1 / 20;
            prom2 = cont2 / 30;
            prom3 = cont3 / 15;
            Console.WriteLine("promedio turno mañana:" + prom1);
            Console.WriteLine("promedio turno tarde:" + prom2);
            Console.WriteLine("promedio turno noche:" + prom3);
            if(prom1 < prom2 && prom1 < prom3)
            {
                Console.WriteLine("el promedio mas bajo es el turno mañana");
            }else if (prom2 < prom1 && prom2 < prom3)
            {
                Console.WriteLine("el promedio mas bajo es el turno tarde");
            }
            else
            {
                Console.WriteLine("el promedio mas bajo es el turno noche");
            }
           
        }
    }
}
