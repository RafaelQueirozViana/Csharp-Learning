public class Contract
{
    public int Number { get; private set; }
    public DateTime ContractDate { get; private set; }
    public double TotalValue { get; private set; }
    public List<Installment> InstallmentsList { get; private set; }



    public Contract(int number, DateTime contractDate, double totalValue)
    {
        Number = number;
        ContractDate = contractDate;
        TotalValue = totalValue;
        InstallmentsList = [];
    }


}