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
    public partial class Ahorcado : Form
    {
        char[] PalabrasAdivinadas;
        int Oportunidades;
      
        char[] PalabrasSeleccionadas;
        char[] Alfabeto;
        string[] Palabras;

        public Ahorcado()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            //Valores iniciales del juego
            flFichasDeJuego.Controls.Clear();   
            flFichasDeJuego.Enabled = true;
            picAhorcado.Image = null; 
            lblMensaje.Visible = false; 
            Oportunidades = 0;  //fallo
            btnIniciarJuego.Image = Properties.Resources.Jugando;
            Palabras = new string[] { "MamaMargarita","Nueve", "DonBosco", "Stich", "Salesianos", "Jesus"};
            Alfabeto="ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //palabra aleatoria adivinar
            
            Random random = new Random();
            int IndicePalabrasseleccionadas = random.Next(0, Palabras.Length);
            PalabrasSeleccionadas= Palabras[IndicePalabrasseleccionadas].ToUpper().ToArray();
            PalabrasAdivinadas = PalabrasSeleccionadas;
            // ciclo del alfabeto en el flowlayout---> fichas de juego

            foreach (char LetraAlfabeto in Alfabeto) 
            { 
            Button btnLetra=new Button(); 
                btnLetra.Tag = "";
                btnLetra.Text= LetraAlfabeto.ToString();
                     btnLetra.Width = 90;
                      btnLetra.Height = 50; 
                       btnLetra.ForeColor = Color.White;    
                        btnLetra.Font= new Font (btnLetra.Font.Name,15, FontStyle.Bold);
                     btnLetra.BackColor = Color.Black;
                btnLetra.BackgroundImageLayout =ImageLayout.Center;
                    btnLetra.Name = LetraAlfabeto.ToString();
                    flFichasDeJuego.Controls.Add(btnLetra); 


            }
            flPalabra.Controls.Clear();
            //ciclo q agrega la palabra en el flowlayo(palabra adivinar)
            for (int IndiceValorLetra = 0; IndiceValorLetra< PalabrasSeleccionadas.Length; IndiceValorLetra++) 
            {
 
            }
        }
        

        private void Ahorcado_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
