﻿//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    // MI LISTA DE FIGURAS
    List<Figura> lista_figuras = new List<Figura>();

    // RECTANGULO
    Rectangulo  miRectangulo = new Rectangulo(Color.FromArgb(255, 50, 20, 34), 3, 3.9);
    Console.WriteLine(miRectangulo.ToString());
    Console.WriteLine("\tArea: " + miRectangulo.GetArea());
    // añado a la lista de figuras
    lista_figuras.Add(miRectangulo);

    // CIRCULO
    Circulo  miCirculo = new Circulo(Color.FromArgb(255, 230, 20, 30), 4);
    Console.WriteLine(miCirculo.ToString());
    Console.WriteLine("\tArea: " + miCirculo.GetArea());
    // añado a la lista de figuras
    lista_figuras.Add(miCirculo);

    // TRIANGULO
    Triangulo  miTriangulo = new Triangulo(Color.FromArgb(255, 0, 20, 40), 3);
    Console.WriteLine(miTriangulo.ToString());
    Console.WriteLine("\tArea: " + miTriangulo.GetArea());
    // añado a mi lista de figuras
    lista_figuras.Add(miTriangulo);

    // Más figuras para añadir a la lista
    Rectangulo miRectangulo2 = new Rectangulo(Color.FromArgb(255, 20, 200, 40), 4.5, 8);
    Circulo miCirculo2 = new Circulo(Color.FromArgb(0, 10, 50, 180), 6);
    Triangulo miTriangulo2 = new Triangulo(Color.FromArgb(250, 5, 45, 250), 2.8, 9);
    lista_figuras.Add(miRectangulo2);
    lista_figuras.Add(miCirculo2);
    lista_figuras.Add(miTriangulo2);

    // Bucle para mostrar las figuras de la lista
    Console.WriteLine("\n________________\nLISTA DE FIGURAS");
    foreach (var figura in lista_figuras)
    {
      Console.WriteLine(figura.ToString());
      Console.WriteLine("\tArea: " + figura.GetArea());
    }

  }

}