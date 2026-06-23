using Classes;
using System;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {

            string choosedOperation;
            double number1;
            double number2;
            bool continueRunning = true;

            Calculator calculator = new Calculator();

            Console.WriteLine("type the first number");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("type the second number");
            number2 = double.Parse(Console.ReadLine());

           



            while (continueRunning == true) {
                continueRunning = false;

                Console.WriteLine("Choose one operation: sum, subtract, multiply or divide");
                choosedOperation = Console.ReadLine().ToLower();

                if (choosedOperation == "sum") {
                    Console.WriteLine($"The sum result is {calculator.sumNumbers(number1, number2)}");
                }

                else if (choosedOperation == "subtract") {


                }
                else if (choosedOperation == "multiply") {

                }

                else if (choosedOperation == "divide") {

                }

                else {
                    Console.WriteLine("Choose a valid operation first");
                    continueRunning = true;
                }



            }




           







            }

      


    }
}