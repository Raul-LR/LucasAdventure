using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasAdventure
{
    class Objeto
    {
        private String nombre = null;
        private int puntos = 0;
        private String ruta_imagen = null;
        
        public Objeto(String nombre, int puntos, String ruta_imagen)
        {
            this.nombre = nombre;
            this.puntos = puntos;
            this.ruta_imagen = ruta_imagen;
        }  
    }
}
