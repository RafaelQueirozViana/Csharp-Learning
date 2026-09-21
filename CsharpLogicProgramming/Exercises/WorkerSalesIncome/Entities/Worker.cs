public class Worker {

    public string Department { get; private set; }
    public string Name { get; private set; }
    public string Level { get; private set; }
    public double BaseSalary { get; private set; }
    private List<Contract> _contractsList = [];

    public Worker(string department, string name, string level, double baseSalary) {
        Department = department;
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
    }

    public string[] CalculateIncome(DateTime searchDate) {

        List<Contract>? foundContractList = _contractsList.FindAll(contract =>
        contract.ContractDate.Month == searchDate.Month &&
        contract.ContractDate.Year == searchDate.Year);

        double contractsSum = 0;

        foreach (Contract currentContract in foundContractList) {
            contractsSum += currentContract.ValuePerHour * currentContract.Duration;
        }

        double incomeMoney = BaseSalary + contractsSum;


        return [Name, Department, "$" + incomeMoney.ToString()]
        ;
    }
    public void AddContract(Contract contractObj) {
        _contractsList.Add(contractObj);
    }
}