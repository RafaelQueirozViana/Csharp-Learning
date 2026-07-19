namespace ParamsModifier {
    internal class Calculator {


        public static int Sum(params int[] numbers) {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            return sum;
        }

        // Ref 

        public static void Triple(ref int number) {
            number *= 3;
        }



    }
}
