
using System.Security.Cryptography.X509Certificates;

namespace IComparableInterfaces {
    internal class Program {
        static void Main(string[] args) {

            try {
                PrintService<string> printService = new PrintService<string>();


                System.Console.WriteLine("Type 3 texts between 1 and 10");

                for (int i = 1; i <= 3; i++) {
                    System.Console.Write($"Text {i}: ");
                    string number = Console.ReadLine();
                    printService.AddValue(number);
                }

                System.Console.WriteLine("First Text:" + printService.First());
                printService.Print();
            }

            catch (Exception e) {
                System.Console.WriteLine("Unexpected exception: " + e.Message);
            }




        }
    }
}
