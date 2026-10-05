public class NaturalPerson : Person
{

    public double HealthExpenses;
    public NaturalPerson(string name, double annualIncome, double healthcareExpenses) : base(name, annualIncome)
    {
        HealthExpenses = healthcareExpenses;
    }

    public override double CalculateTaxes()
    {
        double totalTax = 0;

        if (AnnualIncome < 20000)
        {
            totalTax = (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
        }

        else if (AnnualIncome >= 20000)
        {
            totalTax = (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
        }

        return totalTax;
    }


}