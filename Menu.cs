using System;

namespace Tienda_virtual
{
    /// <summary>
    /// Description of Menu.
    /// </summary>
    public class Menu
    {
        ListaPacientes listapacientes = new ListaPacientes(); /* Creo una nueva instancia del tipo ListaPacientes */
        ListaMedicos listamedicos = new ListaMedicos();
        public Menu() /* Constructor por defecto */
        {
        }

        public void Principal()
        {

            int op;
            do
            { /* Implemento un Do While para que el menú se ejecute al menos una vez */
                Console.Clear();
                Console.WriteLine("*********************************************************************************************");
                Console.WriteLine("*************                         TURNOS MEDICOS                            *************");
                Console.WriteLine("*********************************************************************************************\n");
                Console.WriteLine("¿A qué módulo desea ingresar?\n"); /* Muestro el menú */

                Console.WriteLine("1) Ingresar nuevo paciente");
                Console.WriteLine("2) Ingresar nuevo médico");
                Console.WriteLine("3) Agenda turnos");
                Console.WriteLine("4) Listado de obra sociales");
                Console.WriteLine("5) Salir");

                op = int.Parse(Console.ReadLine()); /* Parseo el dato ingresado por el usuario para pasarlo 
				de string a entero */

                switch (op)
                { /* Inicializo el menu con un switch */

                    case 1:
                        listapacientes.Agregar();
                        break;
                    case 2:
                        listamedicos.Agregar();
                        break;
                    case 3:
                        listamedicos.Turnos();
                        break;
                    case 4:
                        listamedicos.ObrasSociales(); //hacerla
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta"); /* Agrego una opción más en caso de que se ingrese
						un numero fuera de rango */
                        break;
                }

            } while (op != 5);
        }


        public void ModuloPaciente()
        { /* Creo un nuevo método llamado ModuloPaciente */


            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("*********************************************************************************************");
                Console.WriteLine("*************                           MÓDULO PACIENTES                        *************");
                Console.WriteLine("*********************************************************************************************\n");
                Console.WriteLine("¿Que desea hacer?\n");

                Console.WriteLine("1) Listar pacientes");
                Console.WriteLine("2) Dar de baja pacientes");
                Console.WriteLine("3) Volver");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        listapacientes.Agregar();
                        break;
                    case 2:
                        listapacientes.Eliminar(); // hacerla
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }

            } while (op != 3);


        }

        public void ModuloMedico()
        { /* Creo un nuevo método llamado ModuloMedico */


            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("*********************************************************************************************");
                Console.WriteLine("*************                           MÓDULO MEDICO                          *************");
                Console.WriteLine("*********************************************************************************************\n");
                Console.WriteLine("¿Que desea hacer?\n");

                Console.WriteLine("1) Listar médicos ");
                Console.WriteLine("2) Listar obras sociales por médico");
                Console.WriteLine("3) Volver");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        listamedicos.Imprimir();
                        break;
                    case 2:
                        listamedicos.ObraSocialPorMedico(); //hacerla
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }



            } while (op != 3);


        }
    }
}
