public class EmployeesService {
    public static List<Employee> EmployeesList { get; private set; } = [];


    public static void RegisterEmployee(Employee employee) {
        EmployeesList.Add(employee);
    }

    public static string IncreaseSalaryById(int id, double percentage) {
        string message;

        Employee? matchEmployee = EmployeesList.Find(employee => employee.Id == id);

        if (matchEmployee != null) {
            matchEmployee.IncreaseSalary(percentage);
            message = "Increassed Succesfully!";
        }

        else {
            message = "this id wasn't found";
        }

        return message;
    }


}