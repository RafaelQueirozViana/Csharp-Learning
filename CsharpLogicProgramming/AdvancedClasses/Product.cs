using System.Globalization;

namespace Course {
    public class Product {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }


        public Product(string name, double price) {
            this._name = name;
            this.Price = price;
        }

        public Product(string name, double price, int quantity) {
            this._name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }







        public double ValorTotalEmEstoque() {
            return Price * Quantity;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantity += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantity -= quantidade;

        }
        public override string ToString() {
            return _name
            + ", $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}