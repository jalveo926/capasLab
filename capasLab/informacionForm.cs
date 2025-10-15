using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capasLab
{
    public partial class informacionForm : Form
    {
        
        public informacionForm()
        {
            InitializeComponent();
        }

        private void pagarBtn_Click(object sender, EventArgs e)
        {   
            //Aquí hay que poner los datos del csv
            var objEvento = new Evento(0, 0, 0, 0);

            objEvento.ProcesarDatos(tipoEntCbx.Text, int.Parse(cantBoletosNd.Text), int.Parse(cantEstacionNd.Text));

            FacturaForm objFactura = new FacturaForm(objEvento);
            objFactura.Show();
            this.Hide();

        }
    }
}
