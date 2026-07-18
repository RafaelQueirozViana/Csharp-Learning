namespace Vectors {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Type how many people to see the height");
            int totalPeople = int.Parse(Console.ReadLine());

            double[] heightVector = new double[totalPeople];

            for (int i = 0; i < heightVector.Length; i++) {
                Console.WriteLine($"type the height of the person {i + 1}");
                heightVector[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The average between these people is:");
            Console.WriteLine(heightVector.Average());

        }
    }


}
