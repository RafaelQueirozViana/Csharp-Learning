public class BrazilTaxService : ITax
{
    public double GetTax(double amount)
    {
        if (amount <= 100)
        {
            return amount * 0.20;
        }

        else
        {
            return amount * 0.15;
        }
    }


}