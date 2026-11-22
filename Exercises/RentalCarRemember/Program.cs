namespace RentalCarRemember;

class Program
{
    static void Main()
    {

        List<Rental> activeRentals = [];
        List<Rental> concludedRentals = [];

        System.Console.WriteLine("====== Fill this form data to register a new rental ======");

        System.Console.WriteLine("Enter car rental data: ");

        System.Console.Write("Enter the car's model: ");
        string model = Console.ReadLine();

        System.Console.Write("Enter the car's color: ");
        Color color = Enum.Parse<Color>(Console.ReadLine());

        System.Console.Write("Enter the name of the renter person ");
        string renterName = Console.ReadLine();

        System.Console.Write("Pickup (dd/MM/yyyy hh:mm) ");
        DateTime pickupDate = DateTime.Parse(Console.ReadLine());

        System.Console.Write("Return (dd/MM/yyyy hh:mm) ");
        DateTime returnDate = DateTime.Parse(Console.ReadLine());

        System.Console.Write("Enter price per hour: $");
        double pricePerHour = double.Parse(Console.ReadLine());

        System.Console.Write("Enter price per day: $");
        double pricePerDay = double.Parse(Console.ReadLine());

        Car rentalCar = new Car(model, color, pricePerHour, pricePerDay);

        RentalService rentalService = new RentalService(activeRentals, concludedRentals);

        rentalService.CreateRental(rentalCar, renterName, pickupDate, returnDate);

        System.Console.WriteLine("Active Rentals:");

        ShowRentals(activeRentals);

        System.Console.WriteLine("");

        System.Console.WriteLine("Concluded Rentals:");
        ShowConcludedRentals(concludedRentals);

    }

    public static void ShowRentals(List<Rental> rentals)
    {
        foreach (Rental rental in rentals)
        {
            System.Console.WriteLine(rental.ToString());
        }
    }

    public static void ShowConcludedRentals(List<Rental> concludedRentals)
    {
        foreach (Rental rental in concludedRentals)
        {
            System.Console.WriteLine(rental.ToString());
        }
    }


}