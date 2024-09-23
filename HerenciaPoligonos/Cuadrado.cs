using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Cuadrado : Rectangulo
    {
        double Lado;

        public Cuadrado(double lado) : base(lado, lado)
        {
            Lado = lado;
            Rectangulo cuadrado = new Rectangulo(Lado, Lado);
        }

        public override string ToString()
        {
            return $"Cuadrado con lado de {Lado1}";
           
        }
    }
}
