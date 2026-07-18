namespace Vectors {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("type how many numbers do you want to storage");
            int totalNum = int.Parse(Console.ReadLine());

            double[] numsVect = new double[totalNum];

            for (int i = 0; i < numsVect.Length; i++) {
                Console.WriteLine($"type the number {i}: ");
                numsVect[i] = double.Parse(Console.ReadLine());

            }

            Console.WriteLine("Storaged values on array:");
            for (int i = 0; i < numsVect.Length; i++) {
                Console.WriteLine(numsVect[i]);
            }







        }
    }
}
