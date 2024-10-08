﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPoligonos
{
    internal abstract class Poligono : Formas2D
    {
        public int NumLados;
        public Poligono(int numLados) 
        {
            this.NumLados = numLados;
        }
        public override string ToString()
        {
            return "Poligono de " + NumLados; 
        }
    }
}
