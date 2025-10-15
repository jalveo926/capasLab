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
            this.tipoEntCbx = new System.Windows.Forms.ComboBox();
            this.cantBoletosNd = new System.Windows.Forms.NumericUpDown();
            this.cantEstacionNd = new System.Windows.Forms.NumericUpDown();
            this.pagarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantBoletosNd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantEstacionNd)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.tipoEntCbx.Location = new System.Drawing.Point(24, 60);
            this.tipoEntCbx.Name = "tipoEntCbx";
            this.tipoEntCbx.Size = new System.Drawing.Size(120, 21);
            this.tipoEntCbx.TabIndex = 0;
            // 
            // cantBoletosNd
            // 
            this.cantBoletosNd.Location = new System.Drawing.Point(24, 108);
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
            this.cantBoletosNd.Size = new System.Drawing.Size(39, 20);
            this.cantBoletosNd.TabIndex = 1;
            this.cantBoletosNd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cantEstacionNd
            // 
            this.cantEstacionNd.Location = new System.Drawing.Point(24, 149);
            this.cantEstacionNd.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cantEstacionNd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantEstacionNd.Name = "cantEstacionNd";
            this.cantEstacionNd.Size = new System.Drawing.Size(39, 20);
            this.cantEstacionNd.TabIndex = 2;
            this.cantEstacionNd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pagarBtn
            // 
            this.pagarBtn.Location = new System.Drawing.Point(236, 286);
            this.pagarBtn.Name = "pagarBtn";
            this.pagarBtn.Size = new System.Drawing.Size(102, 38);
            this.pagarBtn.TabIndex = 3;
            this.pagarBtn.Text = "Pagar";
            this.pagarBtn.UseVisualStyleBackColor = true;
            this.pagarBtn.Click += new System.EventHandler(this.pagarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoEntCbx);
            this.groupBox1.Controls.Add(this.cantBoletosNd);
            this.groupBox1.Controls.Add(this.cantEstacionNd);
            this.groupBox1.Location = new System.Drawing.Point(136, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese la información solicitada";
            // 
            // informacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pagarBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "informacionForm";
            this.Text = "Información - Alveo, Irvin, Quintero";
            ((System.ComponentModel.ISupportInitialize)(this.cantBoletosNd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantEstacionNd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tipoEntCbx;
        private System.Windows.Forms.NumericUpDown cantBoletosNd;
        private System.Windows.Forms.NumericUpDown cantEstacionNd;
        private System.Windows.Forms.Button pagarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

