namespace OrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enther client data:");
            System.Console.Write("Name: ");
            string? name = Console.ReadLine();

            System.Console.Write("Email: ");
            string? email = Console.ReadLine();

            System.Console.Write("Birth date: (DD/MM/YYYY) ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client orderClient = new Client(name, email, birthDate);


            System.Console.WriteLine("Make your order:");
            System.Console.Write("How many items do you wanna add to your order? ");
            int itemsToAdd = int.Parse(Console.ReadLine());

            Order CurrentOrder = new Order(orderClient);

            for (int i = 1; i <= itemsToAdd; i++)
            {
                System.Console.WriteLine($"Enter product {i} data");

                System.Console.Write("Id: ");
                int productId = int.Parse(Console.ReadLine());


                System.Console.Write("Name: ");
                string productName = Console.ReadLine();

                System.Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine());

                System.Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());


                OrderItem orderObject = new OrderItem(productId, productQuantity, new Product(productName, productPrice));
                CurrentOrder.AddItem(orderObject);
            }

            ShowOrderSummary(CurrentOrder);

            System.Console.Write("Do you wanna delete one product of the order? (y/n) ");
            char wannaDelete = char.Parse(Console.ReadLine().ToLower());

            if (wannaDelete == 'y')
            {
                System.Console.Write("Type the product id to delete: ");
                int idToDelete = int.Parse(Console.ReadLine());
                CurrentOrder.RemoveItemById(idToDelete);

                ShowOrderSummary(CurrentOrder);
            }

            else
            {
                System.Console.WriteLine("end of the program, have a good night!");
            }

        }

        public static void ShowOrderSummary(Order order)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine(" ====== Order Summary ======");

            System.Console.WriteLine($"Order moment: {order.Moment}");
            System.Console.WriteLine($"Order status: {order.OrderStatus}");
            System.Console.WriteLine($"Client: {order.OrderClient.Name}, ({order.OrderClient.BirthDate.ToString("yyyy-MM-dd")}) - {order.OrderClient.Email}");
            System.Console.WriteLine("Order Items:");

            foreach (OrderItem currentOrder in order.ProductsList)
            {
                System.Console.WriteLine(currentOrder.GetOrderInfo());
            }

            System.Console.WriteLine($"Total Price: {order.GetTotal()}");

        }
    }
}
