using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using SI_BIBLIOTECARIO;

namespace SI_BIBLIOTECARIO
{
    public partial class Libro_reparación : Form
    {
        Conexion c = new Conexion();
        Screen_04 screen_04 = new Screen_04();
        int ejemplares_reparacion_int = 0;
        public Libro_reparación()
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
            comando.CommandText = ("select * from libros where ISBN = '" + txt_ISBN.Text + "'");
            comando.ExecuteNonQuery();
            MySqlDataReader leer = comando.ExecuteReader();
            
            if (leer.Read() == true)

            {

                String ISBN = leer["ISBN"].ToString();
                String Titulo = leer["titulo"].ToString();
                String Autor = leer["autor"].ToString();
                String Editorial = leer["editorial"].ToString();
                int Año = int.Parse(leer["año"].ToString());
                String Categoria = leer["categoria"].ToString();
                int Estante = int.Parse(leer["estante"].ToString());
                int Repisa = int.Parse(leer["repisa"].ToString());
                String Sinopsis = leer["sinopsis"].ToString();

                int disponibles = (int.Parse(leer["ejemplares_disponibles"].ToString())) - 1;
                leer.Close();
                String instruccion_sql3 = "SELECT COUNT(*) FROM reparaciones WHERE ISBN  = '" + txt_ISBN.Text + "';";
                MySqlCommand comando3 = new MySqlCommand();
                comando3.Connection = c.getConexion();
                comando3.CommandText = (instruccion_sql3);
                comando3.ExecuteNonQuery();
                object registros = comando3.ExecuteScalar();
                if (registros != null && registros != DBNull.Value)
                {
                    int cantidadRegistros = Convert.ToInt32(registros);
                    if (cantidadRegistros > 0)

                    {   //--------------------------------
                        MySqlCommand comando5 = new MySqlCommand();
                        comando5.Connection = c.getConexion();
                        comando5.CommandText = ("select * from reparaciones where ISBN = '" + txt_ISBN.Text + "'");
                        comando5.ExecuteNonQuery();
                        MySqlDataReader leer5 = comando5.ExecuteReader();
                        if (leer5.Read())
                        {
                            String ejemplares_reparacion = leer5["nejemplares"].ToString();
                            ejemplares_reparacion_int = int.Parse(ejemplares_reparacion);
                            ejemplares_reparacion_int++;
                            
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given ISBN.");
                        }
                        leer5.Close();

                        //--------------------------------

                        string instruccion_sql = "UPDATE libros SET estado = 'Reparación', ejemplares_disponibles = '0' WHERE ISBN = '" + txt_ISBN.Text + "';";
                        if (disponibles == 0)
                        {
                            string instruccion_sql4 = "UPDATE reparaciones SET nejemplares = '" + ejemplares_reparacion_int.ToString() + "' WHERE ISBN = '" + txt_ISBN.Text + "';";
                            MySqlCommand comando1 = new MySqlCommand();
                            comando1.Connection = c.getConexion();
                            comando1.CommandText = instruccion_sql;
                            comando1.ExecuteNonQuery();

                            MySqlCommand comando4 = new MySqlCommand();
                            comando4.Connection = c.getConexion();
                            comando4.CommandText = instruccion_sql4;
                            comando4.ExecuteNonQuery();
                            MessageBox.Show("EL LIBRO SE HA MARCADO COMO EN REPARACIÓN");

                        }
                        if (disponibles > 0)
                        {

                            String instruccion_sql2 = "UPDATE libros SET ejemplares_disponibles = '" + disponibles.ToString() + "' WHERE ISBN = '" + txt_ISBN.Text + "';";
                            MySqlCommand comando2 = new MySqlCommand();
                            comando2.Connection = c.getConexion();
                            comando2.CommandText = instruccion_sql2;
                            comando2.ExecuteNonQuery();
                            string instruccion_sql4 = "UPDATE reparaciones SET nejemplares = '" + ejemplares_reparacion_int.ToString() + "' WHERE ISBN = '" + txt_ISBN.Text + "';";
                            MySqlCommand comando4 = new MySqlCommand();
                            comando4.Connection = c.getConexion();
                            comando4.CommandText = instruccion_sql4;
                            comando4.ExecuteNonQuery();
                            MessageBox.Show("EL LIBRO SE HA MARCADO COMO EN REPARACIÓN");
                            
                        }
                    }else
                    {
                        String instruccion_sql6 = "INSERT INTO reparaciones (ISBN, autor, editorial, año, categoria, estante, repisa, sinopsis, nejemplares, titulo) VALUES ('" + ISBN + "','" + Autor + "','" + Editorial + "','" + Año + "','" + Categoria+ "','"  + Estante +  "','" + Repisa + "','" + Sinopsis + "','1','" + Titulo + "' ); ";
                        
                        MySqlCommand comando6 = new MySqlCommand();
                        comando6.Connection = c.getConexion();
                        comando6.CommandText = (instruccion_sql6);
                        comando6.ExecuteNonQuery();
                        String instruccion_sql2 = "UPDATE libros SET ejemplares_disponibles = " + disponibles + " WHERE ISBN = '" + txt_ISBN.Text + "';";
                        MySqlCommand comando2 = new MySqlCommand();
                        comando2.Connection = c.getConexion();
                        comando2.CommandText = instruccion_sql2;
                        comando2.ExecuteNonQuery();
                        MessageBox.Show("EL LIBRO SE HA MARCADO COMO EN REPARACIÓN");
                    }
                }
            }
            else
            {
                leer.Close();
                MessageBox.Show("EL LIBRO NO SE ENCUENTRA REGISTRADO");
                screen_04.limpiar();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            this.Hide();
            interfaz_Bibliotecario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("select * from libros where ISBN = '" + txt_ISBN.Text + "'");
            comando.ExecuteNonQuery();
            MySqlDataReader leer = comando.ExecuteReader();


            if (leer.Read() == true)

            {
                String ISBN = leer["ISBN"].ToString();
                int disponibles = (int.Parse(leer["ejemplares_disponibles"].ToString()));
                int ejemplares_totales = (int.Parse(leer["nejemplares"].ToString()));
                leer.Close();
                MySqlCommand comando1 = new MySqlCommand();
                comando1.Connection = c.getConexion();
                comando1.CommandText = ("select * from reparaciones where ISBN = '" + txt_ISBN.Text + "'");
                comando1.ExecuteNonQuery();
                MySqlDataReader leer1 = comando1.ExecuteReader();

                if (leer1.Read() == true)

                {
                    String ejemplares_reparacion = leer1["nejemplares"].ToString();
                    int n_ejemplares_reparacion = int.Parse(ejemplares_reparacion);
                    n_ejemplares_reparacion = n_ejemplares_reparacion - 1;
                    leer1.Close();
                    //----------------
                    if (n_ejemplares_reparacion == 0)
                    {
                        string instruccion_sql = "DELETE FROM reparaciones WHERE ISBN = '" + txt_ISBN.Text + "';";
                        MySqlCommand comando2 = new MySqlCommand();
                        comando2.Connection = c.getConexion();
                        comando2.CommandText = instruccion_sql;
                        comando2.ExecuteNonQuery();
                        string instruccion_sql2 = "UPDATE libros SET ejemplares_disponibles = '" + ejemplares_totales +"', estado = 'Disponible' WHERE ISBN = '" + txt_ISBN.Text + "';";
                        MySqlCommand comando3 = new MySqlCommand();
                        comando3.Connection = c.getConexion();
                        comando3.CommandText = instruccion_sql2;
                        comando3.ExecuteNonQuery();
                        MessageBox.Show("EL LIBRO SE HA DEVUELTO EXITOSAMENTE");
                    }
                    else
                    {
                        string instruccion_sql4 = "UPDATE reparaciones SET nejemplares = '" + n_ejemplares_reparacion + "' WHERE ISBN = '" + txt_ISBN.Text + "'; ";
                        
                        MySqlCommand comando4 = new MySqlCommand();
                        comando4.Connection = c.getConexion();
                        comando4.CommandText = instruccion_sql4;
                        comando4.ExecuteNonQuery();
                        int nuevos_disponibles = disponibles + 1;
                        string instruccion_sql2 = "UPDATE libros SET ejemplares_disponibles = '" + nuevos_disponibles + "', estado = 'Disponible' WHERE ISBN = '" + txt_ISBN.Text + "';";
                        MySqlCommand comando3 = new MySqlCommand();
                        comando3.Connection = c.getConexion();
                        comando3.CommandText = instruccion_sql2;
                        comando3.ExecuteNonQuery();
                        MessageBox.Show("EL LIBRO SE HA DEVUELTO EXITOSAMENTE");
                    }
                    //----------------

                }
                else
                {
                    leer1.Close();
                    MessageBox.Show("EL LIBRO NO SE ENCUENTRA EN REPARACIÓN");
                    screen_04.limpiar();

                }
            }
            else
            {
                leer.Close();
                MessageBox.Show("EL LIBRO NO SE ENCUENTRA REGISTRADO");
                screen_04.limpiar();

            }
            
        }

        private void Libro_reparación_Load(object sender, EventArgs e)
        {

        }
    }
}
