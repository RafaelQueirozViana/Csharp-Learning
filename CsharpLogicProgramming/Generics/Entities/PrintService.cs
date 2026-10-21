public class PrintService<T> {
    private T[] _numbersVector;
    private int _count = 0;

    public PrintService() {
        _numbersVector = new T[3];
    }
    public void AddValue(T value) {
        if (_count == 3) {
            throw new InvalidOperationException("You can add just 3 values at maximum in the vector!");
        }
        _numbersVector[_count] = value;
        _count++;

    }
    public T First() {
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

        System.Console.Write(_numbersVector[_count - 1]);
        System.Console.Write("]");

    }


}