using System.Drawing;
using P2_2_Figuras;

class Circulo : Figura {
    private double _radio;
    private double _Pi = 3.14; 

    public Circulo(Color color, double radio)
    {
        base._color = color;
        _radio = radio;
    }
    public override double GetArea() => _Pi * Math.Pow(_radio, 2);
    public override string ToString() => "\nCirculo:\n\t" + _color + "\n\tRadio:" + _radio;
}