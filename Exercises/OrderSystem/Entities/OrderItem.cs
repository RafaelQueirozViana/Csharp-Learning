public class OrderItem
{
    public int Id { get; private set; }
    public int Quantity { get; private set; }
    public Product Product;
    public double Price { get; private set; } // here we are repeating the same price attribute, because the Product object can change it's data like to change the price. Then we need to create another Price attribute to the orderItem to keep the same price when it was ordered independing of the product current price


    public OrderItem(int id, int quantity, Product product)
    {
        Id = id;
        Quantity = quantity;
        Product = product;
        Price = Product.Price;



    }

    public double SubTotal()
    {
        return Price * Quantity;

    }

    public string GetOrderInfo()
    {
        return $"Id: {Id}, Product: {Product.Name}, Quantity: {Quantity}, SubTotal: ${SubTotal()}";
    }



}