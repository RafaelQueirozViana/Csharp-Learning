namespace Vectors {
    internal class Product {

        public string Name { get; private set; }
        public double Price { get; private set; }

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
