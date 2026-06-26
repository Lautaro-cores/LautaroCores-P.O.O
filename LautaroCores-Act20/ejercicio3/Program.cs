using ejercicio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Actividad 3: Estadísticas de visitas a zonas arqueológicas
Problema:
Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
arqueológicas durante 4 semanas.
Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
días. Luego:
 Calcular el total de visitas por zona y almacenarlo en un vector.
 Mostrar los datos en forma tabular.
 Agregar estos resultados a una lista llamada zonasVisitadas que contenga
nombres de zonas y total de visitas.
 Determinar cuál fue la zona más visitada.*/
namespace ejercicio3
{
    class Zonas
    {
        private string nombreZona;
        private int totalVisitas;
        public string NombreZona { get { return nombreZona; } set { nombreZona = value; } }
        public int TotalVisitas { get { return totalVisitas; } set { totalVisitas = value; } }

        public Zonas(string nombre, int visitas)
        {
            NombreZona = nombre;
            TotalVisitas = visitas;
        }
    }

    class Arqueologia
    {
        private int[,] VisitasSemanales;
        private int[] VisitasTotales;
        List<Zonas> ZonaVisitas = new List<Zonas>();
        public Arqueologia()
        {
            VisitasSemanales = new int[3, 4];
            VisitasTotales = new int[3];

            for (int i = 0; i < VisitasSemanales.GetLength(0); i++)
            {
                for (int j = 0; j < VisitasSemanales.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el numero de visitas de la zona {i + 1} en la semana {j + 1}");
                    VisitasSemanales[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void TotalVisitas()
        {

            for (int i = 0; i < VisitasSemanales.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < VisitasSemanales.GetLength(1); j++)
                {
                    total += VisitasSemanales[i, j];
                }
                VisitasTotales[i] = total;
            }

            for (int i = 0; i < VisitasTotales.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Las visitas totales de la zona {i + 1} son de {VisitasTotales[i]}");
            }
        }

        public void ImprimirTabla()
        {
            for (int i = 0; i < VisitasSemanales.GetLength(0); i++)
            {
                Console.WriteLine("");
                Console.Write($"Zona {i + 1}  ");
                for (int j = 0; j < VisitasSemanales.GetLength(1); j++)
                {
                    Console.Write($"{VisitasSemanales[i, j]} ");
                }
                Console.WriteLine("");
            }
        }

        public void AgregarList()
        {
            for (int i = 0; i < VisitasTotales.Length; i++)
            {
                string NombreZona;
                Console.WriteLine($"Ingrese el nombre de la zona {i}");
                NombreZona = Console.ReadLine();
                Zonas zona = new Zonas(NombreZona, VisitasTotales[i]);
                ZonaVisitas.Add(zona);
            }
        }

        public void MasVisitada()
        {
            Zonas ZonaMasVisitada = ZonaVisitas[0];
            foreach (var zona in ZonaVisitas)
            {
                if (zona.TotalVisitas > ZonaMasVisitada.TotalVisitas)
                {
                    ZonaMasVisitada = zona;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"La zona mas visitada es la {ZonaMasVisitada.NombreZona} con un total de {ZonaMasVisitada.TotalVisitas} visitas");
        }



        static void Main(string[] args)
        {
            Arqueologia arqueologia = new Arqueologia();
            arqueologia.ImprimirTabla();
            arqueologia.TotalVisitas();
            arqueologia.AgregarList();
            arqueologia.MasVisitada();
            Console.ReadKey();
        }
    }
}

