public class Invoice {
    public double BasicPayment { get; private set; }
    public double Tax { get; private set; }
    public double TotalPayment { get; private set; }

    public Invoice(double rentalAmount, double time) {
        BasicPayment = rentalAmount * time;
    }


}