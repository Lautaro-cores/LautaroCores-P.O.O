using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    /*
3. Competencia de Atletismo
Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
Definir los siguientes métodos en la clase Carrera:
Un constructor que cargue los datos de los 3 atletas de la carrera.
Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
Un método que calcule e imprima el tiempo promedio de la carrera.
Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
Un método que muestre a los atletas que superaron el promedio.
*/
    internal class Atleta
    {
        private string nombre;
        private double tiempoSegundos;
        public Atleta(string n, double ts)
        {
            nombre = n;
            tiempoSegundos = ts;
        }
        public string Nombre()
        { 
            return nombre;  
        }
        public double TiempoSegundos() 
        {
            return tiempoSegundos; 
        }
    }

    internal class Carrera
    {
        private Atleta atleta1, atleta2, atleta3;
  
        public Carrera()
        {
            atleta1 = new Atleta("Atleta 1", 12.5);
            atleta2 = new Atleta("Atleta 2", 11.8);
            atleta3 = new Atleta("Atleta 3", 13.2);
        }
        public void ImprimirLista()
        {
            Console.WriteLine($"{atleta1.Nombre()}: {atleta1.TiempoSegundos()} segundos");
            Console.WriteLine($"{atleta2.Nombre()}: {atleta2.TiempoSegundos()} segundos");
            Console.WriteLine($"{atleta3.Nombre()}: {atleta3.TiempoSegundos()} segundos");
        }
        public void Promedio()
        {
            double promedio = (atleta1.TiempoSegundos() + atleta2.TiempoSegundos() + atleta3.TiempoSegundos()) / 3;
            Console.WriteLine($"Tiempo promedio: {promedio} segundos");
        }
        public void Ganador()
        {
            Atleta ganador = atleta1;
            if (atleta2.TiempoSegundos() < ganador.TiempoSegundos())
                ganador = atleta2;
            if (atleta3.TiempoSegundos() < ganador.TiempoSegundos())
                ganador = atleta3;
            Console.WriteLine($"El ganador es: {ganador.Nombre()} con un tiempo de {ganador.TiempoSegundos()} segundos");
        }
        public void SuperaronPromedio()
        {
            double promedio = (atleta1.TiempoSegundos() + atleta2.TiempoSegundos() + atleta3.TiempoSegundos()) / 3;
            Console.WriteLine("Atletas que superaron el promedio:");
            if (atleta1.TiempoSegundos() < promedio)
                Console.WriteLine(atleta1.Nombre());
            if (atleta2.TiempoSegundos() < promedio)
                Console.WriteLine(atleta2.Nombre());
            if (atleta3.TiempoSegundos() < promedio)
                Console.WriteLine(atleta3.Nombre());
        }
    

        static void Main(string[] args)
        {
            Carrera carrera = new Carrera();
            carrera.ImprimirLista();
            carrera.Promedio();
            carrera.Ganador();
            carrera.SuperaronPromedio();
            Console.ReadKey();

        }
    }
}
