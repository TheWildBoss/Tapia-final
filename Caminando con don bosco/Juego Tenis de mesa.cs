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
    public partial class Juego_Tenis : Form
    {
        public Juego_Tenis()
        {
            InitializeComponent();
        }

        int V = 5; //velocidad//
        int CONT = 0;//medir el puntaje//
        int PUNT = 0;//contador//

        bool W, L;

        private void Juego_Tenis_Load(object sender, EventArgs e)
        {


            this.Text = "Puntos: 0";
            Random aleatorio = new Random();
            Pic_Pelota.Location = new Point(0, aleatorio.Next(this.Height));
            W = true;
            L = true;
            TM_Pelota.Enabled = true;
            PUNT = 0;



        }

        private void Juego_Tenis_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void Juego_Tenis_MouseMove(object sender, MouseEventArgs e)
        {
            Pic_User.Top = e.Y;
        }

        private void TM_Pelota_Tick(object sender, EventArgs e)
        {
            if (Pic_Pelota.Left > Pic_User.Left) //pierde
            {
                TM_Pelota.Enabled = false;
                MessageBox.Show("Puntaje: " + PUNT.ToString()+ " Veces!");
                PUNT = 0;
                V = 0;
                CONT = 0;
            }

            #region

            if (L) 
            {
                Pic_Pelota.Left += V; //Ir a la derecha
            }
            else
            {

                Pic_Pelota.Left -= V; //Ir a la izquierda

            }
            if(W)
            {

                Pic_Pelota.Left += V; //Ir a Abajo

            }
            else
            {

                Pic_Pelota.Left -= V; //Ir a Arriva

            }
            if(Pic_Pelota.Top >= this.Height - 50)
            {

                W = false; //por si se pega a al pared de abajo

            }
            if (Pic_Pelota.Top <= 0)
            {

                W = true; //por si se pega a al pared de arriba

            }
            if (Pic_Pelota.Left <= 0)
            {

                L = true;

            }
            if (Pic_Pelota.Left >= this.Width -10)
            {

                L = false;

            }
            #endregion

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
