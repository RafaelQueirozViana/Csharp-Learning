// See https://aka.ms/new-console-template for more information



bool isRunning = true;

while (isRunning)
{
    System.Console.WriteLine("How many numbers do you want to repeat");

    int repeatTimes = int.Parse(Console.ReadLine());

    double sum = 0;

    for (int i = 1; i <= repeatTimes; i++)

    {
        System.Console.WriteLine($"type your number {i}: ");
        sum += double.Parse(Console.ReadLine());
    }

    System.Console.WriteLine($"the sum result of this operation is: {sum}");

    System.Console.WriteLine("Do you want to continue the program? y/n");
    if (Console.ReadLine() != "y")
    {
        System.Console.WriteLine("program ended");
        isRunning = false;
    }
}

/*
   bool isRunning = true;

         while(isRunning)
            {
                System.Console.WriteLine("Type a number");

                int choosedNumber = int.Parse(Console.ReadLine());

                if(choosedNumber >=0)
                {
                int result = choosedNumber * choosedNumber;
                System.Console.WriteLine($"the result of the raiz is: {result}");
                }

                else
                {
                    System.Console.WriteLine("You put a invalid number, the pr ogram will end");
                    isRunning = false;
                }



}

*/