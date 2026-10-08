namespace AbstractClasses {
    public class Rectangle : Shape {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(Color pickedColor, double width, double height) : base(pickedColor) {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }




    }




}


























