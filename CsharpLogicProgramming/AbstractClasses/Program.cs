
using System.Drawing;

namespace AbstractClasses {
    internal class Program {
        static void Main(string[] args) {

            System.Console.WriteLine("Enter the number of shapes:");
            int repeatTimes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= repeatTimes; i++) {

                System.Console.WriteLine("");
                System.Console.WriteLine($"Shape {i} Data:");
                System.Console.WriteLine("");

                System.Console.Write("Color of shape: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                System.Console.WriteLine("Which type of shape?");
                System.Console.Write("Circle, Rectangle (c/r): ");
                char shapeType = char.Parse(Console.ReadLine().ToLower());

                if (shapeType == 'c') {
                    System.Console.Write("Type the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    ShapeService.AddShape(new Circle(color, radius));
                }

                else if (shapeType == 'r') {
                    System.Console.Write("Type the width of the rectangle: ");
                    double width = double.Parse(Console.ReadLine());

                    System.Console.Write("Type the height of the rectangle: ");
                    double height = double.Parse(Console.ReadLine());
                    ShapeService.AddShape(new Rectangle(color, width, height));
                }

                else {
                    System.Console.WriteLine("Error, invalid option choosed");
                }
            }

            System.Console.WriteLine("===== Shape Areas =====");
            foreach (Shape currentShape in ShapeService.ShapesList) {
                System.Console.WriteLine(currentShape.Area());
            }

        }
    }
}
