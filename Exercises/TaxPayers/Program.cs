using System.Buffers;

namespace TaxPayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How many tax payers you wanna add?: ");
            int repeatTimes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= repeatTimes; i++)
            {
                System.Console.Write("Type the person name: ");
                string name = Console.ReadLine();

                System.Console.Write("Type the annual income: $");
                double annualIncome = double.Parse(Console.ReadLine());

                System.Console.WriteLine("Which type of person you are?");
                System.Console.Write("Natural Person or Legal Person (n/l)?: ");
                char personType = char.Parse(Console.ReadLine());

                if (personType == 'n')
                {
                    System.Console.Write("type the healthcare expenses: $");
                    double healthCosts = double.Parse(Console.ReadLine());
                    PersonService.AddPerson(new NaturalPerson(name, annualIncome, healthCosts));
                }

                else if (personType == 'l')
                {
                    System.Console.Write("Total employees of your company: $");
                    int totalEmployees = int.Parse(Console.ReadLine());
                    PersonService.AddPerson(new LegalPerson(name, annualIncome, totalEmployees));
                }

                else
                {
                    System.Console.WriteLine("Error: you typed an invalid option");
                }
            }

            foreach (Person currentPerson in PersonService.PersonsList)
            {
                System.Console.WriteLine($"{currentPerson.Name}: Total Taxes: ${currentPerson.CalculateTaxes()}");
            }
        }

    }
}


