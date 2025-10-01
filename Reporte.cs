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
    public partial class Reporte : Form
    {
        private Conexion c;
        private MySqlDataReader leer;
        DataTable dt = new DataTable();
        public Reporte()
        {
            InitializeComponent();
            c = new Conexion();
            String instruccion_sql = "SELECT COUNT(*) FROM reporte WHERE accion  = 'Nuevo libro';";
            MySqlCommand comando1 = new MySqlCommand();
            comando1.Connection = c.getConexion();
            comando1.CommandText = (instruccion_sql);
            comando1.ExecuteNonQuery();
            object nuevo_ejemplares = comando1.ExecuteScalar();
            if (nuevo_ejemplares != null && nuevo_ejemplares != DBNull.Value)
            {
                int nuevo_ejemplaresINT = Convert.ToInt32(nuevo_ejemplares);
                lbl_nuevos.Text = "Nuevos ejemplares: " + nuevo_ejemplaresINT.ToString();
            }
            else
            {
                int nuevo_ejemplaresINT = 0;
                lbl_nuevos.Text = "Nuevos ejemplares: " + nuevo_ejemplaresINT.ToString();
            }
            

            String instruccion_sql2 = "SELECT COUNT(*) FROM reporte WHERE accion  = 'Prestamo';";
            MySqlCommand comando2 = new MySqlCommand();
            comando2.Connection = c.getConexion();
            comando2.CommandText = (instruccion_sql2);
            comando2.ExecuteNonQuery();
            object prestamos = comando2.ExecuteScalar();
            if (prestamos != null && prestamos != DBNull.Value)
            {
                int prestamosINT = Convert.ToInt32(prestamos);
                lbl_prestamos.Text = "Prestamos: " + prestamosINT.ToString();
            }
            else
            {
                int prestamosINT = 0;
                lbl_prestamos.Text = "Prestamos: " + prestamosINT.ToString();
            }

            c = new Conexion();
            String instruccion_sql3 = "SELECT COUNT(*) FROM reporte WHERE accion  = 'Devolución';";
            MySqlCommand comando3 = new MySqlCommand();
            comando3.Connection = c.getConexion();
            comando3.CommandText = (instruccion_sql3);
            comando3.ExecuteNonQuery();
            object  devoluciones = comando3.ExecuteScalar();
            if (devoluciones != null && devoluciones != DBNull.Value)
            {
                int devolucionesINT = Convert.ToInt32(devoluciones);
                lbl_devoluciones.Text = "Devoluciones: " + devolucionesINT.ToString();
            }
            else
            {
                int devolucionesINT = 0;
                lbl_devoluciones.Text = "Devoluciones: " + devolucionesINT.ToString();
            }

            String instruccion_sql4 = "SELECT COUNT(*) FROM reporte WHERE accion  = 'Reparación';";
            MySqlCommand comando4 = new MySqlCommand();
            comando4.Connection = c.getConexion();
            comando4.CommandText = (instruccion_sql4);
            comando4.ExecuteNonQuery();
            object reparaciones = comando4.ExecuteScalar();
            if (reparaciones != null && reparaciones != DBNull.Value)
            {
                int reparacionesINT = Convert.ToInt32(reparaciones);
                lbl_reparaciones.Text = "Reparaciones: " + reparacionesINT.ToString();
            }
            else
            {
                int reparacionesINT = 0;
                lbl_reparaciones.Text = "Reparaciones: " + reparacionesINT.ToString();
            }


            String instruccion_sql5 = "SELECT COUNT(*) FROM reporte WHERE accion  = 'Perdida';";
                MySqlCommand comando5 = new MySqlCommand();
                comando5.Connection = c.getConexion();
                comando5.CommandText = (instruccion_sql5);
                comando5.ExecuteNonQuery();
                object perdidas = comando5.ExecuteScalar();
                if (perdidas != null && perdidas != DBNull.Value)
                {
                    int perdidasINT = Convert.ToInt32(perdidas);
                    lbl_perdidas.Text = "Libros perdidos: " + perdidasINT.ToString();
            }
                else
                {
                    int perdidasINT = 0;
                    lbl_perdidas.Text = "Libros perdidos: " + perdidasINT.ToString();
            }
        }


        private void Reporte_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("select * from reporte");
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();

            dt.Load(leer);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            this.Hide();
            interfaz_Bibliotecario.Show();
        }

        
    }
}
