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
    public partial class Login_bibliotecario : Form
    {
        Conexion c = new Conexion();
        public Login_bibliotecario()
        {
            InitializeComponent();
        }

        private void Login_bibliotecario_Load(object sender, EventArgs e)
        {

        }

        Screen_04 screen_04 = new Screen_04();
            private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = "select * from bibliotecario where (ncontrol = @usuario and password = @password);";
            comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
            comando.Parameters.AddWithValue("@password", txt_password.Text);

            using (MySqlDataReader leer = comando.ExecuteReader())
            {
                if (leer.Read())
                {
                    this.Hide();
                    Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
                    interfaz_Bibliotecario.Show();
                    leer.Close();
                    
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS");
                    screen_04.limpiar();
                }
            }
        }


    

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
