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
    public partial class IATESA : Form
    {
        public IATESA()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form iatesa = new IATESA_2();
            iatesa.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form menu = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }

        private void IATESA_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {





































        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form iatesa2 = new IATESA_2();
            iatesa2.Show(); this.Hide();
        }
    }
}
