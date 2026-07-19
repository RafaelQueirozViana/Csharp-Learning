namespace ParamsModifier {
    internal class Program {
        static void Main(string[] args) {


            // Learning Params 
            int value1 = Calculator.Sum(2, 3, 4);

            int value2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(value2);


            // Learning ref

            //int a = 10;

            //Calculator.Triple(ref a);

            //Console.WriteLine(a);


            // Learning Out

            int a = 10;
            int result;

            Calculator.Triple(a, out result);


            Console.WriteLine(result);




        }
    }
}
