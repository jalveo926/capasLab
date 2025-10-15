namespace capasLab
{
    partial class informacionForm
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
            this.components = new System.ComponentModel.Container();
            this.tipoEntCbx = new System.Windows.Forms.ComboBox();
            this.cantBoletosNd = new System.Windows.Forms.NumericUpDown();
            this.cantEstacionNd = new System.Windows.Forms.NumericUpDown();
            this.pagarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estacionamientoLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estCheck = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cantBoletosNd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantEstacionNd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoEntCbx
            // 
            this.tipoEntCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoEntCbx.FormattingEnabled = true;
            this.tipoEntCbx.Items.AddRange(new object[] {
            "Platino",
            "VIP",
            "General"});
            this.tipoEntCbx.Location = new System.Drawing.Point(27, 68);
            this.tipoEntCbx.Name = "tipoEntCbx";
            this.tipoEntCbx.Size = new System.Drawing.Size(120, 28);
            this.tipoEntCbx.TabIndex = 0;
            this.tipoEntCbx.Validating += new System.ComponentModel.CancelEventHandler(this.tipoEntCbx_Validating);
            // 
            // cantBoletosNd
            // 
            this.cantBoletosNd.Location = new System.Drawing.Point(27, 150);
            this.cantBoletosNd.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cantBoletosNd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantBoletosNd.Name = "cantBoletosNd";
            this.cantBoletosNd.Size = new System.Drawing.Size(39, 26);
            this.cantBoletosNd.TabIndex = 1;
            this.cantBoletosNd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cantEstacionNd
            // 
            this.cantEstacionNd.Location = new System.Drawing.Point(27, 285);
            this.cantEstacionNd.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cantEstacionNd.Name = "cantEstacionNd";
            this.cantEstacionNd.Size = new System.Drawing.Size(39, 26);
            this.cantEstacionNd.TabIndex = 2;
            // 
            // pagarBtn
            // 
            this.pagarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pagarBtn.Location = new System.Drawing.Point(115, 338);
            this.pagarBtn.Name = "pagarBtn";
            this.pagarBtn.Size = new System.Drawing.Size(102, 38);
            this.pagarBtn.TabIndex = 3;
            this.pagarBtn.Text = "Pagar";
            this.pagarBtn.UseVisualStyleBackColor = true;
            this.pagarBtn.Click += new System.EventHandler(this.pagarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estCheck);
            this.groupBox1.Controls.Add(this.estacionamientoLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pagarBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tipoEntCbx);
            this.groupBox1.Controls.Add(this.cantBoletosNd);
            this.groupBox1.Controls.Add(this.cantEstacionNd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(127, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 392);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese la información solicitada";
            // 
            // estacionamientoLbl
            // 
            this.estacionamientoLbl.AutoSize = true;
            this.estacionamientoLbl.Location = new System.Drawing.Point(22, 247);
            this.estacionamientoLbl.Name = "estacionamientoLbl";
            this.estacionamientoLbl.Size = new System.Drawing.Size(312, 20);
            this.estacionamientoLbl.TabIndex = 8;
            this.estacionamientoLbl.Text = "Elija la cantidad de estacionamientos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elija la cantidad de boletos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elija su tipo de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(168, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "BLOCKBUSTER";
            // 
            // estCheck
            // 
            this.estCheck.AutoSize = true;
            this.estCheck.Location = new System.Drawing.Point(26, 204);
            this.estCheck.Name = "estCheck";
            this.estCheck.Size = new System.Drawing.Size(264, 24);
            this.estCheck.TabIndex = 9;
            this.estCheck.Text = "¿Necesita estacionamientos?";
            this.estCheck.UseVisualStyleBackColor = true;
            this.estCheck.CheckedChanged += new System.EventHandler(this.estCheck_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // informacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(600, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "informacionForm";
            this.Text = "Información - Alveo, Irvin, Quintero";
            this.Load += new System.EventHandler(this.informacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantBoletosNd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantEstacionNd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipoEntCbx;
        private System.Windows.Forms.NumericUpDown cantBoletosNd;
        private System.Windows.Forms.NumericUpDown cantEstacionNd;
        private System.Windows.Forms.Button pagarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label estacionamientoLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox estCheck;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

