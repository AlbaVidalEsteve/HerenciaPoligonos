using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Circulo : Elipse
    {       
        public Circulo(double radio) : base(radio, radio)
        {
        }

        public override string ToString()
        {
            return $"Circulo con radio {Radio1}";
        }
    }
}
