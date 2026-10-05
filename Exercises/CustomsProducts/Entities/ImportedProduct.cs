public class ImportedProduct : Product
{
    public double CustomsFee;
    public ImportedProduct(string name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public override string PriceTag()
    {
        return $"{Name}: $ {Price + CustomsFee}, (CustomsFee: ${CustomsFee})";
    }

}