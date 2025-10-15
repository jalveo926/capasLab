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

        private void informacionForm_Load(object sender, EventArgs e)
        {
            cantEstacionNd.Hide();
            estacionamientoLbl.Hide();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void estCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (estCheck.Checked)
            {
                cantEstacionNd.Show();
                estacionamientoLbl.Show();
            }
            else
            {
                cantEstacionNd.Hide();
                estacionamientoLbl.Hide();
                cantEstacionNd.Value = 0;
            }
        }

        private void tipoEntCbx_Validating(object sender, CancelEventArgs e)
        {
            if (tipoEntCbx.SelectedItem == null) { 
                errorProvider1.SetError(tipoEntCbx, "Debe seleccionar un tipo de entrada");
                e.Cancel = true;
            }else errorProvider1.SetError(tipoEntCbx, string.Empty);

        }
    }
}
