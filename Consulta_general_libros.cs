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
    public partial class Consulta_general_libros : Form
    {
        Conexion c = new Conexion();
        private MySqlDataReader leer;
        DataTable dt = new DataTable();
        public Consulta_general_libros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            interfaz_Bibliotecario.Show();
        }

        private void Consulta_general_libros_Load(object sender, EventArgs e)
        {
            
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("select * from libros");
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            dt.Load(leer);
            dataGridView1.DataSource = dt;

        }
    }
}
