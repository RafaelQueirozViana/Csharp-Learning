public class Rental
{
    public int Id;
    public Car Car { get; private set; }
    public DateTime PickupDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public double BaseCost { get; private set; }
    public double TotalCost { get; private set; }
    public string RenterName { get; private set; }
    public ReturnCondition ReturnedCondition { get; private set; } // Same condition by default


    public Rental(Car car, string renterName, DateTime pickupDate, DateTime returnDate)
    {
        Car = car;
        RenterName = renterName;
        PickupDate = pickupDate;
        ReturnDate = returnDate;
    }

    public void CalculateCost(ReturnCondition condition, double? repairPrice)
    {
        TimeSpan totalTime = ReturnDate - PickupDate;

        ReturnedCondition = condition;
        BaseCost = (totalTime.Days * Car.PricePerDay) + (totalTime.Hours * Car.PricePerHour);
        TotalCost = BaseCost + (repairPrice.HasValue ? repairPrice.Value : 0);
    }

    public override string ToString()
    {
        TimeSpan totalTime = ReturnDate - PickupDate;
        return $"Car: {Car.Model}, Pickup Date: {PickupDate}, Return Date: {ReturnDate}, Total Cost: {BaseCost} ({totalTime.Days} days and {totalTime.Hours} Hours)";
    }

}