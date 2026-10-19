public class Employee : IComparable {
    public string Name { get; private set; }
    public decimal Salary { get; private set; }

    public Employee(string name, decimal salary) {
        Name = name;
        Salary = salary;
    }

    public override string ToString() {
        return $"{Name}, {Salary}";
    }
    public int CompareTo(object obj) {
        if (!(obj is Employee)) {
            throw new ArgumentException("Comparing error: argument is not an employee");
        }

        Employee other = obj as Employee;

        return Name.CompareTo(other.Name);
    }
}