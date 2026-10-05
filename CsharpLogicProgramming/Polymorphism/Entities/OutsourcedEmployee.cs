public class OutsourcedEmployee : Employee {
    public double AdditionalCharge { get; private set; }

    public OutsourcedEmployee(string name, double workedHours, double valuePerHour, double additionalCharge) : base(name, workedHours, valuePerHour) {
        AdditionalCharge = additionalCharge;
    }

    public override double TotalPayment() {
        return base.TotalPayment() + (AdditionalCharge * 1.1);
    }



}