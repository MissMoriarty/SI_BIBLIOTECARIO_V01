namespace SI_BIBLIOTECARIO
{
    partial class Registrar_libro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_estante = new System.Windows.Forms.TextBox();
            this.txt_repisa = new System.Windows.Forms.TextBox();
            this.txt_ejemplares = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_sinopsis = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "REGISTRO DE LIBROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISBN:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "TÍTULO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "AUTOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "EDITORIAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "AÑO DE PUBLICACIÓN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "CATEGORÍA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "ESTANTE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 583);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 12;
            this.label9.Text = "RESPISA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 647);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(349, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "NÚMERO DE EJEMPLARES:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(812, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "SINÓPSIS:";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(206, 160);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(478, 22);
            this.txt_ISBN.TabIndex = 15;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(206, 223);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(478, 22);
            this.txt_titulo.TabIndex = 16;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(206, 281);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(478, 22);
            this.txt_autor.TabIndex = 17;
            // 
            // txt_editorial
            // 
            this.txt_editorial.Location = new System.Drawing.Point(240, 347);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_editorial.TabIndex = 18;
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(366, 406);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(318, 22);
            this.txt_año.TabIndex = 19;
            // 
            // txt_estante
            // 
            this.txt_estante.Location = new System.Drawing.Point(206, 527);
            this.txt_estante.Name = "txt_estante";
            this.txt_estante.Size = new System.Drawing.Size(478, 22);
            this.txt_estante.TabIndex = 21;
            // 
            // txt_repisa
            // 
            this.txt_repisa.Location = new System.Drawing.Point(206, 583);
            this.txt_repisa.Name = "txt_repisa";
            this.txt_repisa.Size = new System.Drawing.Size(478, 22);
            this.txt_repisa.TabIndex = 22;
            // 
            // txt_ejemplares
            // 
            this.txt_ejemplares.Location = new System.Drawing.Point(429, 654);
            this.txt_ejemplares.Name = "txt_ejemplares";
            this.txt_ejemplares.Size = new System.Drawing.Size(255, 22);
            this.txt_ejemplares.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(808, 556);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(271, 49);
            this.btn_registrar.TabIndex = 26;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(808, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 49);
            this.button1.TabIndex = 27;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_sinopsis
            // 
            this.txt_sinopsis.Location = new System.Drawing.Point(815, 220);
            this.txt_sinopsis.Multiline = true;
            this.txt_sinopsis.Name = "txt_sinopsis";
            this.txt_sinopsis.Size = new System.Drawing.Size(362, 261);
            this.txt_sinopsis.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matemáticas",
            "Computación",
            "Inglés",
            "Literatura",
            "Ciencias",
            "Arte"});
            this.comboBox1.Location = new System.Drawing.Point(251, 465);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(433, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Registrar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1259, 780);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_sinopsis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_ejemplares);
            this.Controls.Add(this.txt_repisa);
            this.Controls.Add(this.txt_estante);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.txt_editorial);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrar_libro";
            this.Text = "Registrar_libro";
            this.Load += new System.EventHandler(this.Registrar_libro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_estante;
        private System.Windows.Forms.TextBox txt_repisa;
        private System.Windows.Forms.TextBox txt_ejemplares;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sinopsis;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}