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
            try
            {
                var totales = ReservaCSV.LeerTotalesUsados();
                var objEvento = new Evento(totales.usadosEst, totales.usadosPlatino, totales.usadosVIP, totales.usadosGeneral);

                objEvento.ProcesarDatos(tipoEntCbx.Text, (int)cantBoletosNd.Value, (int)cantEstacionNd.Value);

                Reservas nueva = new Reservas();
                nueva.Fecha = DateTime.Now;
                nueva.CantidadEntradas = (int)cantBoletosNd.Value;
                nueva.CantidadEstacionamiento = (int)cantEstacionNd.Value;

                nueva.TipoPlatino = 0;
                nueva.TipoVIP = 0;
                nueva.TipoGeneral = 0;

                if (tipoEntCbx.Text == "Platino")
                    nueva.TipoPlatino = (int)cantBoletosNd.Value;
                else if (tipoEntCbx.Text == "VIP")
                    nueva.TipoVIP = (int)cantBoletosNd.Value;
                else if (tipoEntCbx.Text == "General")
                    nueva.TipoGeneral = (int)cantBoletosNd.Value;

                ReservaCSV.Guardar(nueva);

                FacturaForm objFactura = new FacturaForm(objEvento);
                objFactura.Show();
                this.Hide();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Cupos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la compra:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
