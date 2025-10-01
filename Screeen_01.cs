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
    public partial class Screeen_01 : Form
    {
        public Screeen_01()
        {
            InitializeComponent();
        }

        private void Screeen_01_Load(object sender, EventArgs e)
        {

        }

        private void btn_administrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen_02 screen_02 = new Screen_02();
            screen_02.Show();
        }

        private void btn_bibliotecario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_bibliotecario login_bibliotecario = new Login_bibliotecario();
            login_bibliotecario.Show();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Login_usuario login_usuario = new Login_usuario();
            this.Hide();
            login_usuario.Show();
        }
    }
}
