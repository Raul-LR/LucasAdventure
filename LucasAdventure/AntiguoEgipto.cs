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
    public partial class AntiguoEgipto : Form
    {
        private Jugador jugador;
        private int timeLeft = 15;
        private int total_objetos = 4;
        private int num_encontrados = 0;

        public AntiguoEgipto(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
            timer1.Start();
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void egipcio_MouseHover(object sender, EventArgs e)
        {
            texto_bocadillo2.Visible = true;
            bocadillo2.Visible = true;
        }

        private void egipcio_MouseLeave(object sender, EventArgs e)
        {
            texto_bocadillo2.Visible = false;
            bocadillo2.Visible = false;
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

        private void calculadora_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.calculadora.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void robot_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.robot.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void termo_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.termo.Visible = false;
            this.jugador.sumarPuntuacion(5);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void todoterreno_Click(object sender, EventArgs e)
        {
            this.num_encontrados++;
            this.progressLabel.Text = num_encontrados + "/" + total_objetos;
            this.todoterreno.Visible = false;
            this.jugador.sumarPuntuacion(10);
            this.puntuacionLable.Text = "Puntos " + this.jugador.getPuntuacion_total();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0 && this.num_encontrados < 4)
            {
                timeLeft = timeLeft - 1;
                timeLable.Text = timeLeft + "s";
            }else if(timeLeft == 0 || this.num_encontrados == 4)
            {
                timer1.Stop();
                ImperioRomano nivel2 = new ImperioRomano(this.jugador);
                nivel2.Show();
                this.Close();
            }
        }

    }
}
