using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capasLab
{
    public class Reservas
    {
        public DateTime Fecha { get; set; }
        public int CantidadEntradas { get; set; }
        public int TipoPlatino { get; set; }
        public int TipoVIP { get; set; }
        public int TipoGeneral { get; set; }
        public int CantidadEstacionamiento { get; set; }
    }
}