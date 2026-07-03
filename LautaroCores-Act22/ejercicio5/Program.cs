using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{/*Actividad 5: Gestión de Carreras Deportivas
Consigna:
Crear un sistema para gestionar carreras deportivas. Cada carrera tiene un código,
una hora de inicio y una hora de fin. Cada carrera puede registrar varios corredores.
Se pide:
1. Crear una clase Carrera con:
o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
definidos.
o Dos constructores (uno por defecto y otro con parámetros).
o Método para calcular la duración de la carrera usando TimeSpan.
2. Crear una clase Corredor con:
o Atributos: nombre, número de dorsal y tiempo total.
o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
horas y minutos).

3. Mostrar en consola (usando Console.SetCursorPosition()):
o La carrera con mayor duración.
o El corredor más rápido.
4. Utilizar this en los constructores o métodos donde corresponda.*/
    internal class Carrera
    {
        private string codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> corredores;

        public string Codigo { get { return codigo; } set { codigo = value; } }
        public DateTime HoraInicio { get { return horaInicio; } set { horaInicio = value; } }
        public DateTime HoraFin { get { return horaFin; } set { horaFin = value; } }
        public List<Corredor> Corredores { get { return corredores; } set { corredores = value; } }


        public Carrera()
        {
            this.Corredores = new List<Corredor>();
        }
        public Carrera(string codigo, DateTime horaInicio, DateTime horaFin, List<Corredor> corredores)
        {
            this.Codigo = codigo;
            this.HoraInicio = horaInicio;
            this.HoraFin = horaFin;
            this.Corredores = corredores;
        }
        public TimeSpan DuracionCarrera()
        {
            TimeSpan duracion = HoraFin - HoraInicio;
            return duracion;
        }
    }
    
    class Corredor
    {
        private string nombre;
        private int numeroDorsal;
        private TimeSpan tiempoTotal;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int NumeroDorsal { get { return numeroDorsal; } set { numeroDorsal = value; } }
        public TimeSpan TiempoTotal { get { return tiempoTotal; } set { tiempoTotal = value; } }
        
        public Corredor(string nombre, int numeroDorsal)
        {
            this.Nombre = nombre;
            this.NumeroDorsal = numeroDorsal;
            this.TiempoTotal = new TimeSpan(0, 0, 0);
        }

        public void RegistrarTiempo(int minutos)
        {
            this.TiempoTotal = new TimeSpan(0, minutos, 0);
        }
        public void RegistrarTiempo(int horas, int minutos)
        {
            this.TiempoTotal = new TimeSpan(horas, minutos, 0);
        }
    
        static void Main(string[] args)
        {


        }
    }
}
