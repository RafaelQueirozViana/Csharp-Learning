public class Rental
{
    public string RenterName { get; private set; }
    public Car Car { get; private set; }
    public DateTime PickupDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public double BaseCost { get; private set; }
    public double TotalCost { get; private set; }
    public ReturnCondition ReturnedCondition { get; private set; } // Same condition by default


    public Rental(Car car, string renterName, DateTime pickupDate, DateTime returnDate)
    {
        TimeSpan totalTime = ReturnDate - PickupDate;

        RenterName = renterName;
        Car = car;
        PickupDate = pickupDate;
        ReturnDate = returnDate;
        BaseCost = (totalTime.Days * Car.PricePerDay) + (totalTime.Hours * Car.PricePerHour);

    }

    public void CheckoutRental(ReturnCondition condition, double? repairPrice)
    {
        ReturnedCondition = condition;
        TotalCost = BaseCost + (repairPrice.HasValue ? repairPrice.Value : 0);
    }

    public override string ToString()
    {
        TimeSpan totalTime = ReturnDate - PickupDate;
        bool isConcluded = ReturnedCondition != ReturnCondition.NotReturnedYet;

        if (isConcluded)
        {
            return $"Car: {Car.Model}, Renter: {RenterName}, Pickup Date: {PickupDate}, Return Date: {ReturnDate}, Total Cost: ${TotalCost} ({totalTime.Days} days and {totalTime.Hours} Hours), Return State: {ReturnedCondition}";
        }

        else
        {
            return $"Car: {Car.Model}, Pickup Date: {PickupDate}, Return Date: {ReturnDate}, Base Cost: ${BaseCost}, ({totalTime.Days} days and {totalTime.Hours} Hours)";
        }
    }

}