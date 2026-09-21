namespace LearningEnums {
    internal class Program {
        static void Main(string[] args) {

            Order firstOrder = new Order(1, DateTime.Now, StatusEnum.Delivered);

            System.Console.WriteLine(firstOrder.Status);






        }
    }
}
