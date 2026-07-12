namespace MemoryBehavior {
    internal class Program {




        static void Main(string[] args) {


            double? a = null;
            double b = a ?? 20.0;

            if (a.HasValue) {
                Console.WriteLine($"It has the value {a.Value}");
                Console.WriteLine(a.GetValueOrDefault());
            }

            else {
                Console.WriteLine("It doesn't have value");
            }

            Console.WriteLine(b);





        }
    }
}
