using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
    public class UAV : Operador
    {
        //CARGA MAX DE BATERIA = 4000
        //CARGA MAX DE PESO = 5KG 
        public UAV(string id, int bateria, int cargaMaxima, int velocidadOptima, string localizacion)
            : base(id, bateria, cargaMaxima, velocidadOptima, localizacion)
        {

        }
    }
}
