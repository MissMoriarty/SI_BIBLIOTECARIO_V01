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
    public partial class Screen_06 : Form
    {
        Conexion c = new Conexion();
        public Screen_06()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txt_usuario.Clear();
            txt_rol.Clear();
            txt_password.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen_03 screen_03 = new Screen_03();
            screen_03.Show();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("delete from usuario where ncontrol = '" + txt_usuario.Text + "';");
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario eliminado exitosamente");
            limpiar();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("insert into usuarios (ncontrol, rol, password) values ('" + txt_usuario.Text + "', '" + txt_rol.Text + "', '" + txt_password.Text + "');");
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario registrado exitosamente");
            limpiar();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_usuarios consulta_usuarios = new Consulta_usuarios();
            consulta_usuarios.Show();
        }

        private void Screen_06_Load(object sender, EventArgs e)
        {

        }
    }
}
