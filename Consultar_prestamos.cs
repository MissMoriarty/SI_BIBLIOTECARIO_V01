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
    public partial class Consultar_prestamos : Form
    {
        private Conexion c;
        private MySqlDataReader leer;
        DataTable dt = new DataTable();
    
        public Consultar_prestamos()
        {
            InitializeComponent();
            c = new Conexion();
        }

        private void Consultar_prestamos_Load(object sender, EventArgs e)
        {
            
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("select * from prestamos");
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
    }
}
