using System.Drawing;
using P2_2_Figuras;

class Rectangulo : Figura {
    private double _alto;
    private double _ancho;
    public Rectangulo(string name, Color color, double alto, double ancho)
    {
        base._name = name;
        base._color = color;
        _alto = alto;
        _ancho = ancho;
    }
    public override double GetArea() => _alto * _ancho;
    public override string ToString() => "\n"+ _name +":\n\t" + _color + "\n\tAlto: " + _alto + "\n\tAncho: " + _ancho;
}