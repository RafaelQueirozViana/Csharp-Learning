
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Write 3 numbers in the same line to comapare");

            string[] numbers = Console.ReadLine().Split(" ");

            int number1 = int.Parse(numbers[0]);
            int number2 = int.Parse(numbers[1]);
            int number3 = int.Parse(numbers[2]);

            int result = greater(number1, number2, number3);


            System.Console.WriteLine(result);

        }

        static int greater(int num1, int num2, int num3)
        {
            int greaterNumber;
            if (num1 > num2 && num1 > num2) 
            {
                greaterNumber = num1;
            }

            else if(num2 >= num1 && num2 > num3)
            {
                greaterNumber = num2;
            }

            else
            {
                greaterNumber = num3;
            }

            return greaterNumber;
        }




    }
}


