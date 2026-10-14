public class RentalService
{

    private ITax _taxService;
    public RentalService(ITax taxService)
    {
        _taxService = taxService;
    }

    public void ProcessRental(VehicleRental vehicleRental, double PricePerHour, double PricePerDay)
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

        _taxService.GetTax(basicPayment);

        vehicleRental.Invoice = new Invoice(basicPayment, _taxService.GetTax(basicPayment));
    }
}