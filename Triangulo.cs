using System.Drawing;
using P2_2_Figuras;

class Triangulo : Figura {
    private double _anchura;
    private double _altura;
    public Triangulo(string name, Color color, double altura, double anchura)
    {
        base._name = name;
        base._color = color;
        _altura = altura;
        _anchura = anchura;
    }
    public Triangulo(String name, Color color, double lado)
    {
        base._name = name;
        base._color = color;
        _altura = lado;
        _anchura = lado;
    }
    public override double GetArea() => (_altura * _anchura)/2;
    public override string ToString() => "\n"+ _name +":\n\t" + _color + "\n\tAltura: " + _altura + "\n\tAnchura: " + _anchura;
}