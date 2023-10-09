using System.Drawing;

namespace P2_2_Figuras;

internal abstract class Figura
{
  public string _name = "";
  protected Color _color;
  public abstract double GetArea();
}