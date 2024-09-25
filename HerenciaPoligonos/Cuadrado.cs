using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Cuadrado : Rectangulo
    {

        public Cuadrado(double lado) : base(lado, lado)
        {

        }

        public override string ToString()
        {
            return "Cuadrado con lado de " + Lado1;


        }
    }
}
