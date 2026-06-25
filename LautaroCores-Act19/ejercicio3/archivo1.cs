using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    partial class JuegoArcade
    {
        private string nombreJuego;
        private int puntajeMaximo;
        private int nivelDificultad;

        public string NombreJuego
        {
            get { return nombreJuego; }
            set { nombreJuego = value; }
        }
        public int PuntajeMaximo
        {
            get { return puntajeMaximo; }
            set { puntajeMaximo = value; }
        }
        public int NivelDificultad
        {
            get { return nivelDificultad; }
            set
            {
                if (value < 1 || value > 5)
                {
                    Console.WriteLine("El nivel de dificultad tiene que ser entre 1 y 5.");
                    NivelDificultad = int.Parse(Console.ReadLine());
                }
                else{nivelDificultad = value;}
            }
        }

        public JuegoArcade()
        {
            Console.WriteLine("Ingrese el nombre del juego:");
            NombreJuego = Console.ReadLine();
            Console.WriteLine("Ingrese el puntaje máximo del juego:");
            PuntajeMaximo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel de dificultad del juego (1 a 5):");
            NivelDificultad = int.Parse(Console.ReadLine());
        }
    }
}