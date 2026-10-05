public class UsedProduct : Product
{
    public DateTime ManufactureDate;
    public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) $ {Price} (Manufactured: {ManufactureDate})";
    }
}