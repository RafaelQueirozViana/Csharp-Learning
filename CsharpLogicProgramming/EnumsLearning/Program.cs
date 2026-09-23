namespace Enums {
    internal class Program {
        static void Main(string[] args) {

            System.Console.WriteLine("Type your worker level");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Order MyOrder = new Order(1, level, DateTime.Now);

            System.Console.WriteLine(MyOrder.GetLevelInfo());

            System.Console.WriteLine(MyOrder.Moment);
            System.Console.WriteLine(MyOrder.Status);





        }
    }
}
