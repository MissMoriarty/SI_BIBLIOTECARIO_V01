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
    public partial class RegistrarDevolución : Form
    {
        public int N_devoluciones = 0;
        Screen_04 Screen_04 = new Screen_04();
        Conexion c = new Conexion();
        public RegistrarDevolución()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();

            DateTime fecha_devolucion = DateTime.Now.Date;
            DateTime hora_devolucion = DateTime.Now;

            String instruccion_sql = "UPDATE prestamos SET estado_devolucion = 'Entregado', fecha_devolucion = '" + fecha_devolucion.ToString("yyyy/MM/dd") + "',hora_devolucion = '" + hora_devolucion.ToShortTimeString() + "' WHERE ISBN = '" + txt_ISBN.Text + "' AND ncontrol = '" + txt_ncontrol.Text + "';";
            MessageBox.Show(instruccion_sql);
            comando.CommandText = instruccion_sql;
            comando.ExecuteNonQuery();
            MySqlCommand comando2 = new MySqlCommand();
            comando2.Connection = c.getConexion();
            comando2.CommandText = ("SELECT fecha_prestamo FROM prestamos where ISBN = '" + txt_ISBN.Text + "';");
            Object resultado = comando2.ExecuteScalar();
            DateTime retardo = Convert.ToDateTime(resultado);
            TimeSpan diferencia = fecha_devolucion - retardo;
            int n = diferencia.Days;
            if (n <= 0) { 
                double multa = n * 50;
                String instruccion_sql3 = "update prestamos set multa = multa +" +  multa + " where ISBN = '" + txt_ISBN.Text + "';";
                comando.CommandText = instruccion_sql3;
                comando.ExecuteNonQuery();
                MessageBox.Show("El libro fue devuelto con " + n + " días de retraso, se le ha cobrado una multa de $" + multa);

            }
            N_devoluciones++;
            
            MessageBox.Show("Devolución registrada exitosamente ");
            Screen_04.limpiar();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            interfaz_Bibliotecario.Show();
        }

        private void RegistrarDevolución_Load(object sender, EventArgs e)
        {

        }
    }
}
