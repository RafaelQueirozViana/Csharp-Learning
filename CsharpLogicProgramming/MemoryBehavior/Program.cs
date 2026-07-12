namespace MemoryBehavior {
    internal class Program {




        static void Main(string[] args) {


            double? x = 13.0;

            double y = x ?? 10.0;

            Console.WriteLine(y);

        }
    }
}
