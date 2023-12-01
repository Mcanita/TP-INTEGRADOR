using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
    public abstract class Operador
    {
        public string Id { get; set; }
        public int Bateria { get; set; }
        public bool Estado { get; set; }
        public int CargaMaxima { get; set; }
        public double CargaActual { get; set; }
        public double VelocidadOptima { get; set; }
        public string Localizacion { get; set; }

        public Operador(string id, int bateria, int cargaMaxaxima, double VelocidadOptima, string localizacion)
        {
            Id = id;
            Bateria = bateria;
            CargaMaxima = cargaMaxaxima;
            CargaActual = 0;
            VelocidadOptima = VelocidadOptima;
            Localizacion = localizacion;
            Estado = false;
        }



        public void MoverOperador(string nuevaLocalizacion)
        {
            double velocidadActual = Estado ? 0 : VelocidadOptima * (Bateria / 100.0);
            Console.WriteLine($"SE ESTÁ MOVIENOD HACIA {nuevaLocalizacion} A UNA VELOCIDAD ACTUAL DE {velocidadActual} km/h");
            Console.WriteLine("");

            ConsumirBateria(10);
            if (Estado) velocidadActual *= 0.95;
        }

        public void TransferirCarga(Operador transferido, int cantidad)
        {
            if (Localizacion == transferido.Localizacion)
            {
                int cargaParaTransferir = Math.Min(Bateria, cantidad);
                Bateria -= cargaParaTransferir;
                transferido.Bateria += cargaParaTransferir;
                Console.WriteLine($" SE PUDO TRANSFERIR {cargaParaTransferir} mAh");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(" NO SE PUDO TRANSFERIR POR NO ESTAR EN LA MISMA LOCALIZACIÓN");
                Console.WriteLine("");
            }

        }

        public void TransferirCargaFisica(Operador transferido, int cantidad)
        {
            if (Localizacion == transferido.Localizacion)
            {
                int cargaFisicaTransferir = Math.Min(CargaMaxima, cantidad);
                Console.WriteLine($"SE TRANSFIRIÓ {cargaFisicaTransferir} Kg DE CARGA FÍSICA");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("NO SE PUDO TRANSFERIR POR NO ESTAR EN LA MISMA LOCALIZACIÓN");
                Console.WriteLine("");
            }

        }
        public void ConsumirBateria(int porcentaje)
        {
            Bateria -= porcentaje;
        }

        public void CargarBateria()
        {

        }

        public void VolverAlCuartelYCargarBateria()
        {
            //REALIZAR FUNCIÓN PARA QUE UN OPERADOR VUELVA Y CARGUE LA BATERÍA
        }



    }
}
