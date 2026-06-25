using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3. Armar una clase parcial JuegoArcade.
En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
NivelDificultad (de 1 a 5). Valores cargados desde consola
En el segundo archivo, implementar un método que indique si un puntaje ingresado
supera el récord o no.
Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.*/
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoArcade[] juegos = new JuegoArcade[4];
            for (int i = 0; i < juegos.Length; i++)
            {
                juegos[i] = new JuegoArcade();

                if (juegos[i].SuperaRecord())
                {
                    Console.WriteLine($"El jugador {i + 1} rompió el récord del juego {juegos[i].NombreJuego} con un puntaje de {juegos[i].PuntajeMaximo}.");
                }

            }
        }
    }
}
