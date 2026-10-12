public class Account
{
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; private set; }
    private double _withdrawLimit;

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        _withdrawLimit = withdrawLimit;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void WithDraw(double amount)
    {
        if (Balance - amount < 0)
        {
            throw new DomainException("You don't have enough money in your balance to withdraw this quantity.");
        }

        if (amount > _withdrawLimit)
        {
            throw new DomainException("this withdraw amount is larger than your account limit.");
        }

        Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account {Number}, {Holder}, Balance: ${Balance}";
    }

}