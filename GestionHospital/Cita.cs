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

        public Cita(DateTime fecha, Medico medico, Paciente paciente)
        {
            Fecha = fecha;
            Medico = medico;
            Paciente = paciente;
        }
        public override string ToString()
        {
            return $"Paciente: {Paciente}, Médico: {Medico}, Fecha {Fecha}";
        }
    }
}
