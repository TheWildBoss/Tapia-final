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
    public partial class Nivel1 : Form
    {
        Random letras = new Random();
        int segundos;
        int minutos;
        public Nivel1()
        {
            InitializeComponent();
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            SigNivel.Visible = false;
            Tabla.RowCount = 26;
            Tabla.ColumnCount = 29;
            timer1.Interval = 1000;
            timer1.Start();


            Tabla.ColumnHeadersVisible = true;

            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    Tabla[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    inicializarPalabras();
                }
            }


        }

        private void Color_click(object sender, EventArgs e)
        {
            Tabla.CurrentCell.Style.BackColor = Color.YellowGreen;
            validacion();
            JuegoTerminado();
        }
        private void RegresarColor_Doclick(object sender, EventArgs e)
        {
            Tabla.CurrentCell.Style.BackColor = Color.White;
        }

        public void inicializarPalabras()
        {

            Tabla[0, 1].Value = 'D';
            Tabla[0, 2].Value = 'O';
            Tabla[0, 3].Value = 'N';
            Tabla[0, 4].Value = 'B';
            Tabla[0, 5].Value = 'O';
            Tabla[0, 6].Value = 'S';
            Tabla[0, 7].Value = 'C';
            Tabla[0, 8].Value = 'O';



            Tabla[2, 1].Value = 'M';
            Tabla[3, 2].Value = 'A';
            Tabla[4, 3].Value = 'R';
            Tabla[5, 4].Value = 'I';
            Tabla[6, 5].Value = 'A';


            Tabla[4, 5].Value = 'I';
            Tabla[4, 6].Value = 'G';
            Tabla[4, 7].Value = 'L';
            Tabla[4, 8].Value = 'E';
            Tabla[4, 9].Value = 'S';
            Tabla[4, 10].Value = 'I';
            Tabla[4, 11].Value = 'A';

            Tabla[10, 9].Value = 'S';
            Tabla[11, 9].Value = 'A';
            Tabla[12, 9].Value = 'L';
            Tabla[13, 9].Value = 'E';
            Tabla[14, 9].Value = 'S';
            Tabla[15, 9].Value = 'I';
            Tabla[16, 9].Value = 'A';
            Tabla[17, 9].Value = 'N';
            Tabla[18, 9].Value = 'O';
            Tabla[19, 9].Value = 'S';



            Tabla[15, 2].Value = 'M';
            Tabla[14, 2].Value = 'A';
            Tabla[13, 2].Value = 'M';
            Tabla[12, 2].Value = 'A';
            Tabla[11, 2].Value = 'M';
            Tabla[10, 2].Value = 'A';
            Tabla[9, 2].Value = 'R';
            Tabla[8, 2].Value = 'G';
            Tabla[7, 2].Value = 'A';
            Tabla[6, 2].Value = 'R';
            Tabla[5, 2].Value = 'I';
            Tabla[4, 2].Value = 'T';
            Tabla[3, 2].Value = 'A';



            Tabla[16, 15].Value = 'J';
            Tabla[15, 14].Value = 'E';
            Tabla[14, 13].Value = 'S';
            Tabla[13, 12].Value = 'U';
            Tabla[12, 11].Value = 'S';

        }




        public void validacion()
        {
            // Verifico en la tabla si las palabra esta iluminada si es asi entonces hago visible la palomita 
            if (Tabla[10, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[11, 9].Style.BackColor == Color.YellowGreen &&
                Tabla[12, 9].Style.BackColor == Color.YellowGreen &&
                    Tabla[13, 9].Style.BackColor == Color.YellowGreen &&
                    Tabla[14, 9].Style.BackColor == Color.YellowGreen &&
                    Tabla[15, 9].Style.BackColor == Color.YellowGreen &&
                    Tabla[16, 9].Style.BackColor == Color.YellowGreen &&
                    Tabla[17, 9].Style.BackColor == Color.YellowGreen &&
                    Tabla[18, 9].Style.BackColor == Color.YellowGreen)


            {

                pic1.Visible = true;
            }
            if (Tabla[16, 15].Style.BackColor == Color.YellowGreen && Tabla[15, 14].Style.BackColor == Color.YellowGreen &&
             Tabla[14, 13].Style.BackColor == Color.YellowGreen &&
             Tabla[13, 12].Style.BackColor == Color.YellowGreen &&
             Tabla[12, 11].Style.BackColor == Color.YellowGreen)

            {

                pic4.Visible = true;
            }
            if (Tabla[15, 2].Style.BackColor == Color.YellowGreen &&
            Tabla[14, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[13, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[12, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[11, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[10, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[9, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[8, 2].Style.BackColor == Color.YellowGreen &&
             Tabla[7, 2].Style.BackColor == Color.YellowGreen)

            {

                pic5.Visible = true;
            }
            if (Tabla[4, 5].Style.BackColor == Color.YellowGreen &&
             Tabla[4, 6].Style.BackColor == Color.YellowGreen &&
             Tabla[4, 7].Style.BackColor == Color.YellowGreen &&
             Tabla[4, 8].Style.BackColor == Color.YellowGreen &&
             Tabla[4, 9].Style.BackColor == Color.YellowGreen &&
             Tabla[4, 10].Style.BackColor == Color.YellowGreen &&
             Tabla[4, 11].Style.BackColor == Color.YellowGreen
          )

            {

                pic6.Visible = true;
            }

            if (Tabla[2, 1].Style.BackColor == Color.YellowGreen &&
                Tabla[3, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[4, 3].Style.BackColor == Color.YellowGreen &&
                Tabla[5, 4].Style.BackColor == Color.YellowGreen &&
                Tabla[6, 5].Style.BackColor == Color.YellowGreen

             )

            {

                pic2.Visible = true;
            }

            if (Tabla[0, 1].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 2].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 3].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 4].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 5].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 6].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 7].Style.BackColor == Color.YellowGreen &&
                Tabla[0, 8].Style.BackColor == Color.YellowGreen


             )

            {

                pic3.Visible = true;
            }
        }
        public void JuegoTerminado()
        {

            if (pic1.Visible && pic2.Visible && pic3.Visible && pic4.Visible && pic5.Visible && pic6.Visible)
            {
                timer1.Stop();
                MessageBox.Show("FELICIDADES!!" +
                           "\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text + " minutos");

                SigNivel.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Visible = true;

            segundos += 1;
            string seg = segundos.ToString();
            if (segundos < 10) { seg = "0" + segundos.ToString(); }

            if (segundos == 59)
            {

                minutos += 1;
                segundos = 0;
            }

            Tiempo.Text = minutos.ToString() + ":" + seg.ToString();
        }
        private void SigNivel_Click(object sender, EventArgs e)
        {
            Form Juegos1 = new menu_e_instrucciones();
            Juegos1.Show();
            this.Hide();
        }
     

        private void Titulo_Click(object sender, EventArgs e)
        {


        }

        private void Nivel1_Load(object sender, EventArgs e)
        {

        }

        private void pa3_Click(object sender, EventArgs e)
        {

        }
    }
}
