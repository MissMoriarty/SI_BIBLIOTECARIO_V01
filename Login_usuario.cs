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
    public partial class Login_usuario : Form
    {
        private Conexion c = new Conexion();
        Screen_04 screen_04 = new Screen_04();
        public Login_usuario()
        {
            InitializeComponent();
        }
        public static class VariablesGlobales
        {
            public static string Usuario;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "select * from usuarios where (ncontrol = @usuario and password = @password);";
            comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
            comando.Parameters.AddWithValue("@password", txt_password.Text);

            using (MySqlDataReader leer = comando.ExecuteReader())
            {
                if (leer.Read())
                {
                    this.Hide();
                    Interfaz_usuario interfaz_Usuario = new Interfaz_usuario();
                    interfaz_Usuario.Show();
                    leer.Close();
                    Login_usuario.VariablesGlobales.Usuario = txt_usuario.Text; // Guardar el usuario en la variable global
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS");
                    screen_04.limpiar();
                }
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screeen_01 screeen_01 = new Screeen_01();
            this.Hide();
            screeen_01.Show();
        }
    }
}
