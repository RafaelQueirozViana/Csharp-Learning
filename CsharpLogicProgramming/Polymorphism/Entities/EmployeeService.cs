public static class EmployeeService {
    public static List<Employee> Employees { get; private set; } = [];

    public static void AddEmployee(Employee employeeToAdd) {
        Employees.Add(employeeToAdd);
    }

}