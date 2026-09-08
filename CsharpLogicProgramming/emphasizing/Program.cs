namespace CsharpLogicProgramming {
    class Program {
        static void Main(string[] args) {
            // -------------- Variables Types: ----------------

            /* 
             int age = 20;
            long longNumber = 10000000;
            double price = 2.300;
            string name = "Pedro";
            bool isTrue = false;
            char letter = 'C';

            int newAge = age;
            newAge = 2;

            System.Console.WriteLine(age);
            System.Console.WriteLine(newAge); // it cloned, because these types of variable are cloned in the stack

            string secondName = name;
            secondName = "other";

            System.Console.WriteLine(name);
            System.Console.WriteLine(secondName);

            System.Console.WriteLine(name);

            System.Console.WriteLine($"o senhor {name} tem {age} anos, e recebe ${price} de salário"); 
             */



            // --------- Inputs, conditionals structure and loops: ---------------

            /*  System.Console.WriteLine("Type your name");
             string name = Console.ReadLine();

             System.Console.WriteLine("Type your age");
             int userAge = int.Parse(Console.ReadLine());


             System.Console.WriteLine($"name: {name}, age: {userAge}");

             if (userAge >= 18)
             {
                 System.Console.WriteLine("he has permission");
             }
             else
             {
                 System.Console.WriteLine("permission denied");
             }

             System.Console.WriteLine(getFormatedName(name));

             System.Console.WriteLine($"The bigger number is: {getHigherNumber(2, 2)}");

              int correctGuess = 5;

            int guessNumber = int.Parse(Console.ReadLine());

            while (guessNumber != correctGuess)
            {
                System.Console.WriteLine("Guess wrong, try again");
                guessNumber = int.Parse(Console.ReadLine());



            }

            System.Console.WriteLine("Congratulations! you won!");

  */

            // ------------ Employees higher salary exercise --------------

            /*  Worker employee1;
             Worker employee2;

             Worker[] workers = new Worker[2];

             string choosedName;
             int choosedAge;
             double choosedSalary;

             for (int i = 0; i <= 1; i++) {

                 System.Console.WriteLine($" I IS EQUAL: {i}");

                 System.Console.WriteLine("Register the first employee:");

                 System.Console.WriteLine("Name:");
                 choosedName = Console.ReadLine();

                 System.Console.WriteLine("Age:");
                 choosedAge = int.Parse(Console.ReadLine());

                 System.Console.WriteLine("Salary:");
                 choosedSalary = double.Parse(Console.ReadLine());

                 workers[i] = new Worker(choosedName, choosedAge, choosedSalary);

             }

             System.Console.WriteLine(workers[0].Name);
             System.Console.WriteLine(workers[1].Name);


             Worker higherSalaryEmployee = WorkerService.getHigherSalary(workers[0], workers[1]);
             System.Console.WriteLine($"The Worker who has higher salary is {higherSalaryEmployee.Name}, receveing ${higherSalaryEmployee.Salary} a Mounth");
  */






            // ------------ Triangle Exercise ----------------

            /*     System.Console.WriteLine("Type the first triangle measurements");

                Triangle myTriangle = new Triangle(2, 4, 3);
                Triangle otherTriangle = myTriangle;


     */


        }

        /*   static string getFormatedName(string name)
          {
              return $"{name} was formated!";
          }

          static int getHigherNumber(int num1, int num2)
          {
              int result;
              if (num1 > num2)
              {
                  result = num1;
              }

              else
              {
                  result = num2;
              }

              return result;


          } */

    }
}
