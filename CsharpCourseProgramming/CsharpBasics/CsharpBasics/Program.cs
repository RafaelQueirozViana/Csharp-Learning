using System;

namespace CsharpBasics {
    internal class Program {
        static void Main(string[] args) {

            string username = "nicolas";
            int age = 20;
            double totalInAccount = 30000.99;
            char genre = 'M';
            long binaries = 30000000L;
            bool isWorking = true;


            Console.WriteLine($"The user {username} has ${totalInAccount} in his account and it's {isWorking}");

        }
    }
}