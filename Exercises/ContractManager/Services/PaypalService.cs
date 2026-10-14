public class PaypalService : IOnlinePaymentService
{

    public double GetTax(double amount, int mounth)
    {
        return amount * (0.01 * mounth);
    }
    public double GetFee(double amount)
    {
        return amount * 0.02;
    }


}