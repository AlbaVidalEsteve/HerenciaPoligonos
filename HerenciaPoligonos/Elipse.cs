using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Elipse : Formas2D
    {
        public double Radio1 { get; set; }
        public double Radio2 {  get; set; }
        double PI = Math.PI;

        public Elipse(double radio1, double radio2)
        {
            this.Radio1 = radio1;
            this.Radio2 = radio2;   
        }
        public override double CalcularArea()
        {
           
            double area = PI * Radio1 * Radio2;
            //Console.WriteLine("Área del elipse: " + area);
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = PI*((3* Radio1 + Radio2) - Math.Sqrt((3* Radio1 + Radio2)*(Radio1 + 3*Radio2)));
            //Console.WriteLine("Perímetro del elipse: " + perimetro);
            return perimetro;
        }

        public override string ToString()
        {
            return $"Elispse con radios de {Radio1} y {Radio2}";

        }
    }
}
