public class Account
{

    public int Cpf { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public decimal Balance { get; private set; }

    public Account(int cpf, string name, int age, decimal balance)
    {
        Cpf = cpf;
        Name = name;
        Age = age;
        Balance = balance;
    }

    public override int GetHashCode()
    {
        return Cpf.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Account))
        {
            return false;
        }

        Account other = obj as Account;

        return Cpf.Equals(other.Cpf);

    }

    public override string ToString()
    {
        return $"{Cpf}, {Name}, Balance: ${Balance}";
    }

}