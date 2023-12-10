using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
     public class Localizacion
    {
        private int posicionX;
        private int posicionY;

        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        public Localizacion(int horizontal, int vertical)
        {
            PosicionX = horizontal;
            PosicionY = vertical;
        }
    }
}
