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
    public partial class Quizz_salesianidad : Form

    {
        int calificacion;
        public Quizz_salesianidad()
        {

            InitializeComponent();
        }

        private void btnverificar1_Click(object sender, EventArgs e)
        {
            btnverificar1.Enabled = false;
            if (Rbcorrecto1.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecto1.Checked == false)
            {

                MessageBox.Show("Sorry fallaste");

            }
        }

        private void btnverificar2_Click(object sender, EventArgs e)
        {
            btnverificar2.Enabled = false;
            if (Rbcorrecto2.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbpuntuacion.Text = Convert.ToString(calificacion);




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


                calificacion = calificacion + 15;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecto3.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnverificar4_Click(object sender, EventArgs e)
        {
            btnverificar4.Enabled = false;
            if (Rbcorrecta5.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta5.Checked == false)
            {

                MessageBox.Show("Amigo esa no era  ");

            }
        }

        private void btnverificar5_Click(object sender, EventArgs e)
        {
            btnverificar5.Enabled = false;
            if (Rbcorrecta6.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta6.Checked == false)
            {

                MessageBox.Show("Amigo esa no era  ");

            }
        }

        private void btnverificar6_Click(object sender, EventArgs e)
        {
            btnverificar6.Enabled = false;

            if (Rbcorrecta7.Checked == true)
            {
                MessageBox.Show("muy bien llevas 15 puntos ");


                calificacion = calificacion + 15;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta7.Checked == false)
            {

                MessageBox.Show("Amigo esa no era  ");

            }

            if(btnverificar6.Enabled==false)
            {
                MessageBox.Show("Este test ha terminado tus resultados se han guardado");
                btnsalir.Visible = true;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form juegos = new Menu_de_quizzis();
            juegos.Show(); this.Hide();
        }

        private void Quizz_salesianidad_Load(object sender, EventArgs e)
        {

        }
    }
}
