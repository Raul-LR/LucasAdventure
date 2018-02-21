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
    public partial class Prehistoria : Form
    {
        private Jugador jugador;
        private int timeLeft = 15;
        private int total_objetos = 4;
        private int num_encontrados = 0;

        public Prehistoria(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
            timer1.Start();
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void lucas_MouseHover(object sender, EventArgs e)
        {
            texto_bocadillo1.Visible = true;
            bocadillo1.Visible = true;
        }

        private void lucas_MouseLeave(object sender, EventArgs e)
        {
            texto_bocadillo1.Visible = false;
            bocadillo1.Visible = false;
        }

        private void nomada_MouseHover(object sender, EventArgs e)
        {
            texto_bocadillo2.Visible = true;
            bocadillo2.Visible = true;
        }

        private void nomada_MouseLeave(object sender, EventArgs e)
        {
            texto_bocadillo2.Visible = false;
            bocadillo2.Visible = false;
        }

        private void mechero_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.mechero.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void tablet_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.tablet.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void gatoSuertudo_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.gatoSuertudo.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void gafasSol_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.gafasSol.Visible = false;
            this.jugador.sumarPuntuacion(15);
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
                AntiguaGrecia nivel4 = new AntiguaGrecia(this.jugador);
                nivel4.Show();
                this.Close();
            }
        }
    }
}
