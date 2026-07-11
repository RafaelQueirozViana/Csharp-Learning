namespace BankAccountExercise {
    internal class Account {

        private string _titularName;
        public int AccountNumber { get; private set; }
        public double AccountBalance { get; private set; }

        public Account(int accountNumber, string holderName) {
            AccountNumber = accountNumber;
            _titularName = holderName;

        }

        public Account(int accountNumber, string holderName, double initialBalance) : this(accountNumber, holderName) {
            AccountBalance = initialBalance;
        }



        public string TitularName {
            get { return _titularName; }
            set {
                if (value != null && value.Length > 2) {
                    _titularName = value;
                }
            }
        }



        public void depositToAccount(double money) {
            AccountBalance += money;

        }


        public void withdrawToAccount(double money) {
            AccountBalance -= money;
        }

        public string getAccountInfo() {
            return $"Account {AccountNumber}, Titular: {_titularName}, Balance: ${AccountBalance} ";
        }




    }
}
