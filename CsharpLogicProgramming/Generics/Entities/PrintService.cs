public class PrintService {
    private int[] _numbersVector;
    private int _count = 0;

    public PrintService() {
        _numbersVector = new int[3];

    }

    public void AddValue(int value) {
        if (_count == 10) {
            throw new InvalidOperationException("PrintService is full!");
        }
        _numbersVector[_count] = value;
        _count++;

    }
    public int First() {
        if (_count == 0) {
            throw new InvalidOperationException("Error: the list is empty!");
        }
        return _numbersVector[0];
    }

    public void Print() {
        if (_count == 0) {
            throw new InvalidOperationException("Error: the list is empty");
        }
        System.Console.Write("[");
        for (int i = 1; i <= _count - 1; i++) {
            System.Console.Write($"{_numbersVector[i - 1]}, ");
        }

        System.Console.WriteLine(_numbersVector[_count - 1]);


        System.Console.Write("]");

    }


}