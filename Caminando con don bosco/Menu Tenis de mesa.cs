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
    public partial class Menu_Tenis : Form
    {
        public Menu_Tenis()
        {
            InitializeComponent();
        }

        private void BTN_Retroceder_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            Juego_Tenis tenis = new Juego_Tenis();
          
            tenis.Show(this);
            this.Hide();

        }

        private void Menu_Tenis_Load(object sender, EventArgs e)
        {

        }
    }
}
