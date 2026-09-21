namespace WorkerSalesIncome {
    internal class Program {
        static void Main(string[] args) {
            string departmentName;
            string workerName;
            string workerLevel;
            double baseSalary;
            int totalContracts;

            Worker employee;

            System.Console.WriteLine("Enter department's name:");
            departmentName = Console.ReadLine();

            System.Console.WriteLine("Enter worker data:");

            System.Console.Write("Name: ");
            workerName = Console.ReadLine();

            System.Console.Write("Level (Junior/MidLevel/Senior): ");
            workerLevel = Console.ReadLine();

            System.Console.Write("Base Salary: ");
            baseSalary = double.Parse(Console.ReadLine());

            employee = new Worker(departmentName, workerName, workerLevel, baseSalary);



            System.Console.Write("How many contracts to this worker?");
            totalContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= totalContracts; i++) {
                System.Console.WriteLine($"Enter #${i} contract's data");
                System.Console.Write("Contract date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Duration (Hours): ");
                int duration = int.Parse(Console.ReadLine());

                Contract newContract = new Contract(contractDate, valuePerHour, duration);

                employee.AddContract(newContract);



            }


            System.Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");

            DateTime dateToSearch = DateTime.ParseExact(
                Console.ReadLine(),
                "MM/yyyy",
                null
            );


            string[] resultInfo = employee.CalculateIncome(dateToSearch);

            System.Console.WriteLine($"name: {resultInfo[0]}");
            System.Console.WriteLine($"Department: {resultInfo[1]}");
            System.Console.WriteLine($"Income for {dateToSearch}: {resultInfo[2]}");

















        }
    }
}
