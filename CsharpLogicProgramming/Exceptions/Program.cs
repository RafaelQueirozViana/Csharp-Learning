
namespace Exceptions {
    internal class Program {
        static void Main(string[] args) {

            try {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                System.Console.WriteLine(n1 / n2);
            }

            catch (DivideByZeroException e) {
                System.Console.WriteLine("divide by zero error: " + e.Message);
            }

            catch (FormatException e) {
                System.Console.WriteLine("Format error: " + e.Message);
            }





        }

    }
}


