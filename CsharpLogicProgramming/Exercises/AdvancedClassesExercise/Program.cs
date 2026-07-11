namespace BankAccountExercise {
    internal class Program {
        static void Main(string[] args) {

            Account userAccount;


            Console.WriteLine("Enter the account number");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the account titular");
            string titularName = Console.ReadLine();

            Console.WriteLine("Will it have a initial deposit? (y / n)");
            char initialDeposit = char.Parse(Console.ReadLine());

            if (initialDeposit == 's') {
                Console.WriteLine("Enter with the initial deposit value");
                double initialValue = double.Parse(Console.ReadLine());
                userAccount = new Account(accountNumber, titularName, initialValue);
            }

            else {
                userAccount = new Account(accountNumber, titularName);
            }

            Console.WriteLine(userAccount.getAccountInfo());

            Console.WriteLine("Enter a value for deposit");
            double depositValue = double.Parse(Console.ReadLine());
            userAccount.depositToAccount(depositValue);
            Console.WriteLine(userAccount.getAccountInfo());


            Console.WriteLine("Enter a value for saque");
            double saqueValue = double.Parse(Console.ReadLine());
            userAccount.withdrawToAccount(saqueValue);


            Console.WriteLine(userAccount.getAccountInfo());

        }
    }
}
