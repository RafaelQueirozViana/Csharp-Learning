public class Installment
{

    public DateTime DueDate { get; private set; }
    public double BaseAmount { get; private set; }
    public double SimpleInterestTax { get; private set; }
    public double PaymentFee { get; private set; }
    public double TotalAmount { get; private set; }
    public Installment(DateTime dueDate, double baseAmount, double simpleInterestTax, double paymentFee)
    {
        DueDate = dueDate;
        BaseAmount = baseAmount;
        SimpleInterestTax = simpleInterestTax;
        PaymentFee = paymentFee;
        TotalAmount = baseAmount + simpleInterestTax + paymentFee;
    }

    public override string ToString()
    {
        return $"{DueDate} - Total: {TotalAmount} (Basic: ${BaseAmount},  Simple interest: ${SimpleInterestTax}, Payment fee: ${PaymentFee}) ";
    }
}