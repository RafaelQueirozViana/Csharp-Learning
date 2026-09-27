using Enums.Entities;
using Enums.Entities.Enums;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order firstOrder = new Order { Id = 2, Moment = DateTime.Now, Status = OrderStatus.Delivered };

            System.Console.WriteLine(firstOrder.Status);

            




        }
    }

}
