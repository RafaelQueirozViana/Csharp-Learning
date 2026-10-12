namespace Interfaces;

class Program {
    static void Main() {

        try {
            System.Console.WriteLine("Enter rental data");
            System.Console.Write("Car model: ");
            CarModel carModel = Enum.Parse<CarModel>(Console.ReadLine());

            System.Console.Write("Pickup (dd/MM/yyyy hh:ss) ");
            DateTime pickupDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Return (dd/MM/yyyy hh:ss) ");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Enter price per hour: $");
            double pricePerHour = double.Parse(Console.ReadLine());

            System.Console.Write("Enter price per day: $");
            double pricePerDay = double.Parse(Console.ReadLine());

            Car rentalCar = new Car(carModel, pickupDate, returnDate, pricePerHour, pricePerDay);

            System.Console.WriteLine("INVOICE:");
            System.Console.WriteLine("Basic Payment: $" + rentalCar.GetBasicPayment());
            System.Console.WriteLine("Tax: $" + rentalCar.GetTax());
            System.Console.WriteLine("Total Payment: $" + rentalCar.GetTotalPayment());
        }

        catch (Exception e) {
            System.Console.WriteLine("Unexpected error: " + e.Message);
        }



    }
}