public class Rectangle : AbstractShape {
    public double Width;
    public double Height;

    public Rectangle(Color color, double width, double height) : base(color) {
        Width = width;
        Height = height;
    } 

    public override double Area() {
        return Width * Height;
    }
}