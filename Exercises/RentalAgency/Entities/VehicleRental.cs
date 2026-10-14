public class VehicleRental
{
    public DateTime PickupDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public Vehicle Vehicle { get; private set; }
    public Invoice Invoice { get; set; }

    public VehicleRental(DateTime pickupDate, DateTime returnDate, Vehicle vehicle)
    {
        if (returnDate < pickupDate) throw new DomainException("The return date must be after the pickup date!");

        PickupDate = pickupDate;
        ReturnDate = returnDate;
        Vehicle = vehicle;
        Invoice = null;
    }

    public override string ToString()
    {
        return "Basic Payment: $ " + Invoice.BasicPayment + "\n Tax: $" + Invoice.Tax + "\n Total Payment: $" + Invoice.TotalPayment;
    }
}

