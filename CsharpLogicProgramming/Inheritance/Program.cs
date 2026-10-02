namespace Inheritance {
    internal class Program {
        static void Main(string[] args) {
            BusinessAccount account = new BusinessAccount(222, "pedro", 40000.99, 3000);
            System.Console.WriteLine(account.ShowInfo());




        }
    }
}
