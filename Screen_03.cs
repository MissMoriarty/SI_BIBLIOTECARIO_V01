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
    public partial class Screen_03 : Form
    {
        public Screen_03()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void Screen_03_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen_04 screen_04 = new Screen_04();
            screen_04.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screen_06 screen_06 = new Screen_06();
            screen_06.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screeen_01 screen_01 = new Screeen_01();
            screen_01.Show();
        }
    }
}
