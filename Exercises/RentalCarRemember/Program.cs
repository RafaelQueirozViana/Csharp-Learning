namespace RentalCarRemember;

class Program
{
    static void Main()
    {

        List<Rental> rentalsList = [];

        System.Console.WriteLine("Enter car rental data: ");

        System.Console.Write("Enter the car's model: ");
        string model = Console.ReadLine();

        System.Console.Write("Enter the car's color: ");
        Color color = Enum.Parse<Color>(Console.ReadLine());

        System.Console.Write("Pickup (dd/MM/yyyy hh:mm) ");
        DateTime pickupDate = DateTime.Parse(Console.ReadLine());

        System.Console.Write("Return (dd/MM/yyyy hh:mm) ");
        DateTime returnDate = DateTime.Parse(Console.ReadLine());

        System.Console.Write("Enter price per hour: $");
        double pricePerHour = double.Parse(Console.ReadLine());

        System.Console.Write("Enter price per day: $");
        double pricePerDay = double.Parse(Console.ReadLine());

        Car rentalCar = new Car(model, color, pricePerHour, pricePerDay);

        RentalService rentalService = new RentalService(rentalsList);

        rentalService.CreateRental(rentalCar, pickupDate, returnDate);

        ShowRentals(rentalsList);


    }

    public static void ShowRentals(List<Rental> rentals)
    {
        foreach (Rental rental in rentals)
        {
            System.Console.WriteLine(rental.ToString());
        }
    }


}