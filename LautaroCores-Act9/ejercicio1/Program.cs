using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class calificacionAlumno
    {

        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.*/

        private int[] calificacion;
        private string[]alumno;
        public void cargarValores() {
            alumno = new string[3];
            calificacion = new int[3];
            Console.WriteLine("ingrese el nombre de los 6 alumnos");
            for (int i = 0; i < alumno.Length; i++)
            {
                Console.Write("");
                alumno[i] = Console.ReadLine(); ;
            }
            string linea;

            for (int i = 0; i < alumno.Length; i++)
            {
                Console.WriteLine("ingrese la calificacion de " + alumno[i]);
                Console.Write("");
                linea = Console.ReadLine();
                calificacion[i] = int.Parse(linea);
            }
        }

        public void informeNotas()
        {
            int alta = calificacion[0];
            for (int i = 0;i < alumno.Length; i++)
            {
                if(alta < calificacion[i])
                {
                    alta=calificacion[i];
                }
            }
            Console.WriteLine("los alumnos con la mayor nota son :");
            for (int i = 0; i<alumno.Length; i++)
            {
                if (alta == calificacion[i])
                {
        
                    Console.WriteLine(alumno[i]+ ": "+ calificacion[i]);
                }
            }
            int baja = calificacion[0];
            for (int i = 0; i < alumno.Length; i++)
            {
                if (baja > calificacion[i])
                {
                    baja = calificacion[i];
                }
            }
            Console.WriteLine("los alumnos con la menor nota son :");
            for (int i = 0; i < alumno.Length; i++)
            {
                if (baja == calificacion[i])
                {
                   
                    Console.WriteLine(alumno[i] + ": " + calificacion[i]);
                }
            }


        }
        
        
        





        static void Main(string[] args)
        {
            calificacionAlumno alumno = new calificacionAlumno();
            alumno.cargarValores();
            alumno.informeNotas();
            Console.ReadKey();
        }
    }
}
