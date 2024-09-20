using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Triangulo : Poligono
    {
        public double Lado1;
        public double Lado2;
        public double Lado3;
        public Triangulo(double lado1, double lado2, double lado3) : base(3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public double CalcularArea()
        {
            double semiperimetro = (Lado1 + Lado2 + Lado3) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * (semiperimetro - Lado2) * (semiperimetro - Lado3));
            Console.WriteLine("Área del triángulo: " + area);
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = Lado1 + Lado2 + Lado3;
            Console.WriteLine("Perímetro del trángulo: " + perimetro);
            return perimetro;
        }

        public override string ToString()
        {
            return $"Triángulo con lados de {Lado1}, {Lado2} i {Lado3}";
        }
    }
}
