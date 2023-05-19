using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caminando_con_don_bosco
{
    public partial class Juego_Don_Bosco_quiziz : Form
    {
        int segundos;
        int contador2 = 60;
        public Juego_Don_Bosco_quiziz()
        {
            InitializeComponent();
        }

        private void Contador_Tick(object sender, EventArgs e)
        {




        }

        private void Juego_Don_Bosco_quiziz_Load(object sender, EventArgs e)
        {


        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            BtnIniciar.Enabled = false;
            int contador = 3;
            Timer timer = new Timer();
            timer.Start();
            timer.Interval = 500; // 1 segundo

            timer.Tick += (s, args) =>
            {
                contador--;
                lblSegundo.Text = contador.ToString();
                if (contador == 0)
                {
                    timer.Stop();

                    lblSegundo.Text = "";
                }
                else
                {
                    timer1.Start();


                }
            };

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Segundos_Tick(object sender, EventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {





            int cuenta = contador2;
            //Timer timer1 = new Timer();

            timer1.Interval = 500; // 1 segundo
            timer1.Tick += (s, args) =>
            {

                contador2 = cuenta - 1;
                lblDescontador.Text = cuenta.ToString();
                if (cuenta == 0)
                {
                    timer1.Stop();
                    lblDescontador.Text = "";
                }
                else
                {

                    timer1.Start();

                }
            };
            
            }
    }
    }
