using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caminando_con_don_bosco
{
    public partial class Ritos_liturgicos : Form
    {
        public Ritos_liturgicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form menu = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form menu  = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }
    }
}
