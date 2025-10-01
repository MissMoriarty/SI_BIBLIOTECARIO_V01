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
    public partial class Screen_04 : Form
    {
        Conexion c = new Conexion();
        public Screen_04()
        {
            InitializeComponent();
            
        }

        public void limpiar()
        {
            txt_usuario.Clear();
            txt_password.Clear();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("insert into bibliotecario (ncontrol, password) values ('" + txt_usuario.Text + "', '" + txt_password.Text + "');");
            comando.ExecuteNonQuery();
            MessageBox.Show("Bibliotecario registrado exitosamente");
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tb_bibliotecarios screen_05 = new tb_bibliotecarios();
            screen_05.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("delete from bibliotecario where ncontrol = '" + txt_usuario.Text + "';");
            comando.ExecuteNonQuery();
            MessageBox.Show("Bibliotecario eliminado exitosamente");
            limpiar();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen_03 screen_03 = new Screen_03();
            screen_03.Show();
        }

        private void Screen_04_Load(object sender, EventArgs e)
        {

        }
    }
}
