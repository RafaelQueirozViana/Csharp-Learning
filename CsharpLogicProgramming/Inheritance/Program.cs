using System.Linq.Expressions;

namespace Inheritance {
    internal class Program {
        static void Main(string[] args) {
            BusinessAccount account = new BusinessAccount(222, "pedro", 40000.99, 3000);
            System.Console.WriteLine(account.ShowInfo());

            // UPCASTING

            Account account1 = new BusinessAccount(12, "pedro", 5000.45, 3000);
            Account account2 = new SavingsAccount(23, "nicolas", 3000.68, 0.33);


            // DOWNCASTING

            BusinessAccount account3 = (BusinessAccount)account1;







        }
    }
}
