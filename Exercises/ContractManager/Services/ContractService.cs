
public class ContractService
{
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
        _onlinePaymentService = onlinePaymentService;
    }

    public void ProcessInstallments(Contract contract, int months)
    {
        double BasicValue = contract.TotalValue / months;

        for (int i = 1; i <= months; i++)
        {
            double simpleInterestTax = _onlinePaymentService.GetTax(BasicValue, i);
            double subtotal = BasicValue + _onlinePaymentService.GetTax(BasicValue, i);
            double paymentFee = _onlinePaymentService.GetFee(subtotal);

            DateTime dueDate = contract.ContractDate.AddMonths(i);
            Installment installment = new Installment(dueDate, BasicValue, simpleInterestTax, paymentFee);

            contract.AddInstallment(installment);
        }
    }
}