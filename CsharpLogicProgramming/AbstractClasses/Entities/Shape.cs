using System.Drawing;

public abstract class Shape {

    public Color Color { get; private set; }

    public Shape(Color pickedColor) {
        Color = pickedColor;
    }

    public abstract double Area();


}