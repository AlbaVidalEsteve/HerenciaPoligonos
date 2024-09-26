using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- Menú de Gestión del Hospital ---" +
                "\n [1] Añadir Médico" +
                "\n [2] Añadir Paciente" +
                "\n [3] Añadir Administrativo" +
                "\n [4] Cambiar Médico" +
                "\n [5] Mostrar Personal" +
                "\n [6] Buscar Persona" +
                "\n [7] Mostrar Pacientes de Médico" +
                "\n [8] Borrar Personal" +
                "\n [9] Dar de alta a un paciente" +
                "\n [10] Dar cita" +
                "\n [11] Consultar cita" +
                "\n [12] Cancelar cita" +
                "\n [0] Salir" +
            "\n Seleccione una opción: ");


            string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        hospital.AñadirMedico();
                        break;
                    case "2":
                        hospital.AñadirPaciente();
                        break;
                    case "3":
                        hospital.AñadirAdministrativo();
                        break;
                    case "4":
                        hospital.CambiarMedico();                       
                        break;
                    case "5":
                        hospital.MostrarPersonal();
                        break;
                    case "6":
                        hospital.BuscarPersona<Persona>(GetNombre(""));
                        break;
                    case "7":
                        Medico medico1 = hospital.BuscarPersona<Medico>(GetNombre("medico"));
                        medico1.MostrarPacientes();
                        break;
                    case "8":
                        //Persona persona = hospital.BuscarPersona<Persona>(GetNombre());
                        //hospital.BorrarPersona();
                        Console.WriteLine("Método en desarrollo...");
                        break;
                    case "9":                        
                        hospital.DarDeAlta();
                        break;
                    case "10":                        
                        hospital.DarCita();
                        break;
                    case "11":
                        hospital.ConsultarCitas();                        
                        break;
                    case "12":
                        hospital.CancelarCita();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                string GetNombre(string tipo)
                {
                    Console.WriteLine($"Introduce el nombre del {tipo}:");
                    return Console.ReadLine();
                }
            }
            
        }
    } 
}

    