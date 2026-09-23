public class Worker {

    public Department Department { get; private set; }
    public string Name { get; private set; }
    public WorkerLevel Level { get; private set; }
    public double BaseSalary { get; private set; }
    private List<Contract> ContractsList { get; set; } = [];

    public Worker(Department department, string name, WorkerLevel level, double baseSalary) {
        Department = department;
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
    }

    public string[] getIncome(DateTime searchDate) {
        double contractsSum = 0;

        foreach (Contract currentContract in ContractsList) {
            if(currentContract.Date.Month == searchDate.Month && currentContract.Date.Year == currentContract.Date.Year)
            contractsSum += currentContract.totalValue();
        }

        double incomeMoney = BaseSalary + contractsSum;


        return [Name, Department.DepartmentName, "$" + incomeMoney.ToString()]
        ;
    }
    public void AddContract(Contract contract) {
        ContractsList.Add(contract);
    }

    public void RemoveContract(Contract contract) {
        ContractsList.Remove(contract);
    }
}