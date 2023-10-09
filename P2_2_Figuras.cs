//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    // RECTANGULO
    Rectangulo  miRectangulo = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3, 3.9);
    Console.WriteLine(miRectangulo.ToString());
    Console.WriteLine("\tArea: " + miRectangulo.GetArea());

    // CIRCULO
    Circulo  miCirculo = new Circulo(Color.FromArgb(255, 230, 20, 30), 4);
    Console.WriteLine(miCirculo.ToString());
    Console.WriteLine("\tArea: " + miCirculo.GetArea());

    // TRIANGULO
    Triangulo  miTriangulo = new Triangulo(Color.FromArgb(255, 0, 20, 40), 3);
    Console.WriteLine(miTriangulo.ToString());
    Console.WriteLine("\tArea: " + miTriangulo.GetArea());

  }

}