using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Paciente : Persona
    {
        public Medico MedicoAsignado { get; set; }
      
        public List<string> Diagnosticos { get; set; }
        public List<string> Tratamientos { get; set; }
        public Paciente(string nombre, Medico medico) : base(nombre)
        {
            MedicoAsignado = medico;
            medico.ListaPacientes.Add(this);
        }
        public Paciente(string nombre) : base(nombre)
        {
        }
        public override string ToString()
        {
            return $"Paciente: {Nombre}";
        }
    }
}
