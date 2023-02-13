﻿using System;

namespace Projeto05
{
    internal class Triangulo
    {
        public double Largura;
        public double Altura;
        public double Area(){
            return Largura * Altura;
        }
        public double Perimetro(){
            return 2 * (Largura + Altura);
        }
        public double Diagonal(){
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
