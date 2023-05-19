using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caminando_con_don_bosco
{
    public partial class Quizzis_vida_de_don_bosco : Form
        
        
    { 
        
        
        int calificacion;
        
        
        public Quizzis_vida_de_don_bosco()
        {
              
            
            InitializeComponent();
            groupBox1.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnverifique1_Click(object sender, EventArgs e)

        {
            
            btnverifique1.Enabled = false;  
            if (Rbcorrecto1.Checked == true)
            {
                MessageBox.Show("muy bien llevas 10 puntos ");
               
                
                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);
                
           


            }


            if (Rbcorrecto1.Checked == false)
            {

                MessageBox.Show("FALLASTE ");

            }

           









        }

        private void btnsiguienteincorrecta_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnverifique2_Click(object sender, EventArgs e)
           
        {

            btnverifique2.Enabled = false; 
            if (Rbcorrecto2.Checked == true)
            {
                MessageBox.Show("muy bien llevas 10 puntos ");
                
              
                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);



            }
            if (Rbcorrecto2.Checked == false)
            {

                MessageBox.Show("ESA NO ES LA RESPUESTA AMIGO");
                

            }

           
        }

        private void btnverifique3_Click(object sender, EventArgs e)
            
        {
            btnverifique3.Enabled = false;
            if (Rbcorrecta3.Checked == true)
            {
                
                MessageBox.Show("muy bien llevas 1O puntos mas ");
               
                
                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);






            }
            if (Rbcorrecta3.Checked == false)
            {

                MessageBox.Show("Haz fallado");
                

            }
        }

        private void btnverifique4_Click(object sender, EventArgs e)
        {
            btnverifique4.Enabled = false;
            if (Rbcorrecta4.Checked == true)
            {
                MessageBox.Show("muy bien llevas 10 puntos ");
                
                
                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);





            }
            if (Rbcorrecta4.Checked == false)
            {

                MessageBox.Show("Que mal haz fallado sigue adelante");
               

            }
        }

        private void btnverifique5_Click(object sender, EventArgs e)
        {
           

           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = true;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
        }

        private void flecha2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void flecha3_Click(object sender, EventArgs e)
        {
              
        }

        private void pictureincorrecta2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureincorrecta1_Click(object sender, EventArgs e)
        {

        }

        private void flecha4_Click(object sender, EventArgs e)
        {
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Quizzis_vida_de_don_bosco_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnverficar5_Click(object sender, EventArgs e)
        {
            btnverficar5.Enabled = false;
            if (Rbcorrecto5.Checked == true)
            {
                MessageBox.Show("muy bien llevas 10 puntos ");


                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);





            }
            if (Rbcorrecto5.Checked == false)
            {

                MessageBox.Show("Que mal haz fallado sigue adelante");


            }
        }

        private void btnverificar6_Click(object sender, EventArgs e)
        {
            btnverificar6.Enabled = false;
            if (radioButton13.Checked == true)
            {
                MessageBox.Show("muy bien llevas 10 puntos ");


                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);





            }
            if (radioButton13.Checked == false)
            {

                MessageBox.Show("Que mal haz fallado sigue adelante");


            }
        }

        private void btnverificar7_Click(object sender, EventArgs e)
        {
            btnverificar7.Enabled = false;
            if (Rbcorrecta7.Checked == true)
            {
                MessageBox.Show("muy bien llevas 10 puntos ");


                calificacion = calificacion + 10;
                lbcorrectas1.Text = Convert.ToString(calificacion);





            }
            if (Rbcorrecta7.Checked == false)
            {

                MessageBox.Show("Que mal haz fallado sigue adelante");


            }
            if(btnverificar7.Enabled==false)
            {
                MessageBox.Show("Este test ha terminado tus resultados se han guardado");
                btnsalir.Enabled = true;   
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form menu = new Menu_de_quizzis();
            menu.Show();this.Hide();
        }
    }
}

