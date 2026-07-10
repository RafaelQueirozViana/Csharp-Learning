namespace Course {
    class Program {
        static void Main(string[] args) {

            Product product1 = new Product("TV", 500.0, 10);

            product1.Name = "Phone";
            product1.Price = 300.0;
            product1.Quantity = 3;


            Console.WriteLine(product1.Name);
            Console.WriteLine(product1.Price);
            Console.WriteLine(product1.Quantity);




        }


    }
}