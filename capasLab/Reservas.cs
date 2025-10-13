using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capasLab
{
    internal class Reservas
    {
        public DateTime Fecha { get; set; }
        public int CantidadEntradas { get; set; }
        public int TipoPlatino { get; set; }
        public int TipoVIP { get; set; }
        public int TipoGeneral { get; set; }
        public int CantidadEstacionamiento { get; set; }
    }
}
