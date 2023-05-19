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
    public partial class Don_bosco_y_su_vida : Form
    {
        public Don_bosco_y_su_vida()
        {
            InitializeComponent();
        }

        private void Don_bosco_y_su_vida_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form Donbosco = new Don_bosco_y_vida_2();
            Donbosco.Show(); this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             Form menu = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {

        }
    }
}
