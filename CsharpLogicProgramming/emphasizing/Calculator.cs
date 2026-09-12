public class Calculator {

    public static double Sum(params double[] numbers) {

        double sumTotal = 0;

        foreach (double currentNumber in numbers) {
            sumTotal += currentNumber;
        }


        return sumTotal;
    }

}