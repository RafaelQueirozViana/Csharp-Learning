
namespace AbstractClasses {
    internal class Program {
        static void Main(string[] args) {

            AccountService.AddAccount(new BusinessAccount(1212, "Pedro", 1000, 4000));
            AccountService.AddAccount(new BusinessAccount(1515, "Gabriel", 1000, 2000));



            AccountService.RemoveFromAllAccounts(10);


            System.Console.WriteLine(AccountService.GetTotalBalance());















        }
    }
}
