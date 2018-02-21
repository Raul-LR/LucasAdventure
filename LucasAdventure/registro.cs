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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador(this.nombre.Text);
            SistemaPuntuacionDataSetTableAdapters.JugadoresTableAdapter table_adapter = new SistemaPuntuacionDataSetTableAdapters.JugadoresTableAdapter();
            table_adapter.insertarJugador(jugador.getNombre());
            AntiguoEgipto nivel1 = new AntiguoEgipto(jugador);
            nivel1.Show();
            this.Visible = false;
        }
    }
}
