using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
    public class K9 : Operador
    {
        //CARGA MAX DE BATERIA = 6500
        //CARGA MAX DE PESO = 40KG 
        public K9(string id, int bateria, int cargaMaxima, int velocidadOptima, string localizacion)
            : base(id, bateria, cargaMaxima, velocidadOptima, localizacion)
        {

        }


    }
}
