using Classes;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            Product product1 = new Product();

            Console.WriteLine("Put your product details");

            Console.WriteLine("Put the name");
            product1.name = Console.ReadLine();

            Console.WriteLine("Put the price");
            product1.price = double.Parse(Console.ReadLine());

            Console.WriteLine("Put the stock");
            product1.quantity = int.Parse(Console.ReadLine());

          

            Console.WriteLine("type the number of products to being added to stock");
            product1.increaseProduct(int.Parse(Console.ReadLine()));

          


            Console.WriteLine("type the number of products to being removed to stock");
            product1.decreaseProduct(int.Parse(Console.ReadLine()));

    



          












            // ==== Exercise 1 - Worker Exercise







            // ==== Exercise 2 - Person Exercise


            //Person person1 = new Person();
            //Person person2 = new Person();

            //Console.WriteLine("Type the first person's name");
            //person1.name = Console.ReadLine();

            //Console.WriteLine("Type the first person's age");
            //person1.age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Type the second person's name");
            //person2.name = Console.ReadLine();

            //Console.WriteLine("Type the second person's age");
            //person2.age = int.Parse(Console.ReadLine());

            //if (person1.age > person2.age) {
            //    Console.WriteLine($"The {person1.name} is the older");
            //}

            //else if (person1.age < person2.age) {
            //    Console.WriteLine($"The {person2.name} is the older");
            //}

            //else {
            //    Console.WriteLine($"The both {person1.name} and {person2.name} have the same age");
            //}



            // ==== Exercise 3

            //string choosedOperation;
            //double number1;
            //double number2;
            //bool continueRunning = true;

            //Calculator calculator = new Calculator();

            //Console.WriteLine("type the first number");
            //number1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("type the second number");
            //number2 = double.Parse(Console.ReadLine());

            //while (continueRunning == true) {
            //    continueRunning = false;

            //    Console.WriteLine("Choose one operation: sum, subtract, multiply or divide");
            //    choosedOperation = Console.ReadLine().ToLower();

            //    if (choosedOperation == "sum") {
            //        Console.WriteLine($"The sum result is {calculator.sumNumbers(number1, number2)}");
            //    }

            //    else if (choosedOperation == "subtract") {


            //    }
            //    else if (choosedOperation == "multiply") {

            //    }

            //    else if (choosedOperation == "divide") {

            //    }

            //    else {
            //        Console.WriteLine("Choose a valid operation first");
            //        continueRunning = true;
            //    }
            //}
            //}
        }
    }
}