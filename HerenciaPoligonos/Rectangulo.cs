using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Rectangulo : Poligono
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public Rectangulo(double lado1, double lado2) : base(4)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }
        public override double CalcularArea()
        {
            double area = Lado1 * Lado2;
            //Console.WriteLine("Área del rectangulo: " + area);
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = Lado1 * 2 + Lado2 * 2;
            //Console.WriteLine("Perímetro del rectángulo: " + perimetro);
            return perimetro;
        }
        public override string ToString()
        {
            if (Lado1 == Lado2)
            {
                return $"Cuadrado con lado de {Lado1}";
            }
            else
            {
                return $"Rectangulo con lados de {Lado1} y {Lado2}";
            }
        }
    }
}
