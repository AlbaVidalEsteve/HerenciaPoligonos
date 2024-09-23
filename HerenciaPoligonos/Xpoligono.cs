using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Xpoligono : Poligono
    {
        public double Lado;
        
        public Xpoligono(int numLados, double lado) : base(numLados)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
            double area = (NumLados * Math.Pow(Lado, 2)) / (4 * Math.Tan(Math.PI / NumLados));
            //Console.WriteLine($"Área del polígono con {NumLados} lados: " + area);
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = Lado * NumLados;
            //Console.WriteLine($"Perímetro del polígono con {NumLados} lados:  " + perimetro);
            return perimetro;
        }

        public override string ToString()
        {
            return "Octagono con lados de " + Lado;
        }
    }
}
