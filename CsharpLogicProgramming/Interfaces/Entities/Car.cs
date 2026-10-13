public class Car {
    public CarModel Model { get; private set; }
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }
    public Car(CarModel model) {
        Model = model;
    }


}