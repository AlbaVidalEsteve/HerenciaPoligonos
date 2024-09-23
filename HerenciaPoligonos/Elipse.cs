using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Elipse : Formas2D
    {
        public double Radio1;
        public double Radio2;
        double PI = Math.PI;

        public Elipse(double radio1, double radio2)
        {
            this.Radio1 = radio1;
            this.Radio2 = radio2;   
        }
        public double CalcularArea()
        {
           
            double area = PI * Radio1 * Radio2;
            Console.WriteLine("Área del elipse: " + area);
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = PI*((3* Radio1 + Radio2) - Math.Sqrt((3* Radio1 + Radio2)*(Radio1 + 3*Radio2)));
            Console.WriteLine("Perímetro del elipse: " + perimetro);
            return perimetro;
        }
    }
}
