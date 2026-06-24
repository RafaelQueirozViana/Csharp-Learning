using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    internal class Product {
        public string name;
        public double price;
        public int quantity;

        public double getTotalValueOnStock() {
            return price * quantity;
        }

        public void increaseProduct(int productsQuantity) {
            quantity+= productsQuantity;
        }

        public void decreaseProduct(int productsQuantity) {
            quantity -= productsQuantity;
        }

        public string getProductDetails() {

        }

       


    }
}
