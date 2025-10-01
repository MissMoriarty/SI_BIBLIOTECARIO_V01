using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI_BIBLIOTECARIO
{
    public partial class Interfaz_bibliotecario : Form
    {
        public Interfaz_bibliotecario()
        {
            InitializeComponent();
            Conexion c = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar_libro registrar_libro = new Registrar_libro();
            registrar_libro.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screeen_01 screen1 = new Screeen_01();
            screen1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar_préstamo registrar_préstamo = new Registrar_préstamo();
            this.Hide();
            registrar_préstamo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarDevolución registrarDevolución = new RegistrarDevolución();
            registrarDevolución.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actualizar_libro actualizar_Libro = new Actualizar_libro();
            actualizar_Libro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar_prestamos consultar_Prestamos = new Consultar_prestamos();
            consultar_Prestamos.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Consulta_general_libros consulta_General_Libros = new Consulta_general_libros();
            this.Hide();
            consulta_General_Libros.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Libro_perdido libro_perdido = new Libro_perdido();
            libro_perdido.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Libro_reparación libro_Reparacion = new Libro_reparación();
            libro_Reparacion.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar_perdidas consultar_Perdidas = new Consultar_perdidas();
            consultar_Perdidas.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Consultar_reparaciones consultar_Reparaciones = new Consultar_reparaciones();
            this.Hide();
            consultar_Reparaciones.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte reporte = new Reporte();
            reporte.Show();
        }
    }
}
