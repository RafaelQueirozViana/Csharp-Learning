public class RentalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    public RentalService(double pricePerHour, double pricePerDay)
    {

        if (pricePerHour <= 0 || pricePerDay <= 0)
        {
            throw new DomainException("The Price/hour or Price/day can't be less or equal than 0");
        }

        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public void ProcessRental(VehicleRental vehicleRental)
    {
        double basicPayment = 0.0;

        TimeSpan duration = vehicleRental.ReturnDate - vehicleRental.PickupDate;

        if (duration.TotalHours < 12)
        {
            basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
        }
        else
        {
            basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
        }

        double tax = new BrazilTaxService().GetTax(basicPayment);

        vehicleRental.Invoice = new Invoice(basicPayment, tax);
    }
}