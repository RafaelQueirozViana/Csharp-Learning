public class SavingsAccount : Account {

    public double InterestRate;
    public SavingsAccount(int number, string holder, double initialBalance, double interestRate) : base(number, holder, initialBalance) {
        InterestRate = interestRate;
    }

    public void UpdateBalance(double amount) {
        Balance += amount * InterestRate;
    }

    public override void WithDraw(double amount) {
          Balance -= amount;
    }







}