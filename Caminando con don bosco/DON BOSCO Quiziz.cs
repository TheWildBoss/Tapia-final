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
    public partial class DON_BOSCO_Quiziz : Form
    {
       

        
        private int contador = 3;
        private int descontador = 60;



        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;




        public DON_BOSCO_Quiziz()
        {
            InitializeComponent();

            questions.Add(new Question
            {
                Text = "¿Quién fue Don Bosco",
                Options = new List<string> { "Un niño cualquiera", " Un sacerdote que velaba por los niños", "Un rapero norteamericano", "Una persona", "Otra gente","Una persona que seguia a Dios" },
                Answer = "Un sacerdote que velaba por los niños"
            });

            questions.Add(new Question
            {
                Text = "¿Quién se le presento en sueños a Don Bosco?",
                Options = new List<string> { "EL señor que vende panes", "La Virgen María", "Un Angel", "Dios", "Jesús", "San Rafael" },
                Answer = "La Virgen María"
            });

            questions.Add(new Question
            {
                Text = "¿En que edad tuvo el sueño?",
                Options = new List<string> { "2", "4", "09", "15", "24", "45", "12" },
                Answer = "09"
            });

            questions.Add(new Question
            {
                Text = "¿En que año murio?",
                Options = new List<string> { "1996", "1998", "2000", "2002", "1888", "1963"},
                Answer = "1888"
            });
            
            questions.Add(new Question
            {
                Text = "¿Qué mensaje nos deja Don Bosco?",
                Options = new List<string> { "Que no importa lo que hacemos o no hacemos", "Dios nos quiere siempre felices, haciendo bien todo lo que tenemos que hacer"
                , "Que seamos buenas personas de bien", "Que seamos jovenes de bien" },
                Answer = "Dios nos quiere siempre felices, haciendo bien todo lo que tenemos que hacer"
            });

            MostrarPreguntas(currentQuestionIndex);


        }


        private void MostrarPreguntas(int questionIndex)
        {
       
            var question = questions[questionIndex];


            LabelPregunta.Text = question.Text;

            button1.Text = question.Options[0];
            button2.Text = question.Options[1];
            button3.Text = question.Options[2];
            button4.Text = question.Options[3];
            button5.Text = question.Options[4];
            button6.Text = question.Options[5];

        }





        private void CheckAnswer(string answer)
        {
        
            var question = questions[currentQuestionIndex];

   
            if (question.Answer == answer)
            {
            
                score++;
            }

         
            currentQuestionIndex++;

            
            if (currentQuestionIndex < questions.Count)
            {
                MostrarPreguntas(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show($"Tu puntaje final es {score} de {questions.Count}");
            }
        }







        private void DON_BOSCO_Quiziz_Load(object sender, EventArgs e)
        {
 

        }

     


        private void TimerContador_Tick(object sender, EventArgs e)
        {
            TimerContador.Interval = 1000;
            contador--;
            LblContador.Text = contador.ToString();
            if (contador == 0)
            {
                TimerContador.Stop();
                LblContador.Text = "";
                TimerDescontador.Start();
            }


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            TimerContador.Start();
        }

        private void TimerDescontador_Tick(object sender, EventArgs e)
        {

            }

            private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer(button1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckAnswer(button1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckAnswer(button1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckAnswer(button1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckAnswer(button1.Text);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckAnswer(button1.Text);

        }
    }
    }




