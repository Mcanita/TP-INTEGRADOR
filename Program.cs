using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_INTEGRADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // hay que agregar las cosas al menú
            // Menu(); 

            //PARA PROBAR...
            UAV drone = new UAV("UAV001", 4000, 40, 60, "Coordenadas1");
            K9 cuadrupedo = new K9("K9001", 6500, 250, 30, "Coordenadas2");
            M8 humanoide = new M8("M8001", 12250, 5, 20, "Coodenadas3");
            UAV drone2 = new UAV("UAV002", 4000, 40, 60, "Coordenadas1");

            CuartelGeneral cuartel = new CuartelGeneral();
            cuartel.AgregarOperador(drone);
            cuartel.AgregarOperador(cuadrupedo);
            cuartel.AgregarOperador(humanoide);
            Console.WriteLine("");

            drone.TransferirCarga(drone2, 3000);
            cuartel.ListarEstadoDeTodosLosOperadores();
            drone.MoverOperador("NuevaCoordenada");
            cuartel.ListarEstadoDeTodosLosOperadores();


            Console.ReadLine();
        }

        private static void Menu()
        {
            bool seguir = true;
            int opcion;

            Console.Clear();
            while (seguir)
            {
                Console.WriteLine("-------- MENU PRINCIPAL --------");
                Console.WriteLine("1) MENU OPERADORES ");
                Console.WriteLine("2) MENU CUARTEL GENERAL");
                Console.WriteLine("------------------------------");
                Console.WriteLine("0) SALIR");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una opcion : ");
                Console.ReadLine();
                opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        MenuOperadores();
                        break;
                    case 2:
                        MenuCuartelGeneral();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta ");
                        Console.WriteLine("Ingrese otra opción ");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            }
        }

        private static void MenuOperadores()
        {
            bool seguir = true;
            int opcion;
            Console.Clear();
            while (seguir)
            {
                Console.WriteLine("-------- MENÚ OPERADORES --------");
                Console.WriteLine("1) MOVER OPERADORE ");
                Console.WriteLine("2) TRANSFERIR CARGA A OTRO OPERADOR");
                Console.WriteLine("3) TRANSFERIR CARGA FÍSICA");
                Console.WriteLine("4) VOLVER AL CUARTEL Y TRANSFERIR CARGA FÍSICA");
                Console.WriteLine("5) VOLVER AL CUARTEL Y CARGAR BATERIA ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("0) VOLVER AL MENÚ PRINCIPAL");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una opcion : ");
                Console.ReadLine();
                opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta ");
                        Console.WriteLine("Ingrese otra opción ");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            }
        }

        private static void MenuCuartelGeneral()
        {
            bool seguir = true;
            int opcion;

            Console.Clear();
            while (seguir)
            {
                Console.WriteLine("-------- MENÚ CUARTEL GENERAL --------");
                Console.WriteLine("1) LISTAR ESTADO DE TODOS LOS OPERADORES ");
                Console.WriteLine("2) LISTAR ESTADO DE OPERADORES DE CIERTA LOCALIZACIÓN");
                Console.WriteLine("3) TOTAL RECALL");
                Console.WriteLine("4) OPCIONES CON UN APERADOR EN ESPECÍFICO");
                Console.WriteLine("5) AGREGAR O REMOVER OPERADORES DE LA RESERVA");
                Console.WriteLine("------------------------------");
                Console.WriteLine("0) VOLVER AL MENÚ PRINCIPAL");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una opción : ");
                Console.ReadLine();
                opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        OpcionesOperador();
                        break;
                    case 5:
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta ");
                        Console.WriteLine("Ingrese otra opción ");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            }
        }

        private static void OpcionesOperador()
        {
            bool seguir = true;
            int opcion;

            Console.Clear();
            while (seguir)
            {
                Console.WriteLine("-------- OPCIONES CON UN OPERADOR --------");
                Console.WriteLine("1) ENVIARLO A UNA LOCALIZACION ESPECÍFICA ");
                Console.WriteLine("2) INDICAR RETORNO A CUARTEL");
                Console.WriteLine("3) CAMBIAR A ESTADO A STANDBY ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("0) REGRESAR AL MENÚ CUARTEL GENERAL");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una opcion : ");
                Console.ReadLine();
                opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta ");
                        Console.WriteLine("Ingrese otra opción ");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
