class Order {
    public int Id { get; private set; }
    public DateTime Moment { get; private set; }
    public StatusEnum Status { get; private set; }

    public WorkerLevel Level { get; private set; }

    public Order(int id, WorkerLevel level , DateTime moment) {
        Id = id;
        Level = level;
        Moment = moment;
        Status = StatusEnum.PendingPayment;
    }

    public string GetLevelInfo() {

        string message;

        if (Level == WorkerLevel.Junior) {
            message = $"You're a {Level}  beginner";
        }

        else if (Level == WorkerLevel.MidLevel) {
            message = "you have a intermediate knowledge, you're midlevel";
        }

        else {
            message = "You're a senior, you have much knowledge";
        }

        return message;
    }
}