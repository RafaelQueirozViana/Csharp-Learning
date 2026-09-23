public class Contract {
    public DateTime Date { get; private set; }
    public double ValuePerHour { get; private set; }
    public int Duration { get; private set; }

    public Contract() {
    }

    public Contract(DateTime contractDate, double valuePerHour, int duration) {
        Date = contractDate;
        ValuePerHour = valuePerHour;
        Duration = duration;
    }

    public double totalValue() {
        return ValuePerHour * Duration;
    } 

    



}
