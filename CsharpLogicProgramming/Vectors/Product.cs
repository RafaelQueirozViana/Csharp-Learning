namespace Vectors {
    internal class Product {

        string Name;
        double Price;

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public void ApplyDiscount(double percentage) {
            Price -= (Price * percentage);
        }

        public string getProductInfo() {
            return $"Product: {Name}, Price: ${Price}";
        }


    }
}
