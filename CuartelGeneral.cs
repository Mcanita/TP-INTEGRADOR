using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
    class CuartelGeneral
    {
        private List<Operador> operadores;

        public CuartelGeneral()
        {
            operadores = new List<Operador>();
        }

        public void AgregarOperador(Operador operador)
        {
            operadores.Add(operador);
        }


        public void ListarEstadoDeTodosLosOperadores()
        {
            Console.WriteLine(" ESTADO DE TODOS LOS OPERADORES : ");
            foreach (var operador in operadores)
            {
                Console.WriteLine($"ID : {operador.Id}, BATERIA : {operador.Bateria}, LOCALIZACIÓN : {operador.Localizacion}");
            }
            Console.WriteLine("");
        }
        public void ReLocalizarOperador()
        {
            //REALIZAR FUNCIÓN PARA MANDAR A UN OPERADOR A OTRA LOCALIZACIÓN
        }

        public void RetornoCuartel()
        {
            //REALIZAR FUNCIÓN PARA QUE UN OPERADOR VUELVA AL CUARTEL
        }

        public void CambiarEstado()
        {
            //REALIZAR FUNCIÓN PARA CAMBIAR EL ESTADO DE UN OPERADOR
        }

        public void AgregarRemoverDeReserva()
        {
            //REALIZAR FUNCION PARA AGREGAR O REMOVER UN OPERADOR A LA RESERVA 
        }

        public void TotalRecall()
        {
            //REALIZAR FUNCIÓN QUE REALICE UN TOTALRECALL
        }

    }
}
