public class Product : IComparable<Product>
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Product(string computer, double price)
    {
        Name = computer;
        Price = price;
    }

    public int CompareTo(Product product)
    {
        if (product == null)
        {
            throw new ArgumentException("Error: the product object can't be null");
        }

        return this.Price.CompareTo(product.Price);

    }


}