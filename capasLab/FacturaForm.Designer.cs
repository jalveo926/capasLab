namespace capasLab
{
    partial class FacturaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entradasLbl = new System.Windows.Forms.Label();
            this.estacionamientoLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.impuestoSPACLbl = new System.Windows.Forms.Label();
            this.subtotal2Lbl = new System.Windows.Forms.Label();
            this.itbmsLbl = new System.Windows.Forms.Label();
            this.totalPagarLbl = new System.Windows.Forms.Label();
            this.estacionDispLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entradasLbl
            // 
            this.entradasLbl.AutoSize = true;
            this.entradasLbl.Location = new System.Drawing.Point(184, 157);
            this.entradasLbl.Name = "entradasLbl";
            this.entradasLbl.Size = new System.Drawing.Size(35, 13);
            this.entradasLbl.TabIndex = 0;
            this.entradasLbl.Text = "label1";
            // 
            // estacionamientoLbl
            // 
            this.estacionamientoLbl.AutoSize = true;
            this.estacionamientoLbl.Location = new System.Drawing.Point(184, 180);
            this.estacionamientoLbl.Name = "estacionamientoLbl";
            this.estacionamientoLbl.Size = new System.Drawing.Size(35, 13);
            this.estacionamientoLbl.TabIndex = 1;
            this.estacionamientoLbl.Text = "label2";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(184, 206);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(35, 13);
            this.subtotalLbl.TabIndex = 2;
            this.subtotalLbl.Text = "label3";
            // 
            // impuestoSPACLbl
            // 
            this.impuestoSPACLbl.AutoSize = true;
            this.impuestoSPACLbl.Location = new System.Drawing.Point(184, 237);
            this.impuestoSPACLbl.Name = "impuestoSPACLbl";
            this.impuestoSPACLbl.Size = new System.Drawing.Size(35, 13);
            this.impuestoSPACLbl.TabIndex = 3;
            this.impuestoSPACLbl.Text = "label4";
            // 
            // subtotal2Lbl
            // 
            this.subtotal2Lbl.AutoSize = true;
            this.subtotal2Lbl.Location = new System.Drawing.Point(184, 266);
            this.subtotal2Lbl.Name = "subtotal2Lbl";
            this.subtotal2Lbl.Size = new System.Drawing.Size(35, 13);
            this.subtotal2Lbl.TabIndex = 4;
            this.subtotal2Lbl.Text = "label5";
            // 
            // itbmsLbl
            // 
            this.itbmsLbl.AutoSize = true;
            this.itbmsLbl.Location = new System.Drawing.Point(184, 294);
            this.itbmsLbl.Name = "itbmsLbl";
            this.itbmsLbl.Size = new System.Drawing.Size(35, 13);
            this.itbmsLbl.TabIndex = 5;
            this.itbmsLbl.Text = "label6";
            // 
            // totalPagarLbl
            // 
            this.totalPagarLbl.AutoSize = true;
            this.totalPagarLbl.Location = new System.Drawing.Point(184, 332);
            this.totalPagarLbl.Name = "totalPagarLbl";
            this.totalPagarLbl.Size = new System.Drawing.Size(35, 13);
            this.totalPagarLbl.TabIndex = 6;
            this.totalPagarLbl.Text = "label7";
            // 
            // estacionDispLbl
            // 
            this.estacionDispLbl.AutoSize = true;
            this.estacionDispLbl.Location = new System.Drawing.Point(184, 366);
            this.estacionDispLbl.Name = "estacionDispLbl";
            this.estacionDispLbl.Size = new System.Drawing.Size(35, 13);
            this.estacionDispLbl.TabIndex = 7;
            this.estacionDispLbl.Text = "label8";
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estacionDispLbl);
            this.Controls.Add(this.totalPagarLbl);
            this.Controls.Add(this.itbmsLbl);
            this.Controls.Add(this.subtotal2Lbl);
            this.Controls.Add(this.impuestoSPACLbl);
            this.Controls.Add(this.subtotalLbl);
            this.Controls.Add(this.estacionamientoLbl);
            this.Controls.Add(this.entradasLbl);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entradasLbl;
        private System.Windows.Forms.Label estacionamientoLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label impuestoSPACLbl;
        private System.Windows.Forms.Label subtotal2Lbl;
        private System.Windows.Forms.Label itbmsLbl;
        private System.Windows.Forms.Label totalPagarLbl;
        private System.Windows.Forms.Label estacionDispLbl;
    }
}