namespace SI_BIBLIOTECARIO
{
    partial class Actualizar_libro
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_sinopsis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_ejemplares = new System.Windows.Forms.TextBox();
            this.txt_repisa = new System.Windows.Forms.TextBox();
            this.txt_estante = new System.Windows.Forms.TextBox();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.txt_editorial = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.comboBox1.Location = new System.Drawing.Point(300, 485);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(433, 24);
            this.comboBox1.TabIndex = 52;
            // 
            // txt_sinopsis
            // 
            this.txt_sinopsis.Location = new System.Drawing.Point(857, 301);
            this.txt_sinopsis.Multiline = true;
            this.txt_sinopsis.Name = "txt_sinopsis";
            this.txt_sinopsis.Size = new System.Drawing.Size(362, 261);
            this.txt_sinopsis.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(857, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 49);
            this.button1.TabIndex = 50;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(857, 576);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(271, 49);
            this.btn_registrar.TabIndex = 49;
            this.btn_registrar.Text = "ACTUALIZAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_ejemplares
            // 
            this.txt_ejemplares.Location = new System.Drawing.Point(478, 674);
            this.txt_ejemplares.Name = "txt_ejemplares";
            this.txt_ejemplares.Size = new System.Drawing.Size(255, 22);
            this.txt_ejemplares.TabIndex = 48;
            // 
            // txt_repisa
            // 
            this.txt_repisa.Location = new System.Drawing.Point(255, 603);
            this.txt_repisa.Name = "txt_repisa";
            this.txt_repisa.Size = new System.Drawing.Size(478, 22);
            this.txt_repisa.TabIndex = 47;
            // 
            // txt_estante
            // 
            this.txt_estante.Location = new System.Drawing.Point(255, 547);
            this.txt_estante.Name = "txt_estante";
            this.txt_estante.Size = new System.Drawing.Size(478, 22);
            this.txt_estante.TabIndex = 46;
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(415, 426);
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(318, 22);
            this.txt_año.TabIndex = 45;
            // 
            // txt_editorial
            // 
            this.txt_editorial.Location = new System.Drawing.Point(289, 367);
            this.txt_editorial.Name = "txt_editorial";
            this.txt_editorial.Size = new System.Drawing.Size(444, 22);
            this.txt_editorial.TabIndex = 44;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(255, 301);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(478, 22);
            this.txt_autor.TabIndex = 43;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(255, 243);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(478, 22);
            this.txt_titulo.TabIndex = 42;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(255, 181);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(478, 22);
            this.txt_ISBN.TabIndex = 54;
            this.txt_ISBN.TextChanged += new System.EventHandler(this.txt_ISBN_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(852, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "SINÓPSIS:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 667);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(349, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "NÚMERO DE EJEMPLARES:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "RESPISA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "ESTANTE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "CATEGORÍA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "AÑO DE PUBLICACIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "EDITORIAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "AUTOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "TÍTULO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "ISBN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "ACTUALIZACIÓN DE LIBROS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(857, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 42);
            this.button2.TabIndex = 53;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Actualizar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1324, 760);
            this.Controls.Add(this.button2);
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
            this.Name = "Actualizar_libro";
            this.Text = "Actualizar_libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_sinopsis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_ejemplares;
        private System.Windows.Forms.TextBox txt_repisa;
        private System.Windows.Forms.TextBox txt_estante;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.TextBox txt_editorial;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}