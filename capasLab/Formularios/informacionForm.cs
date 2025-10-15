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
                {
                    nueva.TipoPlatino = (int)cantBoletosNd.Value;
                }
                else if (tipoEntCbx.Text == "VIP")
                {
                    nueva.TipoVIP = (int)cantBoletosNd.Value;
                }
                else if (tipoEntCbx.Text == "General")
                {
                    nueva.TipoGeneral = (int)cantBoletosNd.Value;
                }

                ReservaCSV.Guardar(nueva);

                FacturaForm objFactura = new FacturaForm(objEvento);
                objFactura.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al procesar la compra:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
