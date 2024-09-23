using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Circulo : Elipse
    {
        double Radio;
        
        public Circulo(double radio) : base(radio, radio)
        {
            Radio = radio;
            Elipse circulo = new Elipse(Radio, Radio);
        }

        public override string ToString()
        {
            return $"Circulo con radio {Radio}";
        }
    }
}
