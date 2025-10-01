using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SI_BIBLIOTECARIO
{
    public partial class Screen_02 : Form
    {
        public Screen_02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (String.Compare(txt_usuario.Text, "24CS0341", StringComparison.OrdinalIgnoreCase) == 0)
            {
                if (txt_password.Text == "1234")
                {
                    Screen_03 screen_03 = new Screen_03();
                    screen_03.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screeen_01 screeen_01 = new Screeen_01();
            screeen_01.Show();
            this.Hide();
        }
    }
}
