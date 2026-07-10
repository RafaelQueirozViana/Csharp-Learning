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

        public string Name {
            get {
                return _name;
            }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }

        }


        public double Price {
            get { return _price; }
            set {
                if (value > 0) {
                    _price = value;
                }

            }
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