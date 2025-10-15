using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace capasLab
{
    public partial class FacturaForm : Form
    {   
        Evento objEvento;
        public FacturaForm(Evento objEvento)
        {
            InitializeComponent();
            this.objEvento = objEvento;
        }

        public static string AFormatoBalboa(double valor)
        {
            CultureInfo panama = new CultureInfo("es-PA");
            return string.Format(panama, "{0:C}", valor);
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            entradasLbl.Text = "Entradas (" + objEvento.cantEntrada.ToString()+"x" +objEvento.tipoEntrada +"):     " + AFormatoBalboa(objEvento.montoEntrada) ;
            estacionamientoLbl.Text = "Estacionamiento (" + objEvento.cantEstacionamiento.ToString() + "):     " + AFormatoBalboa(objEvento.montoEstacionamiento);
            subtotalLbl.Text = "Subtotal: " + AFormatoBalboa(objEvento.subtotal);
            impuestoSPACLbl.Text = "Impuesto SPAC (5%): " + AFormatoBalboa(objEvento.sub1SPAC);
            subtotal2Lbl.Text = "Subtotal 2: " + AFormatoBalboa(objEvento.subtotal2);
            itbmsLbl.Text = "Impuesto ITBMS (7%): " + AFormatoBalboa(objEvento.sub2ITBMS);
            totalPagarLbl.Text = "Total: " + AFormatoBalboa(objEvento.total);
            estacionDispLbl.Text = "Estacionamientos disponibles: " + objEvento.TraerCupoEstacionamiento().ToString();

        }
    }
}
