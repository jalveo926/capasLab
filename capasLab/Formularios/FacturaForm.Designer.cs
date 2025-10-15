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
            this.terminarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entradasLbl
            // 
            this.entradasLbl.AutoSize = true;
            this.entradasLbl.Location = new System.Drawing.Point(24, 49);
            this.entradasLbl.Name = "entradasLbl";
            this.entradasLbl.Size = new System.Drawing.Size(57, 20);
            this.entradasLbl.TabIndex = 0;
            this.entradasLbl.Text = "label1";
            // 
            // estacionamientoLbl
            // 
            this.estacionamientoLbl.AutoSize = true;
            this.estacionamientoLbl.Location = new System.Drawing.Point(24, 92);
            this.estacionamientoLbl.Name = "estacionamientoLbl";
            this.estacionamientoLbl.Size = new System.Drawing.Size(57, 20);
            this.estacionamientoLbl.TabIndex = 1;
            this.estacionamientoLbl.Text = "label2";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(24, 134);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(57, 20);
            this.subtotalLbl.TabIndex = 2;
            this.subtotalLbl.Text = "label3";
            // 
            // impuestoSPACLbl
            // 
            this.impuestoSPACLbl.AutoSize = true;
            this.impuestoSPACLbl.Location = new System.Drawing.Point(24, 172);
            this.impuestoSPACLbl.Name = "impuestoSPACLbl";
            this.impuestoSPACLbl.Size = new System.Drawing.Size(57, 20);
            this.impuestoSPACLbl.TabIndex = 3;
            this.impuestoSPACLbl.Text = "label4";
            // 
            // subtotal2Lbl
            // 
            this.subtotal2Lbl.AutoSize = true;
            this.subtotal2Lbl.Location = new System.Drawing.Point(24, 216);
            this.subtotal2Lbl.Name = "subtotal2Lbl";
            this.subtotal2Lbl.Size = new System.Drawing.Size(57, 20);
            this.subtotal2Lbl.TabIndex = 4;
            this.subtotal2Lbl.Text = "label5";
            // 
            // itbmsLbl
            // 
            this.itbmsLbl.AutoSize = true;
            this.itbmsLbl.Location = new System.Drawing.Point(24, 256);
            this.itbmsLbl.Name = "itbmsLbl";
            this.itbmsLbl.Size = new System.Drawing.Size(57, 20);
            this.itbmsLbl.TabIndex = 5;
            this.itbmsLbl.Text = "label6";
            // 
            // totalPagarLbl
            // 
            this.totalPagarLbl.AutoSize = true;
            this.totalPagarLbl.ForeColor = System.Drawing.SystemColors.Menu;
            this.totalPagarLbl.Location = new System.Drawing.Point(24, 297);
            this.totalPagarLbl.Name = "totalPagarLbl";
            this.totalPagarLbl.Size = new System.Drawing.Size(57, 20);
            this.totalPagarLbl.TabIndex = 6;
            this.totalPagarLbl.Text = "label7";
            // 
            // estacionDispLbl
            // 
            this.estacionDispLbl.AutoSize = true;
            this.estacionDispLbl.Location = new System.Drawing.Point(24, 358);
            this.estacionDispLbl.Name = "estacionDispLbl";
            this.estacionDispLbl.Size = new System.Drawing.Size(57, 20);
            this.estacionDispLbl.TabIndex = 7;
            this.estacionDispLbl.Text = "label8";
            // 
            // terminarBtn
            // 
            this.terminarBtn.Location = new System.Drawing.Point(92, 410);
            this.terminarBtn.Name = "terminarBtn";
            this.terminarBtn.Size = new System.Drawing.Size(158, 41);
            this.terminarBtn.TabIndex = 8;
            this.terminarBtn.Text = "Terminar pedido";
            this.terminarBtn.UseVisualStyleBackColor = true;
            this.terminarBtn.Click += new System.EventHandler(this.terminarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estacionDispLbl);
            this.groupBox1.Controls.Add(this.terminarBtn);
            this.groupBox1.Controls.Add(this.totalPagarLbl);
            this.groupBox1.Controls.Add(this.itbmsLbl);
            this.groupBox1.Controls.Add(this.subtotal2Lbl);
            this.groupBox1.Controls.Add(this.entradasLbl);
            this.groupBox1.Controls.Add(this.impuestoSPACLbl);
            this.groupBox1.Controls.Add(this.estacionamientoLbl);
            this.groupBox1.Controls.Add(this.subtotalLbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(72, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 467);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(489, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturaForm";
            this.Text = "Factura - Alveo,Quintero, Benjamín";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button terminarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}