namespace Vectors {
    internal class Program {
        static void Main(string[] args) {

            bool wannaContinue = true;
            Product[] productsArray = null;

            while (wannaContinue) {

                char choice = getChoice();

                if (choice == '1') {

                    if (productsArray == null) {
                        Console.WriteLine("How many products do you wanna buy");
                        int totalProducts = int.Parse(Console.ReadLine());

                        productsArray = new Product[totalProducts];

                        addProductsToArray(productsArray);
                    }

                    else {
                        Console.WriteLine("You can't buy new products again.");
                    }

                }

                else if (choice == '2') {
                    if (productsArray != null) {
                        Console.WriteLine("--------");
                        Console.WriteLine("Your Products on the cart:");

                        for (int i = 0; i < productsArray.Length; i++) {
                            Console.WriteLine($"{i + 1}: {productsArray[i].getProductInfo()}");
                        }

                        Console.WriteLine($"The average price of these products is: {getAveragePrice(productsArray)}");

                        Console.WriteLine("--------");
                        Console.WriteLine();
                    }

                    else {
                        Console.WriteLine("Your cart is empty, try to buy products.");
                    }
                }

                else {
                    wannaContinue = false;
                }
            }
        }

        static char getChoice() {
            Console.WriteLine("What do you wanna do?");

            Console.WriteLine("[1] - Buy Products");
            Console.WriteLine("[2] - See the Cart");
            Console.WriteLine("[3] - Close Program");
            char choice = char.Parse(Console.ReadLine());

            return choice;
        }

        static void addProductsToArray(Product[] array) {

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Type the product name");
                string productName = Console.ReadLine();
                Console.WriteLine("Type the product price");
                double productPrice = double.Parse(Console.ReadLine());

                array[i] = new Product(productName, productPrice);
            }


        }

        static double getAveragePrice(Product[] array) {
            double sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i].Price;
            }

            Console.WriteLine($"Sum: {sum}");

            return sum / array.Length;
        }

    }
}
