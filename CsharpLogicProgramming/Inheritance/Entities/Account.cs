public class Account {
    public int Number { get; protected set; }
    public string Holder { get; protected set; }

    public double Balance { get; protected set; }

    public Account(int number, string holder, double initialBalance) {
        Number = number;
        Holder = holder;
        Balance = initialBalance;
    }

    public virtual void WithDraw(double amount) {
        Balance -= amount + 5.0;
    }

    public void Deposit(double amount) {
        Balance += amount;
    }

}