using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace SI_BIBLIOTECARIO
{
    public partial class Interfaz_usuario : Form
    {
        private Conexion c;
        private MySqlDataReader leer;
        DataTable dt = new DataTable();
        public Interfaz_usuario()
        {
            InitializeComponent();
            c = new Conexion();
        }

        private void títuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Interfaz_usuario_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros");
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();

            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void títuloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el título:", "Búsqueda por título", "", 30, 30);
            if (!string.IsNullOrEmpty(input))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE titulo LIKE @titulo";
                comando.Parameters.AddWithValue("@titulo", "%" + input + "%");
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                dt.Clear();
                dt.Load(leer);
                dataGridView1.DataSource = dt;
            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el autor:", "Búsqueda por autor", "", 30, 30);
            if (!string.IsNullOrEmpty(input))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE autor LIKE @titulo";
                comando.Parameters.AddWithValue("@titulo", "%" + input + "%");
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                dt.Clear();
                dt.Load(leer);
                dataGridView1.DataSource = dt;
            }
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese la editorial:", "Búsqueda por editorial", "", 10, 10);
            if (!string.IsNullOrEmpty(input))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE editorial LIKE @titulo";
                comando.Parameters.AddWithValue("@titulo", "%" + input + "%");
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                dt.Clear();
                dt.Load(leer);
                dataGridView1.DataSource = dt;
            }
        }

        private void matemáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {       MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE categoria LIKE 'Matemáticas'";
                comando.ExecuteNonQuery();
                leer = comando.ExecuteReader();
                dt.Clear();
                dt.Load(leer);
                dataGridView1.DataSource = dt;
            }

        private void computaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE titulo LIKE 'Computación'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void inglésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE categoria LIKE 'Inglés'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void literaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE categoria LIKE 'Literatura'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void cienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE categoria LIKE 'Ciencia'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void arteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE categoria LIKE 'Arte'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void disponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE estado LIKE 'Disponible'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void noDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            
            comando.CommandText = "SELECT ISBN, titulo, autor, editorial, categoria, estante, repisa, sinopsis, estado, ejemplares_disponibles FROM libros WHERE estado LIKE 'Reparación'";
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            dt.Clear();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el ISBN de su reservación:", "Reservar", "", 30, 30);
            if (!string.IsNullOrEmpty(input))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "INSERT INTO reservaciones (ncontrol, ISBN) VALUES ('" + Login_usuario.VariablesGlobales.Usuario + "' , '" + input + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Reservación realizada exitosamente");
            }
        }

        private void verReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String usuario = Login_usuario.VariablesGlobales.Usuario;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            MySqlDataReader leer = null;



            using (MySqlConnection conexion = c.getConexion())
            {

                using (MySqlCommand comando1 = new MySqlCommand("SELECT * FROM reservaciones WHERE ncontrol = @usuario;", conexion))
                {
                    comando1.Parameters.AddWithValue("@usuario", usuario);

                    ds.EnforceConstraints = false;

                    leer = comando1.ExecuteReader();

                    dt.Clear();
                    dt.Load(leer);

                    dataGridView1.DataSource = dt;


                }
            }
        }

        private void eliminarReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el ISBN de su reservación a eliminar:", "Eliminar reservación", "", 30, 30);
            if (!string.IsNullOrEmpty(input))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "DELETE FROM reservaciones WHERE ncontrol = '" + Login_usuario.VariablesGlobales.Usuario + "' AND ISBN = '" + input + "';";
                comando.ExecuteNonQuery();
                MessageBox.Show("Reservación eliminada exitosamente");
            }
        }

        private void añadiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el ISBN de su libro a añadir:", "Añadir libro a lista", "", 30, 30);
            if (!string.IsNullOrEmpty(input))
            {
                using (MySqlCommand comando = new MySqlCommand("SELECT * FROM libros WHERE ISBN = @ISBN", c.getConexion()))
                {
                    comando.Parameters.AddWithValue("@ISBN", input);
                    using (MySqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            string ISBN = leer["ISBN"].ToString();
                            string titulo = leer["titulo"].ToString();
                            string autor = leer["autor"].ToString();
                            leer.Close();

                            using (MySqlCommand comando1 = new MySqlCommand("INSERT INTO listas_lectura (ncontrol, ISBN, titulo, autor) VALUES (@ncontrol, @ISBN, @titulo, @autor)", c.getConexion()))
                            {
                                comando1.Parameters.AddWithValue("@ncontrol", Login_usuario.VariablesGlobales.Usuario);
                                comando1.Parameters.AddWithValue("@ISBN", ISBN);
                                comando1.Parameters.AddWithValue("@titulo", titulo);
                                comando1.Parameters.AddWithValue("@autor", autor);
                                comando1.ExecuteNonQuery();
                            }
                            MessageBox.Show("Libro añadido exitosamente");
                        }
                        else
                        {
                            leer.Close();
                            MessageBox.Show("EL LIBRO NO SE ENCUENTRA REGISTRADO");
                        }
                    }
                }
            }
            

        }

        private void verListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String usuario = Login_usuario.VariablesGlobales.Usuario;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            MySqlDataReader leer = null;
            using (MySqlConnection conexion = c.getConexion())
            {

                using (MySqlCommand comando1 = new MySqlCommand("SELECT * FROM listas_lectura WHERE ncontrol = @usuario;", conexion))
                {
                    comando1.Parameters.AddWithValue("@usuario", usuario);
                    MessageBox.Show(usuario);

                    ds.EnforceConstraints = false;

                    leer = comando1.ExecuteReader();

                    dt.Clear();
                    dt.Load(leer);

                    dataGridView1.DataSource = dt;

                }

            }

        }

        private void eliminarDeLaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el ISBN del libro a eliminar:", "Eliminar de la lista", "", 30, 30);
            if (!string.IsNullOrEmpty(input))
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = c.getConexion();
                comando.CommandText = "DELETE FROM listas_lectura WHERE ncontrol = '" + Login_usuario.VariablesGlobales.Usuario + "' AND ISBN = '" + input + "';";
                comando.ExecuteNonQuery();
                MessageBox.Show("Libro eliminado exitosamente de la lista");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screeen_01 screen_01 = new Screeen_01();
            screen_01.Show();
        }

        private void categoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
            }
     


