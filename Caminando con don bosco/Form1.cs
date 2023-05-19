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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text=="usuario" && txtcontraseña.Text=="admin")
            {
                Form Menu = new menu_e_instrucciones();
                Menu.Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no son correctos");
                txtusuario.Clear();
                txtcontraseña.Clear();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontraseña.Clear();  
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form Registrarse=new Registrarse();
            Registrarse.Show();
            this.Hide();    
        }
    }
}
