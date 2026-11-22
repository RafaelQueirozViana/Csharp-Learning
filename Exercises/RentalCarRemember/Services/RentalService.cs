public class RentalService
{
    public List<Rental> RentalsList { get; private set; }
    public List<Rental> OlderRentails { get; private set; }

    public RentalService(List<Rental> activeRentals, List<Rental> pastRentals)
    {
        RentalsList = activeRentals;
        OlderRentails = pastRentals;
    }

    public void CreateRental(Car car, string renterName, DateTime pickupDate, DateTime returnDate)
    {
        Rental rental = new Rental(car, renterName, pickupDate, returnDate);
        RentalsList.Add(rental);
    }

    public void CompleteRental(string renterName, ReturnCondition returnCondition, double? repairPrice = null)
    {
        Rental matchingRental = RentalsList.Find(rental => rental.RenterName == renterName);

        matchingRental.CheckoutRental(returnCondition, repairPrice);

        if (matchingRental == null)
        {
            throw new Exception("error: this name was not found, try using other name");
        }

        RentalsList.Remove(matchingRental);
        OlderRentails.Add(matchingRental);
    }

}
