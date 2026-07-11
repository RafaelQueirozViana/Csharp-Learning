namespace BankAccountExercise {
    internal class Account {

        private int _accountNumber;
        public string TitularName { get; private set; }
        public double AccountBalance { get; private set; }

        public Account(int accountNumber, string holderName) {
            _accountNumber = accountNumber;
            TitularName = holderName;

        }

        public Account(int accountNumber, string holderName, double initialBalance) {
            _accountNumber = accountNumber;
            TitularName = holderName;
            AccountBalance = initialBalance;

        }

        public void depositToAccount(double money) {
            AccountBalance += money;

        }


        public void withdrawToAccount(double money) {

            if (AccountBalance - money >= 0) {
                AccountBalance -= money;

            }


        }

        public string getAccountInfo() {
            return $"Account {_accountNumber}, Titular: {TitularName}, Balance: ${AccountBalance} ";
        }




    }
}
