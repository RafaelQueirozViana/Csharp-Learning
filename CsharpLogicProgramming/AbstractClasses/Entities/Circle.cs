public class Circle : Shape {
    public double Radius { get; private set; }
    public Circle(Color pickedColor, double radius) : base(pickedColor) {
        Radius = radius;
    }

    public override double Area() {
        return 3.14 * (Radius * Radius);
    }
}