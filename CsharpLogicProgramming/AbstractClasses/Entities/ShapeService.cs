public static class ShapeService {
    public static List<Shape> ShapesList { get; private set; } = [];

    public static void AddShape(Shape figure) {
        ShapesList.Add(figure);
    }
}