
/*

int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2 != 0)
    {
        System.Console.WriteLine(i);
    }
}








/*
System.Console.WriteLine("Type your number");
int choosedNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{choosedNumber} {i} = {choosedNumber * i}");
}

*/

// -------Exercise  - Make a triangle with for

/*

System.Console.WriteLine("Type a number");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{

    for (int j = 1; j <= i; j++)
    {
        System.Console.Write("*");


    }
    Console.WriteLine(" ");
}

*/

/*


// -------Exercise  - Show numeros primos


System.Console.WriteLine("Type the number");

int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 8; i += 2)
{
    System.Console.WriteLine(i);

}
*/


/*

// -------Exercise - Loop system using while


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

*/


// -------Exercise  - While structure

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