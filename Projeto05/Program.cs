using System;
using System.Globalization;

namespace Projeto05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            Console.WriteLine("Insira a altura do Triângulo; ");
            tri.Altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a largura do Triângulo; ");
            tri.Largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área; " + tri.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro; " + tri.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal; " + tri.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
