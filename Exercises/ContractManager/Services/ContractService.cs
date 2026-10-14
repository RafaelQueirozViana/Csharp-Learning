using System.Buffers.Text;

public class ContractService
{
    private ISimpleInterest _simpleInterestService;
    private IPaymentFee _paymentFeeService;

    public ContractService(ISimpleInterest simpleInterestService, IPaymentFee paymentFeeService)
    {
        _simpleInterestService = simpleInterestService;
        _paymentFeeService = paymentFeeService;
    }

    public void ProcessInstallments(Contract contract, int InstallmentTotal)
    {
        double BasicValue = contract.TotalValue / InstallmentTotal;

        for (int i = 1; i <= InstallmentTotal; i++)
        {
            double simpleInterestTax = _simpleInterestService.GetTax(BasicValue, i);
            double subtotal = BasicValue + simpleInterestTax;
            double paymentFee = _paymentFeeService.GetFee(subtotal);

            DateTime dueDate = contract.ContractDate.AddMonths(i);
            Installment installment = new Installment(dueDate, BasicValue, simpleInterestTax, paymentFee);

            contract.InstallmentsList.Add(installment);
        }
    }
}