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
    public partial class Actualizar_libro : Form
    {
        Conexion c = new Conexion();
        Screen_04 screeen_04 = new Screen_04();
        public Actualizar_libro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("update libros set titulo = '" + txt_titulo.Text + "', autor = '" + txt_autor.Text + "', editorial = '" + txt_año.Text + "', categoria = '" + comboBox1.Text + "', estante = '" + txt_estante.Text + "', repisa = '" + txt_repisa.Text + "', sinopsis = '" + txt_sinopsis.Text + "', nejemplares = '" + txt_ejemplares.Text + "' where ISBN = '" + txt_ISBN.Text + "';");
            comando.ExecuteNonQuery();
            MessageBox.Show("LIBRO ACTUALIZADO");
            screeen_04.limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            interfaz_Bibliotecario.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlCommand comando1 = new MySqlCommand())
            {
                comando1.Connection = c.getConexion();
                comando1.CommandText = "SELECT * FROM libros WHERE ISBN = @ISBN";
                comando1.Parameters.AddWithValue("@ISBN", txt_ISBN.Text);

                using (MySqlDataReader leer1 = comando1.ExecuteReader())
                {
                    if (leer1.Read())
                    {
                        txt_titulo.Text = leer1["titulo"].ToString();
                        txt_autor.Text = leer1["autor"].ToString();
                        txt_editorial.Text = leer1["editorial"].ToString();
                        txt_año.Text = leer1["año"].ToString();
                        comboBox1.Text = leer1["categoria"].ToString();
                        txt_estante.Text = leer1["estante"].ToString();
                        txt_repisa.Text = leer1["repisa"].ToString();
                        txt_sinopsis.Text = leer1["sinopsis"].ToString();
                        txt_ejemplares.Text = leer1["nejemplares"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("EL LIBRO NO SE ENCUENTRA REGISTRADO");
                        screeen_04.limpiar();
                    }
                }
            }
        }

        private void txt_ISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
