using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class vectorPaises
    {

        private string[] paises;

        public void ordenarPaises()
        {
            string aux;
            paises = new string[] { "Francia", "Brazil", "Argentina", "España", "Venezuela"};
            for (int i = 0; i < paises.Length; i++)
            {
                for (int j = 0; j < paises.Length - 1 - i; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j+1] = aux;  
                    }
                }
            }
            for (int i = 0;i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }
        static void Main(string[] args)
        {
            vectorPaises paises = new vectorPaises();
            paises.ordenarPaises();
            Console.ReadKey();
        }
    }
}
