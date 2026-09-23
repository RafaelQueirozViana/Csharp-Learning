

namespace employeesRegister {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("How many employees will be registered?");
            int numberToRegister = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberToRegister; i++) {
                System.Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Name:");
                string name = Console.ReadLine();

                System.Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine());

                Employee employeeObject = new Employee(id, name, salary);

                EmployeesService.RegisterEmployee(employeeObject);
            }

            System.Console.WriteLine("Type the employee id that will have salary increase");
            int idToIncrease = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Type the percentage to increase");
            double percentageToIncrease = double.Parse(Console.ReadLine());

            string message = EmployeesService.IncreaseSalaryById(idToIncrease, percentageToIncrease);

            System.Console.WriteLine(" ");

            System.Console.WriteLine(message);

            System.Console.WriteLine(" ");

            System.Console.WriteLine("Registered Employees: ");

            foreach (Employee employee in EmployeesService.EmployeesList) {
                System.Console.WriteLine($"{employee.Id}, {employee.Name}, ${employee.Salary},");
            }






        }

    }
}
