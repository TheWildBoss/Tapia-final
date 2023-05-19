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
    public partial class menu_e_instrucciones : Form
    {
        public menu_e_instrucciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void historiadonbosco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form Historiadonbosco = new Don_bosco_y_su_vida();
            Historiadonbosco.Show(); this.Hide();
        }
    

    private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu_e_instrucciones_Load(object sender, EventArgs e)
        {






































        }

        private void Historiasalesiana_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Historiasalesiana = new Historia_salesiana();
            Historiasalesiana.Show(); this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Iatesa = new IATESA();
            Iatesa.Show(); this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Misa = new Ritos_liturgicos();
            Misa.Show(); this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Form menu = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form Historiadonbosco = new Don_bosco_y_su_vida();
            Historiadonbosco.Show(); this.Hide();
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form Historiasalesiana = new Historia_salesiana();
            Historiasalesiana.Show(); this.Hide();
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form Iatesa = new IATESA();
            Iatesa.Show(); this.Hide();
        }

        private void pictureBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form Misa = new Ritos_liturgicos();
            Misa.Show(); this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form quizzis = new Menu_de_quizzis();
            quizzis.Show(); this.Hide();
        }
    }
}
