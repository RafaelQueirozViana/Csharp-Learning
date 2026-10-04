using System.Linq.Expressions;

namespace Inheritance {
    internal class Program {
        static void Main(string[] args) {


            Account acc1 = new Account(1001, "alex", 300);
            SavingsAccount acc2 = new SavingsAccount(1001, "alex", 300, 0.1);
            acc1.WithDraw(100);
            acc2.WithDraw(100);

            System.Console.WriteLine(acc1.Balance);
            System.Console.WriteLine(acc2.Balance);






        }
    }
}
