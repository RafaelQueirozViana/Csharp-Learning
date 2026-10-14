namespace Interfaces;

class Program
{
    static void Main()
    {
        try
        {
            System.Console.WriteLine("Enter rental data");
            System.Console.Write("Car model: ");
            string model = Console.ReadLine();

            System.Console.Write("Pickup (dd/MM/yyyy hh:mm) ");
            DateTime pickupDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Return (dd/MM/yyyy hh:mm) ");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Enter price per hour: $");
            double pricePerHour = double.Parse(Console.ReadLine());

            System.Console.Write("Enter price per day: $");
            double pricePerDay = double.Parse(Console.ReadLine());

            VehicleRental vehicleRental = new VehicleRental(pickupDate, returnDate, new Vehicle(model));

            RentalService rentalService = new RentalService(new BrazilTaxService());

            rentalService.ProcessRental(vehicleRental, pricePerHour, pricePerDay);

            System.Console.WriteLine("INVOICE: ");
            System.Console.WriteLine(vehicleRental.ToString());

        }

        catch (DomainException e)
        {
            System.Console.WriteLine("Invalid Rental Error: " + e.Message);
        }

        catch (Exception e)
        {
            System.Console.WriteLine("Unexpected error: " + e.Message);
        }



    }
}