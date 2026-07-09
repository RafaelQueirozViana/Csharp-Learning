
namespace ConsoleApp1 {

    class Program {

        static void Main(string[] args) {

            Triangle triangle1 = new Triangle();
            Triangle triangle2 = new Triangle();

            Console.WriteLine("type the triangle 1 sizes");
            triangle1.sizeA = double.Parse(Console.ReadLine());
            triangle1.sizeB = double.Parse(Console.ReadLine());
            triangle1.sizeC = double.Parse(Console.ReadLine());


            Console.WriteLine("type the triangle 2 sizes");
            triangle2.sizeA = double.Parse(Console.ReadLine());
            triangle2.sizeB = double.Parse(Console.ReadLine());
            triangle2.sizeC = double.Parse(Console.ReadLine());

            Console.WriteLine(triangle1.GetArea());
            Console.WriteLine(triangle2.GetArea());

        }
    }
}