using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AreaRetangulo
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * Largura + 2 * Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return $"ÁREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\nPERÍMETRO = {Perimetro().ToString("F2",CultureInfo.InvariantCulture)}\nDIAGONAL = {Diagonal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
