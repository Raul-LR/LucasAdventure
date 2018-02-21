using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasAdventure
{
    public class Jugador
    {
        private String nombre = null;
        private int puntuacion_total = 0;

        public Jugador(String nombre)
        {
            this.nombre = nombre;
        }

        public void sumarPuntuacion (int puntos)
        {
            this.puntuacion_total = this.puntuacion_total + puntos;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public int getPuntuacion_total()
        {
            return this.puntuacion_total;
        }
    }
}
