using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Diagrama
    {
        List<Formas2D> ListaFormas { get; set; }

        public Diagrama()
        {
            ListaFormas = new List<Formas2D>();
        }

        //public Diagrama(int numFormas) : this()
        //{
        //    CrearDiagrama(numFormas);
        //}

        public void AgregarForma(Formas2D forma)
        {
            ListaFormas.Add(forma);
        }

        public double CalcularAreaTotal()
        {
            double totalArea = 0;
            foreach (Formas2D forma in ListaFormas)
            {
                totalArea += forma.CalcularArea();
            }
            return totalArea;
        }

        public double CalcularPerimetroTotal()
        {
            double totalPerimetro = 0;
            foreach (Formas2D forma in ListaFormas)
            {
                totalPerimetro += forma.CalcularPerimetro();
            }
            return totalPerimetro;
        }

        public void MostrarFormas()
        {
            foreach (Formas2D forma in ListaFormas)
            {
                string tipoForma = forma.GetType().Name;
                Console.WriteLine($"{tipoForma}: Área = {forma.CalcularArea()}, Perímetro = {forma.CalcularPerimetro()}");
            }
        }
        public void CrearDiagrama(int NumFormas)
        {
            
            Random random = new Random();
            for (int i = 0; i < NumFormas; i++)
            {
                int tipoForma = random.Next(1, 8);

                switch (tipoForma)
                {
                    case 1: 
                        double lado1 = random.Next(1, 10);
                        double lado2 = random.Next(1, 10);
                        double lado3;
                        do
                        {
                            lado3 = random.Next(1, (int)lado1 + (int)lado2); // lado3 debe ser menor que la suma de lado1 y lado2
                        } while (lado3 <= Math.Abs(lado1 - lado2)); // lado3 debe ser mayor que la diferencia de lado1 y lado2

                        ListaFormas.Add(new Triangulo(lado1, lado2, lado3));
                        break;

                    case 2: 
                        double largo = random.Next(1, 10);
                        double ancho = random.Next(1, 10);
                        ListaFormas.Add(new Rectangulo(largo, ancho));
                        break;
                    case 3: 
                        double lado = random.Next(1, 10);
                        ListaFormas.Add(new Rectangulo(lado, lado));
                        break;
                    case 4: 
                        double radio = random.Next(1, 10);
                        ListaFormas.Add(new Elipse(radio, radio));
                        break;
                    case 5: 
                        double radio1 = random.Next(1, 10);
                        double radio2 = random.Next(1, 10);
                        ListaFormas.Add(new Elipse(radio1, radio2));
                        break;
                    case 6:
                        double diagonal1 = random.Next(1, 10);
                        double diagonal2 = random.Next(1, 10);
                        ListaFormas.Add(new Rombo(diagonal1, diagonal2));
                        break;
                    case 7:
                        double lados = random.Next(1, 10);
                        double radioX = random.Next(1, 10);
                        ListaFormas.Add(new Rombo(lados, radioX));
                        break;
                }
            }            
        }
        
        //public override string ToString()
        //{
        //    return "";
        //}
    }

}