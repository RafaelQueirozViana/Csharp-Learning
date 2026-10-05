namespace Polymorphism {
    internal class Program {
        static void Main(string[] args) {

            System.Console.WriteLine("==== Register employees or outsourced employees =====");
            System.Console.WriteLine("How many employees do you wanna register?");

            int repeatTimes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= repeatTimes; i++) {


                System.Console.WriteLine("");

                System.Console.WriteLine($"Employee {i} data:");

                System.Console.WriteLine("");
                System.Console.WriteLine("");

                System.Console.Write("Outsourced (y/n)? ");
                char IsOutsourced = char.Parse(Console.ReadLine());

                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Worked hours: ");
                double workedHours = double.Parse(Console.ReadLine());

                System.Console.Write("Value/Hour: $");
                double valuePerHour = double.Parse(Console.ReadLine());

                Employee employee;

                if (IsOutsourced == 'y') {
                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employee = new OutsourcedEmployee(name, workedHours, valuePerHour, additionalCharge);
                }

                else {
                    employee = new Employee(name, workedHours, valuePerHour);
                }

                EmployeeService.AddEmployee(employee);


            }

            foreach (Employee employee in EmployeeService.Employees) {
                System.Console.WriteLine(employee.ShowInfo());
            }







        }
    }
}
