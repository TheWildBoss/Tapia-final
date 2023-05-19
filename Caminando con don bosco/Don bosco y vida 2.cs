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
    public partial class Don_bosco_y_vida_2 : Form
    {
        public Don_bosco_y_vida_2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form donbosco1 = new Don_bosco_y_su_vida (); 
            donbosco1.Show(); this.Hide();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form menu = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Form donbosco3 = new Don_bosco_3();
            donbosco3.Show(); this.Hide();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
