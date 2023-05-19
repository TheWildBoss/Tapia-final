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
    public partial class Quizz_ritos_liturgicos : Form
    {
        int calificacion;
        public Quizz_ritos_liturgicos()
        {

            InitializeComponent();
        }

        private void btnverificar1_Click(object sender, EventArgs e)
        {
            btnverificar1.Enabled = false;
            if (Rbcorrecto1.Checked == true)
            {
                MessageBox.Show("muy bien llevas 25 puntos ");


                calificacion = calificacion + 25;
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
            if (Rbcorrecta2.Checked == true)
            {
                MessageBox.Show("muy bien llevas 25 puntos ");


                calificacion = calificacion + 25;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta2.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }
        }

        private void btnverificar3_Click(object sender, EventArgs e)
        {
            btnverificar3.Enabled = false;
            if (Rbcorrecta3.Checked == true)
            {
                MessageBox.Show("muy bien llevas 25 puntos ");


                calificacion = calificacion + 25;
                lbpuntuacion.Text = Convert.ToString(calificacion);




            }


            if (Rbcorrecta3.Checked == false)
            {

                MessageBox.Show("Amigo no era esa ");

            }

            if (btnverificar1.Enabled == false)
            {
                MessageBox.Show("Este test ha terminado tus datos se han guardado ");
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_de_quizzis();
            menu.Show();this.Hide();    
        }
    }
}
