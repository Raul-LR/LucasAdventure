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
    public partial class ImperioRomano : Form
    {
        private Jugador jugador;
        private int timeLeft = 15;
        private int total_objetos = 4;
        private int num_encontrados = 0;

        public ImperioRomano(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
            timer1.Start();
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void romano_MouseHover(object sender, EventArgs e)
        {
            texto_bocadillo.Visible = true;
            bocadillo.Visible = true;
        }

        private void romano_MouseLeave(object sender, EventArgs e)
        {
            texto_bocadillo.Visible = false;
            bocadillo.Visible = false;
        }

        private void antena_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.antena.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void avion_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.avion.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void ventilador_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.ventilador.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void signal_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.signal.Visible = false;
            this.jugador.sumarPuntuacion(10);
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
                Prehistoria nivel3 = new Prehistoria(this.jugador);
                nivel3.Show();
                this.Close();
            }
        }
    }
}
