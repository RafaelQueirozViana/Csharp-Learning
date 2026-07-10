using System.Globalization;

namespace Course {
    public class Product {
        private string _name;
        private double _price;
        private int _quantity;


        public Product(string name, double price) {
            this._name = name;
            this._price = price;
        }

        public Product(string name, double price, int quantity) {
            this._name = name;
            this._price = price;
            this._quantity = quantity;
        }

        public string getName() {
            return this._name;
        }

        public double getPrice() {
            return _price;
        }

        public int getQuantity() {
            return _quantity;
        }

        public void setName(string newName) {
            _name = newName;
        }



        public double ValorTotalEmEstoque() {
            return _price * _quantity;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantity += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantity -= quantidade;

        }
        public override string ToString() {
            return _name
            + ", $ "
            + _price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantity
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}