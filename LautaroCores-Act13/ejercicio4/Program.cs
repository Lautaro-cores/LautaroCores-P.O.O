using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Alumno
    {

        /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
alumno y sus 4 calificaciones.
Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
Alumno.
Agregar los siguientes métodos:
a) Un método que imprima el nombre de cada alumno y su promedio.
b) Un método que muestre el nombre del alumno con el promedio más
alto.
c) Un método que indique qué alumnos tienen al menos una nota
desaprobada (nota menor a 6)*/

        public string nombre;
        public int[] notas;

        public Alumno()
        {
            notas=new int[4];
            Console.WriteLine("ingrese el nombre del alumno");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese las 4 notas del alumno");
            for (int i = 0; i < 4; i++)
            {
               
                string linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }

        public int Promedio() { 
        
        int aux = 0;
            for(int i = 0; i < 4; i++)
            {
                aux = aux + notas[i];
            }
        int promedio = aux/4;
        
         return promedio;
        }
    } 

    internal class Curso
    {

        private Alumno alumno1, alumno2, alumno3;

        private Curso()
        {
            alumno1 = new Alumno();
            alumno2 = new Alumno();
            alumno3 = new Alumno();
        }

        private void PromedioAlumnos()
        {
            Console.WriteLine("el promedio del alumno " + alumno1.nombre + " es " + alumno1.Promedio());
            Console.WriteLine("el promedio del alumno " + alumno2.nombre + " es " + alumno2.Promedio());
            Console.WriteLine("el promedio del alumno " + alumno3.nombre + " es " + alumno3.Promedio());
        }
        private void PromedioAlto()
        {
            int promedio1 = alumno1.Promedio();
            int promedio2 = alumno2.Promedio();
            int promedio3 = alumno3.Promedio();
            if (promedio1 > promedio2 && promedio1 > promedio3)
            {
                Console.WriteLine("el alumno con el promedio mas alto es " + alumno1.nombre);
            }
            else if (promedio2 > promedio1 && promedio2 > promedio3)
            {
                Console.WriteLine("el alumno con el promedio mas alto es " + alumno2.nombre);
            }
            else
            {
                Console.WriteLine("el alumno con el promedio mas alto es " + alumno3.nombre);
            }
        }

        private void AlumnosDesaprobados()
        {
            if (alumno1.notas[0] < 6 || alumno1.notas[1] < 6 || alumno1.notas[2] < 6 || alumno1.notas[3] < 6)
            {
                Console.WriteLine("el alumno " + alumno1.nombre + " tiene al menos una nota desaprobada");
            }
            if (alumno2.notas[0] < 6 || alumno2.notas[1] < 6 || alumno2.notas[2] < 6 || alumno2.notas[3] < 6)
            {
                Console.WriteLine("el alumno " + alumno2.nombre + " tiene al menos una nota desaprobada");
            }
            if (alumno3.notas[0] < 6 || alumno3.notas[1] < 6 || alumno3.notas[2] < 6 || alumno3.notas[3] < 6)
            {
                Console.WriteLine("el alumno " + alumno3.nombre + " tiene al menos una nota desaprobada");
            }
        }

        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.PromedioAlumnos();
            curso.PromedioAlto();
            curso.AlumnosDesaprobados();
            Console.ReadKey();
        }
    }
}
