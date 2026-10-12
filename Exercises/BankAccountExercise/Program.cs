namespace BankAccountExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.Write("Type your account number: ");
                int accNumber = int.Parse(Console.ReadLine());

                System.Console.Write("Type your account holder: ");
                string accHolder = Console.ReadLine();

                Account account = new Account(accNumber, accHolder, 500, 300);

                System.Console.WriteLine("Account created succesfully!");
                System.Console.WriteLine("---------");
                System.Console.WriteLine(account.ToString());
                System.Console.WriteLine("---------");

                System.Console.Write("How much do you wanna deposit to your account? $");
                double depositAmount = double.Parse(Console.ReadLine());
                account.Deposit(depositAmount);

                System.Console.Write("How much do you wanna withdraw of your account? $");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.WithDraw(withdrawAmount);

                System.Console.WriteLine("---------");
                System.Console.WriteLine(account.ToString());
                System.Console.WriteLine("---------");

            }
            catch (DomainException e)
            {
                System.Console.WriteLine("Account error: " + e.Message);
            }

            catch (Exception e)
            {
                System.Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
