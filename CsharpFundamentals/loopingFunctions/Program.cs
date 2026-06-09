// See https://aka.ms/new-console-template for more information


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
                    System.Console.WriteLine("You put a invalid number, the program will end");
                    isRunning = false;
                }



            }