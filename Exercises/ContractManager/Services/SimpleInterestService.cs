public class SimpleInterestService : ISimpleInterest
{
    public double GetTax(double amount, int mounth)
    {
        return amount * (0.01 * mounth);
    }
}