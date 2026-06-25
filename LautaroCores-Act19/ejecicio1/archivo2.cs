using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio1
{
    partial class ReservaHotel
    {
        public int TotalPagar()
        {
            int totalPagar = 0;
            if (TipoHabitacion == "simple")
            {
                totalPagar = 5000 * CantidadNoches;
            }
            else if (TipoHabitacion == "doble")
            {
                totalPagar = 8000 * CantidadNoches;
            }
            else if (TipoHabitacion == "suite")
            {
                totalPagar = 12000 * CantidadNoches;
            }
            return totalPagar;
        }

    }
}
