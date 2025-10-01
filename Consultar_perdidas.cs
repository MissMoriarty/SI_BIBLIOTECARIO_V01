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
    public partial class Consultar_perdidas : Form
    {
        private Conexion c;
        private MySqlDataReader leer;
        DataTable dt = new DataTable();
        public Consultar_perdidas()
        {
            InitializeComponent();
            c = new Conexion();
        }

        private void Consultar_perdidas_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("select * from perdidas");
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();

            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            interfaz_Bibliotecario.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
