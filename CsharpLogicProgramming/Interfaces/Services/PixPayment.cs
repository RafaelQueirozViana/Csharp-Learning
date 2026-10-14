public class PixPayment : IPayment {
    public PaymentStatus ProcessPayment(double amount) {

        System.Console.WriteLine("QR Code generated! $" + amount);
        bool sucessfullPayment = false;

        if (!sucessfullPayment) {
            return PaymentStatus.Failed;
        }

        else {
            return PaymentStatus.Completed;
        }


    }

}