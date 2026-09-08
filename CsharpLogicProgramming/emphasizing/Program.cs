namespace CsharpLogicProgramming {
    class Program {
        static void Main(string[] args) {
            // 1 -------------- Variables Types: ----------------

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



            // 2 --------- Inputs, conditionals structure and loops: ---------------

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

            // 3 ------------ Employees higher salary exercise --------------

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

            // 4 ------------ Triangle Exercise ----------------

            /*   Triangle firstTriangle;
              Triangle secondTriangle;

              double sideA, sideB, sideC;

              System.Console.WriteLine("Type the first triangle measurements");

              System.Console.WriteLine("Type the side A");
              sideA = double.Parse(Console.ReadLine());

              System.Console.WriteLine("Type the side B");
              sideB = double.Parse(Console.ReadLine());

              System.Console.WriteLine("Type the side c");
              sideC = double.Parse(Console.ReadLine());

              firstTriangle = new Triangle(sideA, sideB, sideC);

              System.Console.WriteLine("Type the second triangle measurements");


              System.Console.WriteLine("Type the side A");
              sideA = double.Parse(Console.ReadLine());

              System.Console.WriteLine("Type the side B");
              sideB = double.Parse(Console.ReadLine());

              System.Console.WriteLine("Type the side c");
              sideC = double.Parse(Console.ReadLine());

              secondTriangle = new Triangle(sideA, sideB, sideC);

              System.Console.WriteLine($"The triangle 1 result is: {firstTriangle.getArea()}");

              System.Console.WriteLine($"The triangle 2 result is: {secondTriangle.getArea()}"); */


            // 5 ---------- Products management menu ----------

            List<Product> productsList = [];

            bool continueMenu = true;

            while (continueMenu == true) {
                System.Console.WriteLine("----- Stock Control Menu -----");
                System.Console.WriteLine("What do you wanna do:");
                System.Console.WriteLine("1 - See all products on stock");
                System.Console.WriteLine("2 - Register a new product");
                System.Console.WriteLine("3 - Remove a product from stock");
                System.Console.WriteLine("4 - Exit the program");



                char action = char.Parse(Console.ReadLine());

                if (action == '1') {
                    ShowProductsList(StockService.GetProductsList());
                }

                else if (action == '2') {

                    System.Console.WriteLine("");
                    System.Console.WriteLine("");


                    System.Console.WriteLine("How many products do you wanna add?");
                    int productsToAdd = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= productsToAdd; i++) {
                        string productName;
                        double productPrice;
                        int productQuantity;
                        int productId;


                        System.Console.WriteLine("Type the product id");
                        productId = int.Parse(Console.ReadLine());


                        System.Console.WriteLine("Type the product name");
                        productName = Console.ReadLine();

                        System.Console.WriteLine("Type the product price");
                        productPrice = double.Parse(Console.ReadLine());

                        System.Console.WriteLine("Type the product quantity");
                        productQuantity = int.Parse(Console.ReadLine());

                        Product productToCreate = new Product(productId, productName, productPrice, productQuantity);

                        StockService.AddProduct(productToCreate);

                        System.Console.WriteLine("");
                        System.Console.WriteLine("");

                    }

                }

                else if (action == '3') {
                    System.Console.WriteLine("Type the product id of the product you wanna remove from stock");
                    int idToRemove = int.Parse(Console.ReadLine());

                    string logMessage = StockService.RemoveProduct(idToRemove);

                    System.Console.WriteLine("");
                    System.Console.WriteLine("");

                    System.Console.WriteLine(logMessage);

                    System.Console.WriteLine("");
                    System.Console.WriteLine("");
                }

                else {
                    System.Console.WriteLine("The program will end.");
                    continueMenu = false;
                }
            }


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

        static void ShowProductsList(List<Product> productsList) {

            System.Console.WriteLine("");
            System.Console.WriteLine("");

            if (productsList.Count > 0) {
                productsList.ForEach((product) => {
                    System.Console.WriteLine($"- Product id: {product.Id}, name: {product.ProductName}, quant: s{product.Quantity}, Price: ${product.Price}");
                });
            }

            else {
                System.Console.WriteLine("There isn't any product on stock yet");
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("");





        }



    }
}
