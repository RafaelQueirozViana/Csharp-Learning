public class LegalPerson : Person
{
    public int TotalEmployees { get; private set; }
    public LegalPerson(string name, double annualIncome, int totalEmployees) : base(name, annualIncome)
    {
        TotalEmployees = totalEmployees;
    }

    public override double CalculateTaxes()
    {
        double totalTax = 0;

        if (TotalEmployees >= 10)
        {
            totalTax = AnnualIncome * 0.14;
        }
        else
        {
            totalTax = AnnualIncome * 0.16;
        }

        return totalTax;
    }


}