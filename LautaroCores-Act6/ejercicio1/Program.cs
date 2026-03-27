using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    /*1. Desarrollar una clase que represente un punto en el plano y tenga los
siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)*/
    class plano
    {
        private int puntox, puntoy;
        private string linea;

        public void iniciar()
        {
            Console.Write("ingrese el valor de x: ");
            linea = Console.ReadLine();
            puntox = int.Parse(linea);

            Console.Write("ingrese el valor de y: ");
            linea = Console.ReadLine();
            puntoy = int.Parse(linea);

        }

        public void calcularCuadrante()
        {
            if (puntox > 0 && puntoy > 0)
            {
                Console.WriteLine("el punto esta en el primer cuadrante");
            }
            else if (puntox < 0 && puntoy > 0)
            {
                Console.WriteLine("el punto esta en el segundo cuadrante");
            }
            else if (puntox < 0 && puntoy < 0)
            {
                Console.WriteLine("el punto esta en el tercer cuadrante");
            }
            else
            {
                Console.WriteLine("el punto esta en el cuarto cuadrante");
            }
        }
            static void Main(string[] args)
            {

            plano plano = new plano();
            plano.iniciar();
            plano.calcularCuadrante();
            Console.ReadKey();

            }
        }
    }
