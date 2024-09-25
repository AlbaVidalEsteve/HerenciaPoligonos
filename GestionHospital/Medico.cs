using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    enum eEspecialidades
    {
        Cardiología = 1,
        General,
        Neumología,
        Neurología,
        Dermatología,
        Pediatría
    }
    internal class Medico : Persona
    {
        public eEspecialidades Especialidad { get; set; }
        public List<Paciente> ListaPacientes {  get; set; }
        public Medico(string nombre,eEspecialidades especialidad) : base(nombre)
        {
            Persona medico = new Persona(nombre);
            Especialidad = especialidad;
            ListaPacientes = new List<Paciente>();
        }

        public void MostrarPacientes()
        {
            Console.WriteLine(this);
            if (ListaPacientes.Count == 0)
            {
                Console.WriteLine("No hay pacientes asignados.");
            }
            else
            {
                ListaPacientes.ForEach(p =>
                {
                    Console.WriteLine(p);
                });
            }
        }

        public override string ToString()
        {
            return $"Médico: {Nombre}," +
                $"\n Especialidad: {Especialidad}," +
                $"\n Pacientes asignados: {ListaPacientes.Count}";
        }

    }


}
