public class Employee {
    public string Name { get; private set; }
    public double WorkedHours { get; private set; }
    public double ValuePerHour { get; private set; }

    public Employee(string name, double workedHours, double valuePerHour) {
        Name = name;
        WorkedHours = workedHours;
        ValuePerHour = valuePerHour;
    }

    public virtual double TotalPayment() {
        double totalToPay = WorkedHours * ValuePerHour;
        return totalToPay;
    }

    public string ShowInfo() {
        return $"{Name} - $ {TotalPayment()}";
    }


}