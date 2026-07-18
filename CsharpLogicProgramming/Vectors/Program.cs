namespace Vectors {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("How many products do you wanna buy");
            int totalProducts = int.Parse(Console.ReadLine());

            Product[] productsArray = new Product[totalProducts];

            for (int i = 0; i < productsArray.Length; i++) {
                Console.WriteLine("Type the product name");
                string productName = Console.ReadLine();
                Console.WriteLine("Type the product price");
                double productPrice = double.Parse(Console.ReadLine());

                productsArray[i] = new Product(productName, productPrice);
            }

            Console.WriteLine("--------");
            Console.WriteLine("Your Products on the cart:");

            for (int i = 0; i < productsArray.Length; i++) {
                Console.WriteLine($"{i + 1}: {productsArray[i].getProductInfo()}");
            }





            //Console.WriteLine("Do you wanna see your products cart? (y/n) ");
            //char seeCart = char.Parse(Console.ReadLine());



        }
    }


}
