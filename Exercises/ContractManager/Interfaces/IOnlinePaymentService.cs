public interface IOnlinePaymentService
{
    double GetTax(double amount, int mounth);
    double GetFee(double amount);

}