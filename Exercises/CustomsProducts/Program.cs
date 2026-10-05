namespace CustomsProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How many products to add? ");
            int repeatTimes = int.Parse(Console.ReadLine());

            System.Console.WriteLine("");

            for (int i = 1; i <= repeatTimes; i++)
            {

                System.Console.WriteLine($"Product {i} data:");
                System.Console.WriteLine("");

                System.Console.WriteLine("Common, used or imported (c,u,i): ");
                char productType = char.Parse(Console.ReadLine().ToLower());

                System.Console.Write("Name: ");
                string name = Console.ReadLine();

                System.Console.Write("Price: $");
                double price = double.Parse(Console.ReadLine());

                if (productType == 'u')
                {
                    System.Console.Write("Manufactured Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    ProductService.AddProduct(new UsedProduct(name, price, date));
                }

                else if (productType == 'i')
                {
                    System.Console.Write("Customs fee: $");
                    double customsFee = double.Parse(Console.ReadLine());
                    ProductService.AddProduct(new ImportedProduct(name, price, customsFee));
                }

                else
                {
                    ProductService.AddProduct(new Product(name, price));
                }

                System.Console.WriteLine("");

                System.Console.WriteLine("======== Price Tags ======= ");

                System.Console.WriteLine("");


                foreach (Product CurrentProduct in ProductService.Products)
                {
                    System.Console.WriteLine(CurrentProduct.PriceTag());
                }










            }



        }




    }
}


