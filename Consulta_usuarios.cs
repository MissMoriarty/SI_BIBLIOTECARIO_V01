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
    public partial class Consulta_usuarios : Form
    {
        Conexion c = new Conexion();
        
        DataTable dt = new DataTable();
        public Consulta_usuarios()
        {
            InitializeComponent();
        }

        private void Consulta_usuarios_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlDataReader leer;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("select * from usuarios");
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            dataGridView1.DataSource = dt;
            leer.Close();

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen_06 screen_06 = new Screen_06();
            screen_06.Show();
        }
    }
}
