using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Rombo : Poligono
    {
        public double Diagonal1;
        public double Diagonal2;

        public Rombo(double diagonal1, double diagonal2) : base(4)
        {
            this.Diagonal1 = diagonal1;  
            this.Diagonal2 = diagonal2;
        }
        public override double CalcularArea()
        {
            double area = (Diagonal1 * Diagonal2)/2;
            //Console.WriteLine("Área del rombo: " + area);
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = Diagonal1 * 2 + Diagonal2 * 2; 
            //Console.WriteLine("Perímetro del rombo: " + perimetro);
            return perimetro;
        }

        public override string ToString()
        {
            return $"Rombo con lados de {Diagonal1} y {Diagonal2}";
        }
    }
}
