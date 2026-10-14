public class Order {
    public int Id { get; private set; }
    public List<Product> ProductsList { get; private set; }

    public Order(int id) {
        Id = id;
        ProductsList = [];
    }

    public void AddProduct(Product product) {
        ProductsList.Add(product);
    }

    public double TotalPrice() {
        double totalPrice = 0;

        foreach (Product product in ProductsList) {
            totalPrice += product.Price;
        }

        return totalPrice;

    }


}