using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Administrativo : Persona
    {
        public Administrativo(string nombre) : base(nombre)
        {
            //Persona administrativo = new Persona(nombre);
        }

        public override string ToString()
        {
            return $"Administrativo: {Nombre}";
        }
    }
}
