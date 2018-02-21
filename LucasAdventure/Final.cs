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
    public partial class Final : Form
    {
        private Jugador jugador;
        private SistemaPuntuacionDataSet dataSet;
        private SistemaPuntuacionDataSetTableAdapters.JugadoresTableAdapter table_adapter;
        private SistemaPuntuacionDataSetTableAdapters.TableAdapterManager table_adapterManager;

        public Final(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
            this.dataSet = new SistemaPuntuacionDataSet();
            this.table_adapter = new SistemaPuntuacionDataSetTableAdapters.JugadoresTableAdapter();
            this.table_adapterManager = new SistemaPuntuacionDataSetTableAdapters.TableAdapterManager();
            this.table_adapter.setPuntuacion(this.jugador.getPuntuacion_total(), this.jugador.getNombre());
            this.table_adapterManager.UpdateAll(dataSet);
            int puntuacion = (int) this.table_adapter.getPuntuacion(this.jugador.getNombre());
            this.puntuacionFinalLable.Text = "Puntuación final " + puntuacion;
            
            if(puntuacion == 100)
            {
                this.texto_bocadillo.Text = "¡Enhorabuena!, has conseguido encontrar\ntodos los objetos.\n¡Gracias a tí hemos salvado el tiempo!";
            }else if(puntuacion > 40 && puntuacion < 60)
            {
                this.texto_bocadillo.Text = "¡Enhorabuena!, has acabado con casi\ntodos los objetos.\n¡Gracias a tí hemos salvado el tiempo!";
            }else if(puntuacion > 20 && puntuacion < 40)
            {
                this.texto_bocadillo.Text = "Bueno, has encontrado algunos.\n¡Sigue intentandolo!";
            }else if(puntuacion > 0 && puntuacion < 10)
            {
                this.texto_bocadillo.Text = "Quizás las próxima vez los encuentres.\n¡Ánimo!";
            }
        }

        private void puntuacionesButton_Click(object sender, EventArgs e)
        {
            Puntuaciones puntuaciones = new Puntuaciones();
            puntuaciones.Show();
        }
        private void Final_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Inicio inicio = new LucasAdventure.Inicio();
            inicio.Show();
            this.Visible = false;
        }
    }
}