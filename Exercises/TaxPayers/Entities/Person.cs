public abstract class Person
{
    public string Name { get; private set; }
    public double AnnualIncome { get; private set; }

    public Person(string name, double rendaAnual)
    {
        Name = name;
        AnnualIncome = rendaAnual;
    }
    public abstract double CalculateTaxes();

}