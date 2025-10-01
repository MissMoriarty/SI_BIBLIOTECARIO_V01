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
    public partial class Libro_perdido : Form
    {
        public Libro_perdido()
        
        {
            InitializeComponent();
            
        }
        Conexion c = new Conexion();
        int ejemplares_perdidos_int = 0;
        Screen_04 screen_04 = new Screen_04();
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
                String Sinopsis = leer["sinopsis"].ToString();

                int disponibles = (int.Parse(leer["ejemplares_disponibles"].ToString())) - 1;
                leer.Close();
                String instruccion_sql3 = "SELECT COUNT(*) FROM perdidas WHERE ISBN  = '" + txt_ISBN.Text + "';";
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
                        comando5.CommandText = ("select * from perdidas where ISBN = '" + txt_ISBN.Text + "'");
                        comando5.ExecuteNonQuery();
                        MySqlDataReader leer5 = comando5.ExecuteReader();
                        if (leer5.Read())
                        {
                            String ejemplares_perdidos = leer5["nejemplares"].ToString();
                            ejemplares_perdidos_int = int.Parse(ejemplares_perdidos);
                            ejemplares_perdidos_int++;

                        }
                        else
                        {
                            MessageBox.Show("No data found for the given ISBN.");
                        }
                        leer5.Close();

                        //--------------------------------

                        string instruccion_sql = "DELETE FROM libros WHERE ISBN = '" + txt_ISBN.Text + "';";
                        if (disponibles == 0)
                        {
                            string instruccion_sql4 = "UPDATE perdidas SET nejemplares = '" + ejemplares_perdidos_int.ToString() + "' WHERE ISBN = '" + txt_ISBN.Text + "';";
                            MySqlCommand comando1 = new MySqlCommand();
                            comando1.Connection = c.getConexion();
                            comando1.CommandText = instruccion_sql;
                            comando1.ExecuteNonQuery();
                            MySqlCommand comando4 = new MySqlCommand();
                            comando4.Connection = c.getConexion();
                            comando4.CommandText = instruccion_sql4;
                            comando4.ExecuteNonQuery();
                            MessageBox.Show("EL LIBRO SE HA MARCADO COMO PERDIDO");

                        }
                        if (disponibles > 0)
                        {

                            String instruccion_sql2 = "UPDATE libros SET ejemplares_disponibles = '" + disponibles.ToString() + "' WHERE ISBN = '" + txt_ISBN.Text + "';";
                            MySqlCommand comando2 = new MySqlCommand();
                            comando2.Connection = c.getConexion();
                            comando2.CommandText = instruccion_sql2;
                            comando2.ExecuteNonQuery();
                            string instruccion_sql4 = "UPDATE perdidas SET nejemplares = '" + ejemplares_perdidos_int.ToString() + "' WHERE ISBN = '" + txt_ISBN.Text + "';";
                            MySqlCommand comando4 = new MySqlCommand();
                            comando4.Connection = c.getConexion();
                            comando4.CommandText = instruccion_sql4;
                            comando4.ExecuteNonQuery();
                            MessageBox.Show("EL LIBRO SE HA MARCADO COMO PERDIDO");

                        }
                    }
                    else
                    {
                        String instruccion_sql6 = "INSERT INTO perdidas (ISBN, titulo, autor, editorial, año, categoria, sinopsis, nejemplares) VALUES ('" + ISBN + "','" + Titulo + "','"+ Autor + "','" + Editorial + "','" + Año + "','" + Categoria + "','" + Sinopsis + "','1'); ";
                        
                        MySqlCommand comando6 = new MySqlCommand();
                        comando6.Connection = c.getConexion();
                        comando6.CommandText = (instruccion_sql6);
                        comando6.ExecuteNonQuery();
                        String instruccion_sql2 = "UPDATE libros SET ejemplares_disponibles = " + disponibles + " WHERE ISBN = '" + txt_ISBN.Text + "';";
                        MySqlCommand comando2 = new MySqlCommand();
                        comando2.Connection = c.getConexion();
                        comando2.CommandText = instruccion_sql2;
                        comando2.ExecuteNonQuery();
                        MessageBox.Show("EL LIBRO SE HA MARCADO COMO PERDIDO");
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
            this.Show();
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            interfaz_Bibliotecario.Show();
        }
    }
}
