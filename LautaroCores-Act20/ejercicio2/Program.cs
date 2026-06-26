using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Actividad 2: Administración de entregas logísticas
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
namespace ejercicio2
{
    class Paquete 
    {
        private int codigo;
        private int peso;
        private string destino;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public int Peso { get { return peso; } set { peso = value; } }
        public string Destino { get { return destino; } set { destino = value; } }

        public Paquete(int cod, int peso, string dest)
        {
            Codigo = cod;
            Peso = peso;
            Destino = dest;
        }

    }
     class Despachador
    {
        List<Paquete> paquetes = new List<Paquete>();

        public void CargarPaquete(Paquete paquete) 
        {
            paquetes.Add(paquete);
        }

        public void MostrarPaquetes()
        {
            foreach (var paquete in paquetes)
            {
                Console.WriteLine($"Codigo: {paquete.Codigo}, Peso: {paquete.Peso}, Destino: {paquete.Destino}");
            }
        }

        public void SuperanPeso()
        {
            int contador = 0;
            foreach (var paquete in paquetes)
            {
                if (paquete.Peso > 10)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Cantidad de paquetes que superan los 10 kg: {contador}");
        }

        public void DestinoNacional()
        {
            int contador = 0;
            foreach (var paquete in paquetes)
            {
                if (paquete.Destino == "Argentina")
                {
                    contador++;
                }
            }
            Console.WriteLine($"Cantidad de paquetes con destino nacional: {contador}");
        }

        static void Main(string[] args)
        {
            Despachador despachador = new Despachador();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el codigo del paquete");
                int Codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el peso del paquete");
                int Peso = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el destino del paquete");
                string Destino = Console.ReadLine();

                Paquete paquete = new Paquete(Codigo, Peso, Destino);
                despachador.CargarPaquete(paquete);
            }
            despachador.MostrarPaquetes();
            despachador.SuperanPeso();
            despachador.DestinoNacional();
            Console.ReadKey();
        }
    }
}
