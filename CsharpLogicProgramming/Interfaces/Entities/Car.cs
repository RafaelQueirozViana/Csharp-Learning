public class Car {
    public CarModel Model { get; private set; }
    public DateTime PickupDate { get; private set; }
    public DateTime ReturnDate { get; private set; }
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    public Car(CarModel model, DateTime pickupDate, DateTime returnDate, double pricePerHour, double pricePerDay) {
        Model = model;
        PickupDate = pickupDate;
        ReturnDate = returnDate;
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public double[] RentalDuration() {
        TimeSpan duration = ReturnDate - PickupDate;
        double[] vector = { Math.Ceiling(duration.TotalHours), Math.Ceiling(duration.TotalDays) };
        return vector;
    }

    public double GetBasicPayment() {
        double totalHours = RentalDuration()[0]; // [0] returning the duration in hours;
        double totalDays = RentalDuration()[1];  // [1] returning the duration in days

        if (totalHours > 12) {
            return PricePerDay * totalDays;
            System.Console.WriteLine(totalDays);
        }

        else {
            return PricePerHour * totalHours;
        }
    }

    public double GetTax() {
        if (GetBasicPayment() <= 100) {
            return 0.2 * GetBasicPayment();
        }

        else {
            return 0.15 * GetBasicPayment();
        }
    }

    public double GetTotalPayment() {
        return GetBasicPayment() + GetTax();
    }






}