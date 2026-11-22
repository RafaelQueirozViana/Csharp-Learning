public class RentalService
{
    public List<Rental> RentalsList { get; private set; }

    public RentalService(List<Rental> rentalsList)
    {
        RentalsList = rentalsList;
    }

    public void CreateRental(Car car, DateTime pickupDate, DateTime returnDate)
    {
        Rental rental = new Rental(car, pickupDate, returnDate);
        rental.CalculateCost();

        RentalsList.Add(rental);
    }

}
