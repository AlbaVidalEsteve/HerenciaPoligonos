using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string tipoCalculo = EscogeCalculo();
            EscogeForma(tipoCalculo);

            
            Console.ReadKey();
        }

        public static void EscogeForma(string tipoCalculo)
        {
            Console.WriteLine("----- Escoge una forma 2D -----\n" +
                              "\n\t[1] Polígono" +
                              "\n\t[2] Elipse");
            string seleccion = Console.ReadLine();

            if (seleccion == "1")
            {
                EscogePoligono(tipoCalculo);
            }
            else if (seleccion == "2")
            {
                double radio1 = PedirValor("Radio 1");
                double radio2 = PedirValor("Radio 2");

                Elipse elipse1 = new Elipse(radio1, radio2);
                if (tipoCalculo == "area")
                {
                    elipse1.CalcularArea();
                }
                else if (tipoCalculo == "perimetro")
                {
                    elipse1.CalcularPerimetro();
                }
            }
            else
            {
                Console.WriteLine("Selección no válida.");
            }
        }
        public static void EscogePoligono(string tipoCalculo)
        {
            Console.WriteLine("----- Escoge un polígono -----\n" +
                              "\n\t[1] Triángulo" +
                              "\n\t[2] Rectángulo" +
                              "\n\t[3] Rombo" +
                              "\n\t[4] Xpoligono");
            string poligonoEscogido = Console.ReadLine();

            switch (poligonoEscogido)
            {
                case "1": // Triángulo
                    double lado1 = PedirValor("Lado1 1");
                    double lado2 = PedirValor("Lado 2");
                    double lado3 = PedirValor("Lado 3");
                
                    Triangulo triangulo1 = new Triangulo(lado1, lado2, lado3);
                    if (tipoCalculo == "1") // Área
                    {
                        triangulo1.CalcularArea();

                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        triangulo1.CalcularPerimetro();
                    }
                    break;
                case "2": // Rectángulo
                    double base1 = PedirValor("Base");
                    double altura = PedirValor("Altura");

                    Rectangulo rectangulo1 = new Rectangulo(base1, altura);
                    if (tipoCalculo == "1") // Área
                    {
                        rectangulo1.CalcularArea();

                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        rectangulo1.CalcularPerimetro();
                    }
                    break;
                case "3": // Rombo
                    double diagonal1 = PedirValor("Diagonal 1");
                    double diagonal2 = PedirValor("Diagonal 2");
                    Rombo rombo1 = new Rombo(diagonal1, diagonal2);
                    if (tipoCalculo == "1") // Área
                    {
                        rombo1.CalcularArea();

                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        rombo1.CalcularPerimetro();
                    }
                    break;
                case "4": // Xpoligono
                    int numLados = (int)PedirValor("Numero de lados");
                    double lado = PedirValor("Lado ");
                    Xpoligono xpoligono1 = new Xpoligono(numLados, lado);
                    if (tipoCalculo == "1") // Área
                    {
                        xpoligono1.CalcularArea();

                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        xpoligono1.CalcularPerimetro();
                    }
                    break;
                default:
                    Console.WriteLine("Selección no válida.");
                    break;
            }
        }
        public static string EscogeCalculo()
        {
            Console.WriteLine("----- ¿Qué quieres calcular? -----\n" +
                              "\n\t1. Área" +
                              "\n\t2. Perímetro");
            string tipoCalculo = Console.ReadLine();
            return tipoCalculo;
        }

        public static double PedirValor(string mensaje)
        {
            Console.Write(mensaje + ": ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}

