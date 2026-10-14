public class OrderService {

    private IPayment _paymentService;
    public OrderService(IPayment paymentService) {
        _paymentService = paymentService;
    }

    public void PlaceOrder(Order order) {
        PaymentStatus status = _paymentService.ProcessPayment(order.TotalPrice());

        if (status == PaymentStatus.Failed) throw new DomainException("The payment failed");

    }
}