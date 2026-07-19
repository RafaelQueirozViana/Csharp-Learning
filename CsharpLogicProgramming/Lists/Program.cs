namespace Lists {
    internal class Program {
        static void Main(string[] args) {

            List<string> personsList = new List<string>() { "Nicolas", "Pedro", "Paulo", "Allex" };

            personsList.Add("João");
            personsList.Insert(3, "Gabriel");

            foreach (string currentValue in personsList) {
                Console.WriteLine(currentValue);
            }

            Console.WriteLine("------------");

            string nameFounded = personsList.Find(currentValue => currentValue[0] == 'P');
            Console.WriteLine(nameFounded);


            int position = personsList.FindIndex(currentValue => currentValue == "Pedro");
            Console.WriteLine($"Position First: {position}");

            int position2 = personsList.FindLastIndex(currentValue => currentValue[0] == 'J');
            Console.WriteLine($"Position Last: {position2}");


            // Making a filter in the List

            List<string> filteredPersons = personsList.FindAll(currentValue => currentValue.Length == 5);

            Console.WriteLine("-------------");

            Console.WriteLine("Filtered List with all names that have 5 chars:");

            foreach (string currentValue in filteredPersons) {
                Console.WriteLine(currentValue);
            }


        }
    }
}
