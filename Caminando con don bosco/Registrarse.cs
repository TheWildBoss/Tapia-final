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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void Registro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Form Loguin= new login();
            Loguin.Show(); this.Hide();
        }

        private void btncancelarregistro_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontraseñaregistrar.Clear();
            txtfechaingreso.Clear();    
            txtnombre.Clear();  
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Loguin = new login();
            Loguin.Show(); this.Hide();

        }
    }
}
