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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SI_BIBLIOTECARIO
{
    public partial class Registrar_préstamo : Form
    {
        public int N_prestamos = 0;
        Conexion c = new Conexion();
        Screen_04 screen_04 = new Screen_04();
        public Registrar_préstamo()
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

            DateTime fecha_prestamo = DateTime.Now.Date;
            DateTime hora_prestamo = DateTime.Now;
            
            String instruccion_sql = "insert into prestamos (ISBN, ncontrol, fecha_prestamo, fecha_limite, estado_devolucion, multa, hora_prestamo) values ('" + txt_ISBN.Text + "', '" + txt_ncontrol.Text + "', '" + fecha_prestamo.ToString("yyyy/MM/dd") + "', '" + fecha_prestamo.AddDays(5).ToString("yyyy/MM/dd") + "', 'Pendiente'," + 0 + ",'" + hora_prestamo.ToShortTimeString() + "');";
            comando.CommandText = instruccion_sql;
            comando.ExecuteNonQuery();
            MessageBox.Show("Préstamo registrado exitosamente ");
            N_prestamos++;
            screen_04.limpiar();
            actualizar_ejemplares();


        }
private void actualizar_ejemplares()
        {
            String isbn = txt_ISBN.Text;
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = c.getConexion();
            comando.CommandText = ("update libros set ejemplares_disponibles = ejemplares_disponibles - 1 where ISBN = '" + isbn + "';");
        }


        
        

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Interfaz_bibliotecario interfaz_Bibliotecario = new Interfaz_bibliotecario();
            this.Hide();
            interfaz_Bibliotecario.Show();
        }

        private void Registrar_préstamo_Load(object sender, EventArgs e)
        {

        }
    }
}
