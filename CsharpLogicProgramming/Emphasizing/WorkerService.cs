public class WorkerService {

    public static Worker getHigherSalary(Worker employee1, Worker employee2) {
        Worker higherSalaryEmployee;

        if (employee1.Salary >= employee2.Salary) {
            higherSalaryEmployee = employee1;
        }

        else {
            higherSalaryEmployee = employee2;
        }

        return higherSalaryEmployee;
    }
}