public class PaymentFeeService : IPaymentFee
{
    public double GetFee(double amount)
    {
        return amount * 0.02;
    }
}