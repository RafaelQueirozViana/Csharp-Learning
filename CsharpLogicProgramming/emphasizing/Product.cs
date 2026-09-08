public class Product {

    public int Id { get; private set; }
    public string ProductName { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(int id, string name, double price, int quantity) {
        ProductName = name;
        Price = price;
        Quantity = quantity;
        Id = id;
    }



}