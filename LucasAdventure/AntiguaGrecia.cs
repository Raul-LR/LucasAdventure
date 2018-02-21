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
    public partial class AntiguaGrecia : Form
    {
        private Jugador jugador;
        private int timeLeft = 15;
        private int total_objetos = 4;
        private int num_encontrados = 0;

        public AntiguaGrecia(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
            timer1.Start();
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
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

        private void linterna_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.linterna.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void brujula_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.brujula.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void telefono_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.telefono.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void gorra_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.gorra.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0 && this.num_encontrados < 4)
            {
                timeLeft = timeLeft - 1;
                timeLable.Text = timeLeft + "s";
            }
            else if (timeLeft == 0 || this.num_encontrados == 4)
            {
                timer1.Stop();
                Final final = new Final(this.jugador);
                final.Show();
                this.Close();
            }
        }
    }
}
