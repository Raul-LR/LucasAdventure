using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucasAdventure
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void lucas_MouseHover(object sender, EventArgs e)
        {
            texto_bocadillo.Visible = true;
            bocadillo.Visible = true;
        }

        private void lucas_MouseLeave(object sender, EventArgs e)
        {
            texto_bocadillo.Visible = false;
            bocadillo.Visible = false;
        }

        private void lucas_Click(object sender, EventArgs e)
        {
            registro registro = new registro();
            registro.Show();
            this.Visible = false;
        }
    }
}
