public class Order
{
    public DateTime Moment { get; private set; }
    public Status OrderStatus { get; private set; }
    public List<OrderItem> ProductsList { get; private set; } = [];

    public void AddItem(OrderItem item)
    {
        Moment = DateTime.Now;
        ProductsList.Add(item);
        OrderStatus = Status.PendingPayment;
    }

    public void RemoveItemById(int id)
    {
        OrderItem foundItem = ProductsList.Find(item => item.Id == id);
        ProductsList.Remove(foundItem);
    }

    public double GetTotal()
    {
        return ProductsList.Sum(item => item.SubTotal());
    }




}