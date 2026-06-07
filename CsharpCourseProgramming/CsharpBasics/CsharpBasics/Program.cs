using System;

namespace CsharpBasics {
    internal class Program {
        static void Main(string[] args) {

            //Exercise

            string completeName = Console.ReadLine();
            int bedrooms = int.Parse( Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            string[] phrase = Console.ReadLine().Split(" ");

            string lastName = phrase[0];
            int age = int.Parse( phrase[1]);
            double height = double.Parse(phrase[2]);


            // --- Displaying the result
            Console.WriteLine("\n--- Captured Information ---");
            Console.WriteLine($"Full Name: {completeName}");
            Console.WriteLine($"Bedrooms: {bedrooms}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
















            //int n1 = int.Parse(Console.ReadLine());

            //char genre = char.Parse(Console.ReadLine());

            //double dot = double.Parse(Console.ReadLine());

            //string[] phrase = Console.ReadLine().Split(" ");

            //string name = phrase[0];
            //char genrePhrase = char.Parse(phrase[1]);
            //int age = int.Parse(phrase[2]);
            //double height = double.Parse(phrase[3]);

            //Console.WriteLine($"you wrote {height}");













            //string[] phrase = Console.ReadLine().Split(" ");

            //string a = phrase[0];
            //string b = phrase[1];
            //string c = phrase[2];


            //Console.WriteLine($"{a} {b} {c}");
























            //double a = 1.0, b = -3.0, c = -4.0;
            //double delta = Math.Pow(b, 2) - 4 * a * c;
            //double result1 = (-b - Math.Sqrt(delta)) / (2 * a);
            //Console.WriteLine(delta);
            //Console.WriteLine(result1);



















        }
    }
}