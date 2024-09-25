﻿using System;
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
                "\n [0] Salir" +
            "\n Seleccione una opción: ");


            string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        hospital.AñadirMedico(GetNombreMedico());
                        break;
                    case "2":
                        Medico medicoAsignado = hospital.BuscarPersona<Medico>(GetNombreMedico());
                        if (medicoAsignado != null)
                        {
                            hospital.AñadirPaciente(GetNombrePaciente(), medicoAsignado);
                        }
                        else
                        {
                            Console.WriteLine("Médico no encontrado.");
                        }
                        break;
                    case "3":
                        hospital.AñadirAdministrativo(GetNombre());
                        break;
                    case "4":
                        Paciente pacienteACambiar = hospital.BuscarPersona<Paciente>(GetNombrePaciente());
                        Medico medicoNuevo = hospital.BuscarPersona<Medico>(GetNombreMedico());
                        if (pacienteACambiar != null && medicoNuevo != null)
                        {
                            hospital.CambiarMedico(pacienteACambiar, medicoNuevo);
                        }
                        else
                        {
                            Console.WriteLine("Paciente o médico no encontrado.");
                        }
                        break;
                    case "5":
                        hospital.MostrarPersonal();
                        break;
                    case "6":
                        hospital.BuscarPersona<Persona>(GetNombre());
                        break;
                    case "7":
                        Medico medico1 = hospital.BuscarPersona<Medico>(GetNombreMedico());
                        medico1.MostrarPacientes();
                        break;
                    case "8":
                        Persona persona = hospital.BuscarPersona<Persona>(GetNombre());
                        //hospital.BorrarPersona();
                        Console.WriteLine("Método en desarrollo...");
                        break;
                    case "9":
                        Paciente paciente1 = hospital.BuscarPersona<Paciente>(GetNombrePaciente());
                        Medico medico2 = hospital.BuscarPersona<Medico>(GetNombreMedico());
                        hospital.DarDeAlta(paciente1, medico2);
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            }
            string GetNombre()
            {
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine();
                return nombre;
            }

            string GetNombrePaciente()
            {
                Console.WriteLine("Nombre del paciente:");
                string nombre = Console.ReadLine();
                return nombre;
            }
            string GetNombreMedico()
            {
                Console.WriteLine("Nombre del médico:");
                string nombre = Console.ReadLine();
                return nombre;
            }

        }
    } 
}

    