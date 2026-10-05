public static class ProductService
{
    public static List<Product> Products { get; private set; } = [];

    public static void AddProduct(Product product)
    {
        Products.Add(product);
    }
}