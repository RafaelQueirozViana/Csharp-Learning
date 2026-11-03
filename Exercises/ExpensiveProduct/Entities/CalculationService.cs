public class CalculationService
{
    public T GetExpensiveItem<T>(List<T> list) where T : IComparable<T>
    {
        if (list.Count == 0)
        {
            throw new ArgumentException("Error: the list is empty!");
        }

        T max = list[0];

        foreach (T item in list)
        {
            if (item.CompareTo(max) == 1)
            {
                max = item;
            }
        }

        return max;
    }

}