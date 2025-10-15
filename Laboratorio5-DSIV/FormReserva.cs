using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio5_DSIV
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
            NUDPlatino.ValueChanged += numericUpDown_ValueChanged;
            NUDVIP.ValueChanged += numericUpDown_ValueChanged;
            NUDGeneral.ValueChanged += numericUpDown_ValueChanged;

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown actual = sender as NumericUpDown;
            int total = (int)(NUDPlatino.Value + NUDVIP.Value + NUDGeneral.Value);
            if (total > 5)
            {
                int exceso = total - 5;
                actual.Value -= exceso;
            }
        }

        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            FormResumen compraForm = new FormResumen();
            compraForm.Show();
            this.Hide();
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
