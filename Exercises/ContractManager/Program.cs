namespace ContractManager;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter contract data");
        System.Console.Write("Number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        System.Console.Write("Date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        System.Console.Write("Contract Value: ");
        double contractValue = double.Parse(Console.ReadLine());

        System.Console.Write("Enter number of installments: ");
        int installments = int.Parse(Console.ReadLine());

        Contract contract = new Contract(accountNumber, date, contractValue);
        ContractService contractService = new ContractService(new PaypalService());

        contractService.ProcessInstallments(contract, installments);

        System.Console.WriteLine("Installments:");


        foreach (Installment installment in contract.InstallmentsList)
        {
            System.Console.WriteLine(installment.ToString());
        }








    }
}