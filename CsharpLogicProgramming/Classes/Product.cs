using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    internal class Product {
        public string Name;
        public double Price;
        public int Quantity;

        public double GetTotalValueOnStock() {
            return Price * Quantity;
        }

        public void IncreaseProduct(int productsQuantity) {
            Quantity += productsQuantity;
        }

        public void DecreaseProduct(int productsQuantity) {
            Quantity -= productsQuantity;
        }

        public override string ToString() {
            return $"{Name}, $ {Price}, {Quantity} units, Total: $ {GetTotalValueOnStock()}, ";
        }

     

       


    }
}
