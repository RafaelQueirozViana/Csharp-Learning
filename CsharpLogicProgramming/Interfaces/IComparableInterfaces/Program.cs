
namespace IComparableInterfaces {
    internal class Program {
        static void Main(string[] args) {
            List<Employee> employeesList = [new Employee("pedro", 3000), new Employee("pedro", 3000), new Employee("pedro", 3000)];


            employeesList.Sort();

            foreach (Employee employee in employeesList) {
                System.Console.WriteLine(employee);
              
            }


        }
    }
}
