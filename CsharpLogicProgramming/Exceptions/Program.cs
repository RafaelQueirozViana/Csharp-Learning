
namespace Exceptions {
    internal class Program {
        static void Main(string[] args) {
            List<int> rgList = [222, 333, 444];

            System.Console.WriteLine("Party System");

            System.Console.Write("Type your name: ");
            string name = Console.ReadLine();

            System.Console.Write("Type your age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Type your RG: ");
            int rg = int.Parse(Console.ReadLine());

            try {
                Person person = new Person(name, age, rg);

                System.Console.WriteLine(person.CheckEntry(rgList));
            }
            catch (DomainException e) {
                System.Console.WriteLine("Error: " + e.Message);
            }



        }

    }
}


