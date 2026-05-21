using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Socio
    {
        public string nombre;
        public int año;

        public Socio()
        {
            Console.WriteLine("ingrese nombre de socio");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese cuantos años esta en el club");
            string linea = Console.ReadLine();
            año = int.Parse(linea);
        }

    }


    internal class Club
    {
        private Socio socio1, socio2, socio3;

        private Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
           
        }

        private void MayorSocio()
        {
            if(socio1.año > socio2.año && socio1.año > socio3.año)
            {
                Console.WriteLine("el socio mas antiguo es" + socio1.nombre );
            }
            if (socio2.año > socio1.año && socio2.año > socio3.año)
            {
                Console.WriteLine("el socio mas antiguo es" + socio2.nombre);
            }
            else
            {
                Console.WriteLine("el socio mas antiguo es" + socio3.nombre);
            }

        }

        static void Main(string[] args)
        {
                Club club = new Club();
            club.MayorSocio();
            Console.ReadKey();
        }
    }
}
