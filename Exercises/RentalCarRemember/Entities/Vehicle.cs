public abstract class Vehicle
{
    public string Model;
    public Color Color;

    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    public Vehicle(string model, Color color, double pricePerHour, double pricePerDay)
    {
        Model = model;
        Color = color;
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }


}