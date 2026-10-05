public class Worker {
    public string Name { get; private set; }
    public int Age { get; private set; }

    public double Salary { get; private set; }

    public Worker(string name, int age, double salary) {
        Name = name;
        Age = age;
        Salary = salary;
    }



}