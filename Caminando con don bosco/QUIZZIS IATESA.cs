using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Caminando_con_don_bosco
{
    public partial class QUIZZIS_IATESA : Form
    {
        int calificacion;
        public QUIZZIS_IATESA()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnverificar1_Click(object sender, EventArgs e)
        {
            btnverificar1.Enabled = false;
            if (Rbcorrecta1.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbcorrecto1.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta1.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }

        }

        private void btnverificar2_Click(object sender, EventArgs e)
        {
            btnverificar2.Enabled = false;
            if (Rbcorrecto2.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 10;
                lbcorrecto1.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecto2.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }

        }

        private void btnverificar3_Click(object sender, EventArgs e)
        {
            btnverificar3.Enabled = false;
            if (Rbcorrecto3.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 10;
                lbcorrecto1.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecto3.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            
            groupBox4.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
        }

        private void btnverificar4_Click(object sender, EventArgs e)
        {
            btnverificar4.Enabled = false;
            if (Rbcorrecta4.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbcorrecto1.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta4.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }
        }

        private void btnverificar5_Click(object sender, EventArgs e)
        {
            btnverificar5.Enabled = false;
            if (Rbcorrecto5.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbcorrecto1.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecto5.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }
        }

        private void btnverificar6_Click(object sender, EventArgs e)
        {
            btnverificar6.Enabled = false;
            if (Rbcorrecta6.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 10;
                lbcorrecto1.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta6.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }

            if(btnverificar6.Enabled==false )
            {
                MessageBox.Show("Este test ha terminado puedes abondonar tu puntaje se ha guardado");
                btnsalir.Visible = true;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_de_quizzis ();
            menu.Show(); this.Hide();
        }
    }
}
