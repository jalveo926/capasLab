namespace Laboratorio5_DSIV
{
    partial class FormReserva
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserva));
            this.lbResEntra = new System.Windows.Forms.Label();
            this.lbTituloForm1 = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.lbResEstac = new System.Windows.Forms.Label();
            this.NUDEstacionamiento = new System.Windows.Forms.NumericUpDown();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnConfirm = new System.Windows.Forms.Button();
            this.NUDPlatino = new System.Windows.Forms.NumericUpDown();
            this.NUDGeneral = new System.Windows.Forms.NumericUpDown();
            this.NUDVIP = new System.Windows.Forms.NumericUpDown();
            this.lbPlatino = new System.Windows.Forms.Label();
            this.lbVIP = new System.Windows.Forms.Label();
            this.lbGeneral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEstacionamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPlatino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDVIP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbResEntra
            // 
            this.lbResEntra.AutoSize = true;
            this.lbResEntra.BackColor = System.Drawing.Color.GhostWhite;
            this.lbResEntra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResEntra.Location = new System.Drawing.Point(142, 362);
            this.lbResEntra.Name = "lbResEntra";
            this.lbResEntra.Size = new System.Drawing.Size(278, 37);
            this.lbResEntra.TabIndex = 0;
            this.lbResEntra.Text = "Reservar entradas";
            // 
            // lbTituloForm1
            // 
            this.lbTituloForm1.AutoSize = true;
            this.lbTituloForm1.BackColor = System.Drawing.Color.MediumOrchid;
            this.lbTituloForm1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloForm1.Location = new System.Drawing.Point(103, 40);
            this.lbTituloForm1.Name = "lbTituloForm1";
            this.lbTituloForm1.Size = new System.Drawing.Size(862, 57);
            this.lbTituloForm1.TabIndex = 4;
            this.lbTituloForm1.Text = "LOS MEJORES EVENTOS DE  PANAMÁ";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.BackColor = System.Drawing.Color.Thistle;
            this.lbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalle.Location = new System.Drawing.Point(371, 148);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(301, 116);
            this.lbDetalle.TabIndex = 5;
            this.lbDetalle.Text = "PRECIOS DE ENTRADAS:\r\n        + Platino:........ $150 \r\n        + VIP:..........." +
    "... $100 \r\n        + General:...... $50 \r\n";
            // 
            // lbResEstac
            // 
            this.lbResEstac.AutoSize = true;
            this.lbResEstac.BackColor = System.Drawing.Color.GhostWhite;
            this.lbResEstac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResEstac.Location = new System.Drawing.Point(555, 362);
            this.lbResEstac.Name = "lbResEstac";
            this.lbResEstac.Size = new System.Drawing.Size(386, 37);
            this.lbResEstac.TabIndex = 2;
            this.lbResEstac.Text = "Reservar estacionamiento";
            // 
            // NUDEstacionamiento
            // 
            this.NUDEstacionamiento.BackColor = System.Drawing.Color.Thistle;
            this.NUDEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDEstacionamiento.Location = new System.Drawing.Point(748, 418);
            this.NUDEstacionamiento.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDEstacionamiento.Name = "NUDEstacionamiento";
            this.NUDEstacionamiento.Size = new System.Drawing.Size(120, 30);
            this.NUDEstacionamiento.TabIndex = 12;
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackColor = System.Drawing.Color.Black;
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnCancel.Location = new System.Drawing.Point(336, 580);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(160, 56);
            this.bttnCancel.TabIndex = 15;
            this.bttnCancel.Text = "Cancelar";
            this.bttnCancel.UseVisualStyleBackColor = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnConfirm
            // 
            this.bttnConfirm.BackColor = System.Drawing.Color.Black;
            this.bttnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnConfirm.Location = new System.Drawing.Point(530, 580);
            this.bttnConfirm.Name = "bttnConfirm";
            this.bttnConfirm.Size = new System.Drawing.Size(160, 56);
            this.bttnConfirm.TabIndex = 16;
            this.bttnConfirm.Text = "Confirmar";
            this.bttnConfirm.UseVisualStyleBackColor = false;
            this.bttnConfirm.Click += new System.EventHandler(this.bttnConfirm_Click);
            // 
            // NUDPlatino
            // 
            this.NUDPlatino.BackColor = System.Drawing.Color.Thistle;
            this.NUDPlatino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDPlatino.Location = new System.Drawing.Point(284, 417);
            this.NUDPlatino.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDPlatino.Name = "NUDPlatino";
            this.NUDPlatino.Size = new System.Drawing.Size(120, 30);
            this.NUDPlatino.TabIndex = 17;
            // 
            // NUDGeneral
            // 
            this.NUDGeneral.BackColor = System.Drawing.Color.Thistle;
            this.NUDGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDGeneral.Location = new System.Drawing.Point(284, 501);
            this.NUDGeneral.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDGeneral.Name = "NUDGeneral";
            this.NUDGeneral.Size = new System.Drawing.Size(120, 30);
            this.NUDGeneral.TabIndex = 18;
            // 
            // NUDVIP
            // 
            this.NUDVIP.BackColor = System.Drawing.Color.Thistle;
            this.NUDVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDVIP.Location = new System.Drawing.Point(284, 458);
            this.NUDVIP.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDVIP.Name = "NUDVIP";
            this.NUDVIP.Size = new System.Drawing.Size(120, 30);
            this.NUDVIP.TabIndex = 18;
            // 
            // lbPlatino
            // 
            this.lbPlatino.AutoSize = true;
            this.lbPlatino.BackColor = System.Drawing.Color.Thistle;
            this.lbPlatino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlatino.Location = new System.Drawing.Point(182, 418);
            this.lbPlatino.Name = "lbPlatino";
            this.lbPlatino.Size = new System.Drawing.Size(87, 29);
            this.lbPlatino.TabIndex = 19;
            this.lbPlatino.Text = "Platino";
            // 
            // lbVIP
            // 
            this.lbVIP.AutoSize = true;
            this.lbVIP.BackColor = System.Drawing.Color.Thistle;
            this.lbVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVIP.Location = new System.Drawing.Point(219, 457);
            this.lbVIP.Name = "lbVIP";
            this.lbVIP.Size = new System.Drawing.Size(50, 29);
            this.lbVIP.TabIndex = 20;
            this.lbVIP.Text = "VIP";
            // 
            // lbGeneral
            // 
            this.lbGeneral.AutoSize = true;
            this.lbGeneral.BackColor = System.Drawing.Color.Thistle;
            this.lbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneral.Location = new System.Drawing.Point(170, 501);
            this.lbGeneral.Name = "lbGeneral";
            this.lbGeneral.Size = new System.Drawing.Size(99, 29);
            this.lbGeneral.TabIndex = 21;
            this.lbGeneral.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Parking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGeneral);
            this.Controls.Add(this.lbVIP);
            this.Controls.Add(this.lbPlatino);
            this.Controls.Add(this.NUDVIP);
            this.Controls.Add(this.NUDGeneral);
            this.Controls.Add(this.NUDPlatino);
            this.Controls.Add(this.bttnConfirm);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.NUDEstacionamiento);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.lbTituloForm1);
            this.Controls.Add(this.lbResEstac);
            this.Controls.Add(this.lbResEntra);
            this.Name = "Form1";
            this.Text = "Reserva - Irvin, Quintero, Alveo";
            ((System.ComponentModel.ISupportInitialize)(this.NUDEstacionamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPlatino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDVIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResEntra;
        private System.Windows.Forms.Label lbTituloForm1;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.Label lbResEstac;
        private System.Windows.Forms.NumericUpDown NUDEstacionamiento;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnConfirm;
        private System.Windows.Forms.NumericUpDown NUDPlatino;
        private System.Windows.Forms.NumericUpDown NUDGeneral;
        private System.Windows.Forms.NumericUpDown NUDVIP;
        private System.Windows.Forms.Label lbPlatino;
        private System.Windows.Forms.Label lbVIP;
        private System.Windows.Forms.Label lbGeneral;
        private System.Windows.Forms.Label label1;
    }
}

