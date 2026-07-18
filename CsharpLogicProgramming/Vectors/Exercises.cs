namespace Vectors {
    internal static class Exercises {

        public static void VectorsTheory() {

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

        public static void HeightExercise() {

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
