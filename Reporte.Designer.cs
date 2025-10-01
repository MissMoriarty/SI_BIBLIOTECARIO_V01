namespace SI_BIBLIOTECARIO
{
    partial class Reporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_nuevos = new System.Windows.Forms.Label();
            this.lbl_prestamos = new System.Windows.Forms.Label();
            this.lbl_devoluciones = new System.Windows.Forms.Label();
            this.lbl_reparaciones = new System.Windows.Forms.Label();
            this.lbl_perdidas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "REPORTE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 474);
            this.dataGridView1.TabIndex = 15;
            // 
            // lbl_nuevos
            // 
            this.lbl_nuevos.AutoSize = true;
            this.lbl_nuevos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nuevos.Location = new System.Drawing.Point(601, 219);
            this.lbl_nuevos.Name = "lbl_nuevos";
            this.lbl_nuevos.Size = new System.Drawing.Size(324, 38);
            this.lbl_nuevos.TabIndex = 16;
            this.lbl_nuevos.Text = "Nuevos ejemplares:";
            // 
            // lbl_prestamos
            // 
            this.lbl_prestamos.AutoSize = true;
            this.lbl_prestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prestamos.Location = new System.Drawing.Point(601, 292);
            this.lbl_prestamos.Name = "lbl_prestamos";
            this.lbl_prestamos.Size = new System.Drawing.Size(193, 38);
            this.lbl_prestamos.TabIndex = 17;
            this.lbl_prestamos.Text = "Préstamos:";
            // 
            // lbl_devoluciones
            // 
            this.lbl_devoluciones.AutoSize = true;
            this.lbl_devoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_devoluciones.Location = new System.Drawing.Point(601, 367);
            this.lbl_devoluciones.Name = "lbl_devoluciones";
            this.lbl_devoluciones.Size = new System.Drawing.Size(236, 38);
            this.lbl_devoluciones.TabIndex = 18;
            this.lbl_devoluciones.Text = "Devoluciones:";
            // 
            // lbl_reparaciones
            // 
            this.lbl_reparaciones.AutoSize = true;
            this.lbl_reparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reparaciones.Location = new System.Drawing.Point(601, 446);
            this.lbl_reparaciones.Name = "lbl_reparaciones";
            this.lbl_reparaciones.Size = new System.Drawing.Size(241, 38);
            this.lbl_reparaciones.TabIndex = 19;
            this.lbl_reparaciones.Text = "Reparaciones:";
            // 
            // lbl_perdidas
            // 
            this.lbl_perdidas.AutoSize = true;
            this.lbl_perdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perdidas.Location = new System.Drawing.Point(601, 524);
            this.lbl_perdidas.Name = "lbl_perdidas";
            this.lbl_perdidas.Size = new System.Drawing.Size(164, 38);
            this.lbl_perdidas.TabIndex = 20;
            this.lbl_perdidas.Text = "Perdidas:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 49);
            this.button1.TabIndex = 53;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1315, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_perdidas);
            this.Controls.Add(this.lbl_reparaciones);
            this.Controls.Add(this.lbl_devoluciones);
            this.Controls.Add(this.lbl_prestamos);
            this.Controls.Add(this.lbl_nuevos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_nuevos;
        private System.Windows.Forms.Label lbl_prestamos;
        private System.Windows.Forms.Label lbl_devoluciones;
        private System.Windows.Forms.Label lbl_reparaciones;
        private System.Windows.Forms.Label lbl_perdidas;
        private System.Windows.Forms.Button button1;
    }
}