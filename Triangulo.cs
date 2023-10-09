using System.Drawing;
using P2_2_Figuras;

class Triangulo : Figura {
    private double _anchura;
    private double _altura;
    public Triangulo(Color color, double altura, double anchura)
    {
        base._color = color;
        _altura = altura;
        _anchura = anchura;
    }
    public Triangulo(Color color, double lado)
    {
        base._color = color;
        _altura = lado;
        _anchura = lado;
    }
    public override double GetArea() => (_altura * _anchura)/2;
    public override string ToString() => "\nTirangulo:\n\t" + _color + "\n\tAltura: " + _altura + "\n\tAnchura: " + _anchura;
}