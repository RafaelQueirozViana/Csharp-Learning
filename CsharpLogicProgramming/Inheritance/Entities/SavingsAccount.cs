using System.Security.Cryptography.X509Certificates;

public class SavingsAccount : Account {
    public double InterestRate;

    public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {

    }



    public void UpdateBalance() {
        Balance += Balance * InterestRate;
    }
}
