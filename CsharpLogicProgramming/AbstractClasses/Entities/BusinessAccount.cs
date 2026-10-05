public class BusinessAccount : Account {

    public double LoanLimit;
    public BusinessAccount(int number, string holder, double initialBalance, double loanLimit) : base(number, holder, initialBalance) {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount) {
        if (amount <= LoanLimit) {
            Balance += amount;

        }
    }


}