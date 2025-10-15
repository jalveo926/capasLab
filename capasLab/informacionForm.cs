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
         
            FacturaForm objFactura = new FacturaForm();
            objFactura.Show();
            this.Hide();
        }
    }
}
