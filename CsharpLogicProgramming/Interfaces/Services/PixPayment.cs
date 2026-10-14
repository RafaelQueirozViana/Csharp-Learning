public class PixPayment() : IPayment {
    public void ProcessPayment(double amount) {
        System.Console.WriteLine("QR Code generated! $" + amount);
    }

    public void outro(double amount) {
        System.Console.WriteLine("QR Code generated! $" + amount);
    }
}