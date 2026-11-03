namespace HashSet {
    internal class Program {
        static void Main(string[] args) {


            HashSet<string> setCollection = [];

            setCollection.Add("Tv");
            setCollection.Add("Notebook");

            System.Console.WriteLine(setCollection);

            System.Console.WriteLine(setCollection.Contains("Tv"));




            foreach (string item in setCollection) {
                System.Console.WriteLine(item);
            }



        }
    }

}
