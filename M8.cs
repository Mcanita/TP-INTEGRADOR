using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
    public class M8 : Operador
    {
        //CARGA MAX DE BATERIA = 12250
        //CARGA MAX DE PESO = 250KG 
        public M8(string id, int bateria, int cargaMaxima, int velocidadOptima, string localizacion)
            : base(id, bateria, cargaMaxima, velocidadOptima, localizacion)
        {

        }


    }
}
