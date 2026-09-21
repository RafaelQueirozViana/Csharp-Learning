class Order {
    public int Id { get; private set; }
    public DateTime Moment { get; private set; }
    public StatusEnum Status { get; private set; }

    public Order(int id, DateTime moment, StatusEnum status) {
        Id = id;
        Moment = moment;
        Status = status;
    }
}