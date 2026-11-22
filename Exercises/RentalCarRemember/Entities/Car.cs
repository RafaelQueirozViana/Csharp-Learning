public class Car
{
    public string Model { get; private set; }
    public Color Color { get; private set; }
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }


    public Car(string model, Color color, double pricePerHour, double pricePerDay)
    {
        Model = model;
        Color = color;
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }




}