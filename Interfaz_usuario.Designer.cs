namespace SI_BIBLIOTECARIO
{
    partial class Interfaz_usuario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bUSCARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.títuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matemáticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.literaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cienciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noDisponibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTASDELECTURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDeLaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirALaLecturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 38);
            this.label1.TabIndex = 26;
            this.label1.Text = "CATÁLOGO DE LIBROS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SI_BIBLIOTECARIO.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(824, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 615);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bUSCARToolStripMenuItem,
            this.lISTASDELECTURAToolStripMenuItem,
            this.añadirALaLecturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 29);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bUSCARToolStripMenuItem
            // 
            this.bUSCARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.títuloToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.editorialToolStripMenuItem,
            this.categoríaToolStripMenuItem,
            this.estadoToolStripMenuItem});
            this.bUSCARToolStripMenuItem.Name = "bUSCARToolStripMenuItem";
            this.bUSCARToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.bUSCARToolStripMenuItem.Text = "BUSCAR";
            // 
            // títuloToolStripMenuItem
            // 
            this.títuloToolStripMenuItem.Name = "títuloToolStripMenuItem";
            this.títuloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.títuloToolStripMenuItem.Text = "Título";
            this.títuloToolStripMenuItem.Click += new System.EventHandler(this.títuloToolStripMenuItem_Click_1);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editorialToolStripMenuItem.Text = "Editorial";
            this.editorialToolStripMenuItem.Click += new System.EventHandler(this.editorialToolStripMenuItem_Click);
            // 
            // categoríaToolStripMenuItem
            // 
            this.categoríaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matemáticasToolStripMenuItem,
            this.computaciónToolStripMenuItem,
            this.inglésToolStripMenuItem,
            this.literaturaToolStripMenuItem,
            this.cienciaToolStripMenuItem,
            this.arteToolStripMenuItem});
            this.categoríaToolStripMenuItem.Name = "categoríaToolStripMenuItem";
            this.categoríaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.categoríaToolStripMenuItem.Text = "Categoría";
            this.categoríaToolStripMenuItem.Click += new System.EventHandler(this.categoríaToolStripMenuItem_Click);
            // 
            // matemáticasToolStripMenuItem
            // 
            this.matemáticasToolStripMenuItem.Name = "matemáticasToolStripMenuItem";
            this.matemáticasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.matemáticasToolStripMenuItem.Text = "Matemáticas";
            this.matemáticasToolStripMenuItem.Click += new System.EventHandler(this.matemáticasToolStripMenuItem_Click);
            // 
            // computaciónToolStripMenuItem
            // 
            this.computaciónToolStripMenuItem.Name = "computaciónToolStripMenuItem";
            this.computaciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.computaciónToolStripMenuItem.Text = "Computación";
            this.computaciónToolStripMenuItem.Click += new System.EventHandler(this.computaciónToolStripMenuItem_Click);
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            this.inglésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inglésToolStripMenuItem.Text = "Inglés";
            this.inglésToolStripMenuItem.Click += new System.EventHandler(this.inglésToolStripMenuItem_Click);
            // 
            // literaturaToolStripMenuItem
            // 
            this.literaturaToolStripMenuItem.Name = "literaturaToolStripMenuItem";
            this.literaturaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.literaturaToolStripMenuItem.Text = "Literatura";
            this.literaturaToolStripMenuItem.Click += new System.EventHandler(this.literaturaToolStripMenuItem_Click);
            // 
            // cienciaToolStripMenuItem
            // 
            this.cienciaToolStripMenuItem.Name = "cienciaToolStripMenuItem";
            this.cienciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cienciaToolStripMenuItem.Text = "Ciencia";
            this.cienciaToolStripMenuItem.Click += new System.EventHandler(this.cienciaToolStripMenuItem_Click);
            // 
            // arteToolStripMenuItem
            // 
            this.arteToolStripMenuItem.Name = "arteToolStripMenuItem";
            this.arteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arteToolStripMenuItem.Text = "Arte";
            this.arteToolStripMenuItem.Click += new System.EventHandler(this.arteToolStripMenuItem_Click);
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponibleToolStripMenuItem,
            this.noDisponibleToolStripMenuItem});
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estadoToolStripMenuItem.Text = "Estado";
            // 
            // disponibleToolStripMenuItem
            // 
            this.disponibleToolStripMenuItem.Name = "disponibleToolStripMenuItem";
            this.disponibleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disponibleToolStripMenuItem.Text = "Disponible";
            this.disponibleToolStripMenuItem.Click += new System.EventHandler(this.disponibleToolStripMenuItem_Click);
            // 
            // noDisponibleToolStripMenuItem
            // 
            this.noDisponibleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarToolStripMenuItem,
            this.verReservacionesToolStripMenuItem,
            this.eliminarReservacionesToolStripMenuItem});
            this.noDisponibleToolStripMenuItem.Name = "noDisponibleToolStripMenuItem";
            this.noDisponibleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noDisponibleToolStripMenuItem.Text = "No disponible";
            this.noDisponibleToolStripMenuItem.Click += new System.EventHandler(this.noDisponibleToolStripMenuItem_Click);
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.reservarToolStripMenuItem.Text = "Reservar";
            this.reservarToolStripMenuItem.Click += new System.EventHandler(this.reservarToolStripMenuItem_Click);
            // 
            // verReservacionesToolStripMenuItem
            // 
            this.verReservacionesToolStripMenuItem.Name = "verReservacionesToolStripMenuItem";
            this.verReservacionesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.verReservacionesToolStripMenuItem.Text = "Ver reservaciones";
            this.verReservacionesToolStripMenuItem.Click += new System.EventHandler(this.verReservacionesToolStripMenuItem_Click);
            // 
            // eliminarReservacionesToolStripMenuItem
            // 
            this.eliminarReservacionesToolStripMenuItem.Name = "eliminarReservacionesToolStripMenuItem";
            this.eliminarReservacionesToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.eliminarReservacionesToolStripMenuItem.Text = "Eliminar reservaciones";
            this.eliminarReservacionesToolStripMenuItem.Click += new System.EventHandler(this.eliminarReservacionesToolStripMenuItem_Click);
            // 
            // lISTASDELECTURAToolStripMenuItem
            // 
            this.lISTASDELECTURAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadiToolStripMenuItem,
            this.verListaToolStripMenuItem,
            this.eliminarDeLaListaToolStripMenuItem});
            this.lISTASDELECTURAToolStripMenuItem.Name = "lISTASDELECTURAToolStripMenuItem";
            this.lISTASDELECTURAToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.lISTASDELECTURAToolStripMenuItem.Text = "LISTA DE LECTURA";
            // 
            // añadiToolStripMenuItem
            // 
            this.añadiToolStripMenuItem.Name = "añadiToolStripMenuItem";
            this.añadiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.añadiToolStripMenuItem.Text = "Añadir a la lista";
            this.añadiToolStripMenuItem.Click += new System.EventHandler(this.añadiToolStripMenuItem_Click);
            // 
            // verListaToolStripMenuItem
            // 
            this.verListaToolStripMenuItem.Name = "verListaToolStripMenuItem";
            this.verListaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verListaToolStripMenuItem.Text = "Ver lista";
            this.verListaToolStripMenuItem.Click += new System.EventHandler(this.verListaToolStripMenuItem_Click);
            // 
            // eliminarDeLaListaToolStripMenuItem
            // 
            this.eliminarDeLaListaToolStripMenuItem.Name = "eliminarDeLaListaToolStripMenuItem";
            this.eliminarDeLaListaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarDeLaListaToolStripMenuItem.Text = "Eliminar de la lista";
            this.eliminarDeLaListaToolStripMenuItem.Click += new System.EventHandler(this.eliminarDeLaListaToolStripMenuItem_Click);
            // 
            // añadirALaLecturaToolStripMenuItem
            // 
            this.añadirALaLecturaToolStripMenuItem.Name = "añadirALaLecturaToolStripMenuItem";
            this.añadirALaLecturaToolStripMenuItem.Size = new System.Drawing.Size(14, 25);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(543, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 49);
            this.button1.TabIndex = 53;
            this.button1.Text = "CERRAR SESIÓN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Interfaz_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1306, 789);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfaz_usuario";
            this.Text = "Interfaz_usuario";
            this.Load += new System.EventHandler(this.Interfaz_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bUSCARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem títuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matemáticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem literaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cienciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDisponibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTASDELECTURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirALaLecturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDeLaListaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}