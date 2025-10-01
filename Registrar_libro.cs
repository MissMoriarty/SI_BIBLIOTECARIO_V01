using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SI_BIBLIOTECARIO
{
    public partial class Registrar_libro : Form
    {
        Conexion c = new Conexion();
        Screen_04 screen_04 = new Screen_04();

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public Registrar_libro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btn_registrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("INSERT INTO libros (ISBN, titulo, autor, editorial, año, categoria, estante, repisa, sinopsis, nejemplares, estado, ejemplares_disponibles) VALUES ('" + txt_ISBN.Text + "', '" + txt_titulo.Text + "', '" + txt_autor.Text + "', '" + txt_editorial.Text + "', '" + txt_año.Text + "', '" + comboBox1.SelectedItem.ToString() + "', '" + txt_estante.Text + "', '" + txt_repisa.Text + "', '" + txt_sinopsis.Text + "', '" + txt_ejemplares.Text + "', 'disponible','" + txt_ejemplares.Text +"');");
            comando.ExecuteNonQuery();
            MessageBox.Show("Libro registrado exitosamente ");
            screen_04.limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            interfaz_Bibliotecario.Show();
        }

        private void Registrar_libro_Load(object sender, EventArgs e)
        {

        }
    }
}
