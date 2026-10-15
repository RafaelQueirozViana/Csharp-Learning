public abstract class AbstractShape : IShape {
    public Color Color { get; set; }

    public AbstractShape(Color color) {
        Color = color;
    }
    public abstract double Area();

    public override string ToString() {
        return $"{Color}";
    }
}