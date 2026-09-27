public class OrderItem
{
    public int Id { get; private set; }
    public int Quantity { get; private set; }
    public Product Product;
    public double Price { get; private set; }

    public OrderItem(int id, int quantity, Product product)
    {
        Id = id;
        Quantity = quantity;
        Product = product;

    }

    public double SubTotal()
    {
        Price = Product.Price * Quantity;

        return Price;
    }



}