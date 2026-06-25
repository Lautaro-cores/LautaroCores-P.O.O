using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    partial class JuegoArcade
    {
        int record = 10000;
        public bool SuperaRecord()
        {
            if (puntajeMaximo > record)
            {
                record = puntajeMaximo;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
