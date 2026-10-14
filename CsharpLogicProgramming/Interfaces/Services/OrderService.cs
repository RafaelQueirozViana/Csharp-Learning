public class OrderService {

    private IPayment _payment1;
    public OrderService(IPayment payment) {
        _payment1 = payment;
    }
    public void PlaceOrder(Order order) {
        _payment1.ProcessPayment(order.TotalPrice());
       
    }
}