public class Order
{
    public DateTime Moment { get; private set; }
    public Status OrderStatus { get; private set; }
    public List<OrderItem> ProductsList { get; private set; } = [];

    public Client OrderClient { get; private set; }

    public Order(Client client)
    {
        OrderStatus = Status.PendingPayment;
        OrderClient = client;
    }


    public void AddItem(OrderItem item)
    {
        Moment = DateTime.Now;
        ProductsList.Add(item);

    }

    public void RemoveItemById(int id)
    {
        OrderItem? foundItem = ProductsList.Find(item => item.Id == id);

        if (foundItem != null)
        {
            ProductsList.Remove(foundItem);

        }

    }

    public double GetTotal()
    {
        return ProductsList.Sum(item => item.SubTotal());
    }




}