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
            //Crear diagrama
            Diagrama diagrama = new Diagrama();
            Console.WriteLine("¿Cuantas formas quieres en el diagrama?");
            int NumFormas = Convert.ToInt32(Console.ReadLine());
            diagrama.CrearDiagrama(NumFormas);
            diagrama.MostrarFormas();
            Console.WriteLine("Área total: "+diagrama.CalcularAreaTotal());
            Console.WriteLine("Perímetro total: " + diagrama.CalcularPerimetroTotal());

            //Crear forma
            string tipoCalculo = EscogeCalculo();
            EscogeForma(tipoCalculo);     
            Console.ReadKey();
        }

        public static void EscogeForma(string tipoCalculo)
        {
            Console.WriteLine("----- Escoge una forma 2D -----\n" +
                              "\n\t[1] Triángulo" +
                              "\n\t[2] Rectángulo" +
                              "\n\t[3] Cuadrado" +
                              "\n\t[4] Rombo" +
                              "\n\t[5] Elipse" +
                              "\n\t[6] Circulo" +
                              "\n\t[5] Xpoligono");
            string formaEscogida = Console.ReadLine();

            switch (formaEscogida)
            {
                case "1": // Triángulo
                    double lado1 = PedirValor("Lado 1");
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
                case "3": // Cuadrado
                    double ladoCuadrado = PedirValor("Lado");
                    
                    Cuadrado cuadrado1 = new Cuadrado(ladoCuadrado);
                    if (tipoCalculo == "1") // Área
                    {
                        cuadrado1.CalcularArea();

                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        cuadrado1.CalcularPerimetro();
                    }
                    break;
                case "4": // Rombo
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
                case "5": // Elipse
                    double radio1 = PedirValor("Radio 1");
                    double radio2 = PedirValor("Radio 2");

                    Elipse elipse1 = new Elipse(radio1, radio2);
                    if (tipoCalculo == "1") // Área
                    {
                        elipse1.CalcularArea();
                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        elipse1.CalcularPerimetro();
                    }
                    break;
                case "6": // Cirulo
                    double radioCirculo = PedirValor("Radio 1");
                    
                    Circulo circulo1 = new Circulo(radioCirculo);
                    if (tipoCalculo == "1") // Área
                    {
                        circulo1.CalcularArea();

                    }
                    else if (tipoCalculo == "2") // Perímetro
                    {
                        circulo1.CalcularPerimetro();
                    }
                    break;
                case "7": // Xpoligono
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
        //public static void EscogePoligono(string tipoCalculo)
        //{
        //    Console.WriteLine("----- Escoge un polígono -----\n" +
        //                      "\n\t[1] Triángulo" +
        //                      "\n\t[2] Rectángulo" +
        //                      "\n\t[3] Rombo" +
        //                      "\n\t[4] Xpoligono");
        //    string poligonoEscogido = Console.ReadLine();

        //    switch (poligonoEscogido)
        //    {
        //        case "1": // Triángulo
        //            double lado1 = PedirValor("Lado1 1");
        //            double lado2 = PedirValor("Lado 2");
        //            double lado3 = PedirValor("Lado 3");
                
        //            Triangulo triangulo1 = new Triangulo(lado1, lado2, lado3);
        //            if (tipoCalculo == "1") // Área
        //            {
        //                triangulo1.CalcularArea();

        //            }
        //            else if (tipoCalculo == "2") // Perímetro
        //            {
        //                triangulo1.CalcularPerimetro();
        //            }
        //            break;
        //        case "2": // Rectángulo
        //            double base1 = PedirValor("Base");
        //            double altura = PedirValor("Altura");

        //            Rectangulo rectangulo1 = new Rectangulo(base1, altura);
        //            if (tipoCalculo == "1") // Área
        //            {
        //                rectangulo1.CalcularArea();

        //            }
        //            else if (tipoCalculo == "2") // Perímetro
        //            {
        //                rectangulo1.CalcularPerimetro();
        //            }
        //            break;
        //        case "3": // Rombo
        //            double diagonal1 = PedirValor("Diagonal 1");
        //            double diagonal2 = PedirValor("Diagonal 2");
        //            Rombo rombo1 = new Rombo(diagonal1, diagonal2);
        //            if (tipoCalculo == "1") // Área
        //            {
        //                rombo1.CalcularArea();

        //            }
        //            else if (tipoCalculo == "2") // Perímetro
        //            {
        //                rombo1.CalcularPerimetro();
        //            }
        //            break;
        //        case "4": // Xpoligono
        //            int numLados = (int)PedirValor("Numero de lados");
        //            double lado = PedirValor("Lado ");
        //            Xpoligono xpoligono1 = new Xpoligono(numLados, lado);
        //            if (tipoCalculo == "1") // Área
        //            {
        //                xpoligono1.CalcularArea();

        //            }
        //            else if (tipoCalculo == "2") // Perímetro
        //            {
        //                xpoligono1.CalcularPerimetro();
        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Selección no válida.");
        //            break;
        //    }
        //}
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

        //public static void CrearDiagrama()
        //{
        //    Console.WriteLine("Cuantas formas quieres?");
        //    int rnd = Next.Random(0, 50);
        //}
        
    }
}

