public class Rental
{

    public Car Car { get; private set; }
    public DateTime PickupDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public double TotalCost { get; private set; }


    public Rental(Car car, DateTime pickupDate, DateTime returnDate)
    {
        Car = car;
        PickupDate = pickupDate;
        ReturnDate = returnDate;
    }

    public void CalculateCost()
    {
        TimeSpan totalTime = ReturnDate - PickupDate;
        TotalCost = (totalTime.Days * Car.PricePerDay) + (totalTime.Hours * Car.PricePerHour);
    }

    public override string ToString()
    {
        TimeSpan totalTime = ReturnDate - PickupDate;
        return $"Car: {Car.Model}, Pickup Date: {PickupDate}, Return Date: {ReturnDate}, Total Cost: {TotalCost} ({totalTime.Days} days and {totalTime.Hours} Hours)";
    }

}