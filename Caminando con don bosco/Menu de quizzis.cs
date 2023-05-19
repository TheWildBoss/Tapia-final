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
    public partial class Menu_de_quizzis : Form
    {
        public Menu_de_quizzis()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form quizz = new Quizzis_vida_de_don_bosco();
            quizz.Show(); this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form menu = new menu_e_instrucciones();
            menu.Show(); this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form iatesa = new QUIZZIS_IATESA();
            iatesa.Show(); this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form salesianos = new Quizz_salesianidad();
            salesianos.Show(); this.Hide(); 
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form iglesia = new Quizz_ritos_liturgicos();
            iglesia.Show(); this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
