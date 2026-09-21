public class Contract {
    public DateTime ContractDate { get; private set; }
    public double ValuePerHour { get; private set; }
    public int Duration { get; private set; }

    public Contract(DateTime contractDate, double valuePerHour, int duration) {
        ContractDate = contractDate;
        ValuePerHour = valuePerHour;
        Duration = duration;
    }

    



}
