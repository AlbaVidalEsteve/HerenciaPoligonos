using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Cita
    {
        public DateTime Fecha;
        public Medico Medico;
        public Paciente Paciente;
        public eEspecialidades Especialidad;
        public Guid Id;

        public Cita(DateTime fecha, Medico medico, Paciente paciente)
        {
            Fecha = fecha;
            Medico = medico;
            Paciente = paciente;
            Especialidad = medico.Especialidad;
        }
        public override string ToString()
        {
            return $"Paciente: {Paciente}, Médico: {Medico} ({Especialidad}), Fecha {Fecha}";
        }
    }
}
