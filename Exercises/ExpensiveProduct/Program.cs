namespace highNumberProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculationService calculationService = new CalculationService();

            List<Product> products = [new Product("phone", 5000), new Product("TV", 4000)];

            Product expProduct = calculationService.GetExpensiveItem<Product>(products);

          



            System.Console.WriteLine($" {expProduct.Name},{expProduct.Price}");

            



        }




    }
}


