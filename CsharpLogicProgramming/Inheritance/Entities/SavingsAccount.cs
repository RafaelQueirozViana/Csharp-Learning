using System.Security.Cryptography.X509Certificates;

public class SavingsAccount : Account {
    public double InterestRate = 0.26;

    public SavingsAccount(int number, string holder, double balance) : base(number, holder, balance) {

    }



    public void UpdateBalance() {
        Balance += Balance * InterestRate;
    }
}
