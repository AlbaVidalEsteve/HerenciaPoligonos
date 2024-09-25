using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Teléfono { get; set; }
       
        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        //public abstract void DarDeAlta();

        public override string ToString()
        {
            return Nombre ;
        }

    }
}
