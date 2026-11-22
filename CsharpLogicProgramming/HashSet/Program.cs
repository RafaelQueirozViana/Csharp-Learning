using System.Collections.ObjectModel;

namespace HashSet {
    internal class Program {
        static void Main(string[] args) {

            HashSet<Account> accounts = [new Account(23333233, "Pedro August", 19, 14000)];

            accounts.Add(new Account(23333233, "Pedro August", 19, 14000));

            PrintCollection<Account>(accounts);
        }

        public static void PrintCollection<T>(IEnumerable<T> collection) {

            if (collection is IEnumerable<Account>) {
                System.Console.WriteLine("yes");
                foreach (T value in collection) {
                    System.Console.WriteLine($"{value.ToString()}");
                }
            }
        }
    }


}
