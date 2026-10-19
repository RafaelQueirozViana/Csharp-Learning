
using System.Security.Cryptography.X509Certificates;

namespace IComparableInterfaces {
    internal class Program {
        static void Main(string[] args) {
            try {
                PrintService printService = new PrintService();


                System.Console.WriteLine("Type 3 numbers between 1 and 10");

                for (int i = 1; i <= 3; i++) {
                    System.Console.Write($"Number {i}: ");
                    int number = int.Parse(Console.ReadLine());
                    printService.AddValue(number);
                }

                System.Console.WriteLine("First number:" + printService.First());
                printService.Print();
            }

            catch (Exception e) {
                System.Console.WriteLine("Unexpected exception: " + e.Message);
            }




        }
    }
}
